using EEBUS.SPINE.Commands;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EEBUS.Models
{
	public class LocalDevice : Device
	{
		public LocalDevice( byte[] ski, Settings settings )
			: base( settings.Device.Id, ski )
		{			
			this.Name			   = settings.Device.Name;
			this.Brand			   = settings.Device.Brand;
			this.Type			   = settings.Device.Type;
			this.Model			   = settings.Device.Model;
			this.Serial			   = settings.Device.Serial;
			this.NetworkFeatureSet = settings.Device.NetworkFeatureSet;

			int index = 0;
			foreach ( EntitySettings entitySettings in settings.Device.Entities )
			{
				this.Entities.Add( Entity.Create( index++, this, entitySettings ) );
			}
		}

		public string Brand				{ get; private set; }

		public string Type				{ get; private set; }

		public string Model				{ get; private set; }

		public string Serial			{ get; private set; }

		public string NetworkFeatureSet { get; private set; }

		public string ShipID
		{
			get
			{
				return "SHIP;SKI:" + this.SKI.ToString() + ",ID:" + this.Name + ";BRAND:" + this.Brand
					+ ";TYPE:" + this.Type + ";MODEL:" + this.Model + ";SERIAL:" + this.Serial + ";CAT:1;ENDSHIP;";
			}
		}

		public DeviceInformationType DeviceInformation
		{
			get
			{
				DeviceInformationType info = new();

				info.description.deviceAddress.device = this.Id;
				info.description.deviceType			  = this.Type;
				info.description.networkFeatureSet	  = this.NetworkFeatureSet;

				return info;
			}
		}

		public EntityInformationType[] EntityInformations
		{
			get
			{
				List<EntityInformationType> infos = new();

				int index = 0;
				foreach ( Entity entity in this.Entities )
				{
					EntityInformationType info = new();

					info.description.entityAddress.device = this.Id;
					info.description.entityAddress.entity = [index++];
					info.description.entityType			  = entity.Type;

					infos.Add( info );
				}

				return infos.ToArray();
			}
		}
	}
}
