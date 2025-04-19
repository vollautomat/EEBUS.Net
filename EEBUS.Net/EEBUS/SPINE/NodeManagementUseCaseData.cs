﻿
using EEBUS.Messages;
using EEBUS.Models;

namespace EEBUS.SPINE.Commands
{
	public class NodeManagementUseCaseData : SpineCmdPayload<CmdNodeManagementUseCaseDataType>
	{
		static NodeManagementUseCaseData()
		{
			Register( "nodeManagementUseCaseData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdNodeManagementUseCaseDataType>.Class
		{
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				NodeManagementUseCaseData	  payload = new NodeManagementUseCaseData();
				NodeManagementUseCaseDataType data	  = payload.cmd[0].nodeManagementUseCaseData;

				List<UseCaseInformationType> infos = new();

				foreach ( Entity entity in connection.Local.Entities )
					infos.AddRange( entity.UseCaseInformations );

				data.useCaseInformation = infos.ToArray();

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdNodeManagementUseCaseDataType : CmdType
	{
		public NodeManagementUseCaseDataType nodeManagementUseCaseData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class NodeManagementUseCaseDataType
	{
		public UseCaseInformationType[] useCaseInformation { get; set; } = [new()];
	}

	[System.SerializableAttribute()]
	public class UseCaseInformationType
	{
		public AddressType			address		   { get; set; } = new();

		public string				actor		   { get; set; }

		public UseCaseSupportType[]	useCaseSupport { get; set; } = [new()];
	}

	[System.SerializableAttribute()]
	public class UseCaseSupportType
	{
		public string useCaseName				 { get; set; }

		public string useCaseVersion			 { get; set; }

		public bool	  useCaseAvailable			 { get; set; }

		public uint[] scenarioSupport			 { get; set; }

		public string useCaseDocumentSubRevision { get; set; }
	}
}
