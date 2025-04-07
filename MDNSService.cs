
using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

using Makaretu.Dns;

namespace EEBUS
{
	public class MDNSService
	{
        public MDNSService( IConfiguration configuration, IOptions<Settings> options )
        {
            this.settings = options.Value;

			this.serviceProfile = new EEBusServiceProfile( Dns.GetHostName(), settings.Id, "_ship._tcp", settings.Port );
		}

		private ServiceProfile    serviceProfile;
		private X509Certificate2  cert;
        private string            localSKI;
		private readonly Settings settings;

		public void AddProperty( string key, string value )
        {
            serviceProfile.AddProperty( key, value );
        }

        public X509Certificate2 Cert
        {
            get
            {
                return this.cert;
            }
        }

		public string LocalSKI
        {
            get
            {
                return this.localSKI;
            }
        }

        public void Run()
        {
            _ = Task.Run( async() =>
            {
                Thread.CurrentThread.IsBackground = true;

                MulticastService mdns = new MulticastService();
                ServiceDiscovery sd = new ServiceDiscovery( mdns );

				cert = CertificateGenerator.GenerateCert( Dns.GetHostName() );

				byte[] hash = SHA1.Create().ComputeHash( cert.GetPublicKey() );
				string localSKI = this.localSKI = Convert.ToHexString( hash ).ToLowerInvariant();
				// add spaces every 4 hex digits (EEBUS requirement)
				for ( int i = 4; i < this.localSKI.Length; i += 4 )
					this.localSKI = this.localSKI.Insert( i++, " " );

				// configure our EEBUS mDNS properties
				AddProperty( "name",     this.settings.Name);
				AddProperty( "id",       "ID:" + this.settings.Id + ";" );
				AddProperty( "path",     "/ship/" );
				AddProperty( "register", "true" );
				AddProperty( "ski",      localSKI );
				AddProperty( "brand",    this.settings.Brand);
				AddProperty( "type",     this.settings.Type);
				AddProperty( "model",    this.settings.Model);
				AddProperty( "serial",   this.settings.Serial);
				AddProperty( "host",     this.settings.Host );

				try
				{
                    mdns.Start();

                    sd.Advertise( serviceProfile );

                    await Task.Delay( -1 ).ConfigureAwait( false );
                }
                catch ( Exception ex )
                {
                    Console.WriteLine( ex.Message );
                }
                finally
                {
                    sd.Dispose();
                    mdns.Stop();
                }
            } );
        }
    }
}
