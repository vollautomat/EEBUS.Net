﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace EEBUS
{
	public class CertificateGenerator
	{
		public static X509Certificate2 GenerateCert( string subject )
		{
			string path		= Path.Combine( Directory.GetCurrentDirectory(), subject + ".pfx" );
			string password = Environment.GetEnvironmentVariable( "PFX_PASSWORD" ) ?? string.Empty;

			// check if we have a persisted cert already
			if ( File.Exists( path ) )
			{
				// load and return
				return new X509Certificate2( path );
			}
			else
			{
				try
				{
					string rootPath = Path.Combine( Directory.GetCurrentDirectory(), subject + ".pkcs12" );
					X509Certificate2 rootCertificate;
					if ( File.Exists( rootPath ) )
					{
						rootCertificate = new X509Certificate2( rootPath, "vollautomat" );
					}
					else
					{
						rootCertificate = CreateRootCertificate();
						File.WriteAllBytes( rootPath, rootCertificate.Export( X509ContentType.Pfx, "vollautomat" ) );
					}

					using ( ECDsa ecdsa = ECDsa.Create( ECCurve.NamedCurves.nistP256 ) )
					{
						// generate a new cert request with ECC and NIST curve P256 (TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, EEBUS requirement)
						CertificateRequest request = new CertificateRequest(
							//"cn=" + subject,
							"CN=localhost",
							ecdsa,
							HashAlgorithmName.SHA256 );

						// add Subject Key Identifier (EEBUS requirement)
						request.CertificateExtensions.Add( new X509SubjectKeyIdentifierExtension( request.PublicKey, false ) );

						// add DNS name and localhost IP address also as Subject Alternate Name
						SubjectAlternativeNameBuilder subjectAlternativeNameBuilder = new SubjectAlternativeNameBuilder();
						subjectAlternativeNameBuilder.AddDnsName( subject );
						request.CertificateExtensions.Add( subjectAlternativeNameBuilder.Build() );

						// add key usage
						request.CertificateExtensions.Add( new X509KeyUsageExtension(
							X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature,
							true ) );

						request.CertificateExtensions.Add( new X509EnhancedKeyUsageExtension(
							new OidCollection
							{
								new Oid( "1.3.6.1.5.5.7.3.1" ), // Server Authentication
								new Oid( "1.3.6.1.5.5.7.3.2" )  // Client Authentication
							},
							true ) );

						// create cert
						X509Certificate2 cert = request.Create(
							rootCertificate,
							DateTimeOffset.UtcNow.AddSeconds( -5 ),
							DateTimeOffset.UtcNow.AddYears( 5 ),
							Guid.NewGuid().ToByteArray() );

						cert = cert.CopyWithPrivateKey( ecdsa );
						// persist the cert
						File.WriteAllBytes( path, cert.Export( X509ContentType.Pfx, password ) );

						ExtractCertFile( cert, subject );	// needed by the vue frontend
						ExtractKeyFile( cert, subject );

						return cert;
					}
				}
				catch ( Exception ex )
				{
					Debug.WriteLine( "Cert generation error: " + ex.Message );
					throw;
				}
			}
		}

		private static X509Certificate2 CreateRootCertificate()
		{
			using ( ECDsa ecdsa = ECDsa.Create( ECCurve.NamedCurves.nistP256 ))
			{
				CertificateRequest request = new CertificateRequest(
					"CN=Vollautomat Root Certificate",
					ecdsa,
					HashAlgorithmName.SHA256 );

				// Setze die Extensions für das Root-Zertifikat
				request.CertificateExtensions.Add(
					new X509BasicConstraintsExtension( true, false, 0, true ) ); // Kennzeichnung als Root-Zertifikat
				request.CertificateExtensions.Add(
					new X509KeyUsageExtension(
						X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.DigitalSignature,
						true ) ); // Zertifikat darf andere signieren
				request.CertificateExtensions.Add(
					new X509SubjectKeyIdentifierExtension( request.PublicKey, false ) );

				// Erzeuge ein selbstsigniertes Zertifikat (10 Jahre gültig)
				return request.CreateSelfSigned(
					DateTimeOffset.Now,
					DateTimeOffset.Now.AddYears( 10 ) );
			}
		}

		private static void ExtractCertFile( X509Certificate2 certificate, string subject )
		{
			string pemPath = Path.Combine( Directory.GetCurrentDirectory(), subject + ".pem" );

			// Speichern des Zertifikats (Public Key)
			var publicKeyPem = "-----BEGIN CERTIFICATE-----\n" +
							   Convert.ToBase64String( certificate.RawData, Base64FormattingOptions.InsertLineBreaks ) +
							   "\n-----END CERTIFICATE-----";
				File.WriteAllText( pemPath, publicKeyPem );
		}

		private static void ExtractKeyFile( X509Certificate2 certificate, string subject )
		{
			string keyPath = Path.Combine( Directory.GetCurrentDirectory(), subject + ".key" );

			// Speichern des privaten Schlüssels
			var ecdsa = certificate.GetECDsaPrivateKey();
			if ( ecdsa != null )
			{
				var privateKeyBytes = ecdsa.ExportPkcs8PrivateKey();
				var privateKeyPem = "-----BEGIN PRIVATE KEY-----\n" +
									Convert.ToBase64String( privateKeyBytes, Base64FormattingOptions.InsertLineBreaks ) +
									"\n-----END PRIVATE KEY-----";
				File.WriteAllText( keyPath, privateKeyPem );
			}
		}
	}
}
