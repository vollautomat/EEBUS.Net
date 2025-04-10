
using System;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using EEBUS.Models;

namespace EEBUS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private bool ValidateClientCert(X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // auto accept mode is active, register flag is set in discovery service
            return true;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddControllersWithViews();

            services.Configure<KestrelServerOptions>( kestrelOptions =>
            {
                kestrelOptions.ConfigureHttpsDefaults( httpOptions =>
                {
                    httpOptions.ServerCertificate           = CertificateGenerator.GenerateCert( Dns.GetHostName() );
                    httpOptions.ClientCertificateMode       = ClientCertificateMode.RequireCertificate;
                    httpOptions.ClientCertificateValidation = ValidateClientCert;
                    httpOptions.SslProtocols                = SslProtocols.Tls12;
                    httpOptions.OnAuthenticate              = (connectionContext, authenticationOptions) =>
                    {
                        authenticationOptions.EnabledSslProtocols = SslProtocols.Tls12;
                    };
                } );
            } );
			services.Configure<Settings>( Configuration.GetSection( "Settings" ) );
			
            services.AddAuthentication( CertificateAuthenticationDefaults.AuthenticationScheme ).AddCertificate( options =>
            {
                options.AllowedCertificateTypes = CertificateTypes.All;
            } );

            services.AddAuthorization();

            services.AddSingleton<Settings>();
            services.AddSingleton<MDNSClient>();
            services.AddSingleton<MDNSService>();
			services.AddSingleton<Devices>();
            //services.AddSingleton<SPINE>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IWebHostEnvironment env, MDNSClient mDNSClient, MDNSService mDNSService, Devices devices )
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints( endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            } );

            var webSocketOptions = new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromSeconds( 50 )
            };

            app.UseWebSockets( webSocketOptions );

            app.UseMiddleware<SHIPMiddleware>();

			foreach ( Type type in GetTypesInNamespace( typeof( Startup ).Assembly, "EEBUS.SHIP.Messages" ) )
			    RuntimeHelpers.RunClassConstructor( type.TypeHandle );

            foreach ( Type type in GetTypesInNamespace( typeof( Startup ).Assembly, "EEBUS.SPINE.Commands" ) )
			    RuntimeHelpers.RunClassConstructor( type.TypeHandle );

			// start our mDNS services
			mDNSClient.Run( devices );
            mDNSService.Run( devices );
        }

		private Type[] GetTypesInNamespace( Assembly assembly, string nameSpace )
		{
			return
			  assembly.GetTypes()
					  .Where( t => String.Equals( t.Namespace, nameSpace, StringComparison.Ordinal ) )
					  .ToArray();
		}
	}
	public class Settings
	{
        public DeviceSettings Device      { get; set; }
    }

    public class DeviceSettings
    {
		public string Name                { get; set; }
		public string Id                  { get; set; }
		public string Model               { get; set; }
		public string Brand               { get; set; }
		public string Type                { get; set; }
		public string Serial              { get; set; }
		public string Host                { get; set; }
		public ushort Port                { get; set; }
        public string NetworkFeatureSet   { get; set; }

        public EntitySettings[] Entities  { get; set; } = [];
	}

    public class EntitySettings
    {
		public string Type                { get; set; }
	}
}
