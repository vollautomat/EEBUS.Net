
using Makaretu.Dns;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace EEBUS
{
	public class MDNSService
	{
		private ServiceProfile serviceProfile = new EEBusServiceProfile(Dns.GetHostName(), "Demo-CSharp-987654321", "_ship._tcp", 50000);
		private X509Certificate2 cert;
        private string localSKI;

		public void AddProperty(string key, string value)
        {
            serviceProfile.AddProperty(key, value);
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
            _ = Task.Run(async() =>
            {
                Thread.CurrentThread.IsBackground = true;

                MulticastService mdns = new MulticastService();
                ServiceDiscovery sd = new ServiceDiscovery(mdns);

				cert = CertificateGenerator.GenerateCert(Dns.GetHostName());

				byte[] hash = SHA1.Create().ComputeHash(cert.GetPublicKey());
				string localSKI = this.localSKI = Convert.ToHexString(hash);
				// add spaces every 4 hex digits (EEBUS requirement)
				for (int i = 4; i < this.localSKI.Length; i += 4)
					this.localSKI = this.localSKI.Insert(i++, " ");

				// configure our EEBUS mDNS properties
				AddProperty("name",     "C# EEBUS Demo");
				AddProperty("id",       "ID:Demo-CSharp-987654321;");
				AddProperty("path",     "/ship/");
				AddProperty("register", "true");
				AddProperty("ski",      localSKI);
				AddProperty("brand",    "vollautomat");
				AddProperty("type",     "demo");
				AddProperty("model",    "C# Tester");
				AddProperty("serial",   "987654321");
				AddProperty("host",     "10.211.55.28");

				try
				{
                    mdns.Start();

                    sd.Advertise(serviceProfile);

                    await Task.Delay(-1).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sd.Dispose();
                    mdns.Stop();
                }
            });
        }
    }
}
