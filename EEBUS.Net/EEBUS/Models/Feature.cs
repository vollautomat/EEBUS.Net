using EEBUS.SPINE.Commands;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EEBUS.Models
{
	public abstract class Feature
	{
		protected Feature( int index, string type, string role, Entity owner )
		{
			this.index = index;
			this.Type  = type;
			this.Role  = role;
			this.owner = owner;
		}

		public abstract class Class
		{
			public abstract Feature Create( int index, Entity owner );
		}

		static public Feature Create( int index, string type, string role, Entity owner )
		{
			if ( featureClasses.TryGetValue( type + "-" + role, out Class cls ) )
				return cls.Create( index, owner );

			return null;
		}

		static protected Dictionary<string, Class> featureClasses = new Dictionary<string, Class>();

		static protected void Register( string typeAndRole, Class cls )
		{
			featureClasses.Add( typeAndRole, cls );
		}


		private int			  index;
		public string		  Type		  { get; private set; }
		public string		  Role		  { get; private set; }
		public virtual string Description { get { return null; } }


		public List<Function> Functions	   = new();

		private Entity		  owner;

		public FeatureInformationType FeatureInformation
		{
			get
			{
				FeatureInformationType info = new();

				info.description.featureAddress.device	= this.owner.Local.Id;
				info.description.featureAddress.entity	= this.owner.Index;
				info.description.featureAddress.feature	= this.index;
				info.description.featureType			= this.Type;
				info.description.role					= this.Role;
				info.description.description			= this.Description;

				List<SupportedFunctionType> functions = new();

				foreach ( Function function in this.Functions )
					functions.Add( function.SupportedFunction );

				if ( 0 < functions.Count )
					info.description.supportedFunction = functions.ToArray();

				return info;
			}
		}
	}
}
