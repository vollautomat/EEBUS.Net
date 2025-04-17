
using EEBUS.Models;

namespace EEBUS.Controllers
{
	public class DevicesHost : IHostedService, IDisposable
	{
		public DevicesHost( Devices devices, MDNSClient mDNSClient, MDNSService mDNSService, ILogger<DevicesController> logger )
		{
			this.devices = devices;
			this.logger = logger;
		}

		public void Dispose()
		{
		}

		private Devices devices;
		private ILogger<DevicesController> logger;
		//private DevicesController rdc;

		public Task StartAsync( CancellationToken cancellationToken )
		{
			//this.rdc = new DevicesController( this.devices, this.logger );
			return Task.CompletedTask;
		}

		public Task StopAsync( CancellationToken cancellationToken )
		{
			return Task.CompletedTask;
		}
	}
}
