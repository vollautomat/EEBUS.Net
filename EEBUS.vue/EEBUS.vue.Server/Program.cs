using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using EEBUS;
using EEBUS.Models;
using EEBUS.Controllers;

namespace EEBUS.vue.Server
{
	public class Program
	{
		public static void Main( string[] args )
		{
			var builder = WebApplication.CreateBuilder( args );

			// Add services to the container.

			var services = builder.Services;

			services.Configure<KestrelServerOptions>( kestrelOptions =>
			{
				kestrelOptions.ConfigureHttpsDefaults( httpOptions =>
				{
					httpOptions.ServerCertificate			= CertificateGenerator.GenerateCert( Dns.GetHostName() );
					httpOptions.ClientCertificateMode		= ClientCertificateMode.NoCertificate;
					httpOptions.ClientCertificateValidation	= ValidateClientCert;
					httpOptions.SslProtocols				= SslProtocols.Tls12;
					httpOptions.OnAuthenticate				= (connectionContext, authenticationOptions) =>
					{
						authenticationOptions.EnabledSslProtocols = SslProtocols.Tls12;
					};
				} );
			} );

			var settings = builder.Configuration.GetSection( "Settings" );

			services.AddCors( options =>
			{
				options.AddPolicy( "AllowAll", builder =>
					builder.AllowAnyOrigin()
						   .AllowAnyMethod()
						   .AllowAnyHeader() );
			} );
			services.Configure<Settings>( settings );

			services.AddControllers().AddNewtonsoftJson();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();

			Devices		devices		= new Devices();
			MDNSClient  mDNSClient	= new MDNSClient();
			MDNSService mDNSService	= new MDNSService( settings );

			services.AddSingleton<Settings>();
			services.AddSingleton<Devices>( devices );
			services.AddSingleton<MDNSClient>( mDNSClient );
			services.AddSingleton<MDNSService>( mDNSService );

			//services.AddHostedService<DevicesHost>();

			var app = builder.Build();

			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseCors( "AllowAll" );

			// Configure the HTTP request pipeline.
			if ( app.Environment.IsDevelopment() )
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			var webSocketOptions = new WebSocketOptions
			{
				KeepAliveInterval = TimeSpan.FromSeconds( 50 )
			};

			app.UseWebSockets( webSocketOptions );

			app.MapControllers();

			app.MapFallbackToFile( "/index.html" );

			app.UseMiddleware<SHIPMiddleware>();

			foreach ( Type type in GetTypesInNamespace( typeof( Settings ).Assembly, "EEBUS.SHIP.Messages" ) )
				RuntimeHelpers.RunClassConstructor( type.TypeHandle );

			foreach ( Type type in GetTypesInNamespace( typeof( Settings ).Assembly, "EEBUS.SPINE.Commands" ) )
				RuntimeHelpers.RunClassConstructor( type.TypeHandle );

			// start our mDNS services
			mDNSClient.Run( devices );
			mDNSService.Run( devices );

			app.Run();
		}

		private static bool ValidateClientCert( X509Certificate2 certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors )
		{
			// auto accept mode is active, register flag is set in discovery service
			return true;
		}

		private static Type[] GetTypesInNamespace( Assembly assembly, string nameSpace )
		{
			return assembly.GetTypes()
							.Where( t => String.Equals( t.Namespace, nameSpace, StringComparison.Ordinal ) )
							.ToArray();
		}
	}
}
