using EEBUS.SPINE.Commands;
using System.Collections.Generic;
using Tmds.Linux;

namespace EEBUS.Models
{
	public abstract class Entity
	{
		protected Entity( int index, LocalDevice local, EntitySettings entitySettings )
		{
			this.index = index;
			this.local = local;
			this.Type  = entitySettings.Type;

			foreach ( UseCaseSettings usecaseSettings in entitySettings.UseCases )
			{
				UseCases.Add( UseCase.Create( usecaseSettings, this ) );
			}
		}

		public abstract class Class
		{
			public abstract Entity Create( int index, LocalDevice local, EntitySettings entitySettings );
		}

		static public Entity Create( int index, LocalDevice local, EntitySettings entitySettings )
		{
			if ( entityClasses.TryGetValue( entitySettings.Type, out Class cls ) )
				return cls.Create( index, local, entitySettings );

			return null;
		}

		static protected Dictionary<string, Class> entityClasses = new Dictionary<string, Class>();

		static protected void Register( string name, Class cls )
		{
			entityClasses.Add( name, cls );
		}


		private int			 index		{ get; }

		public string		 Type		{ get; }

		public List<Entity>  Entities = new();
		public List<Feature> Features = new();
		public List<UseCase> UseCases = new();

		private LocalDevice  local;
		private Entity		 owner;

		public int[] Index
		{
			get
			{
				if ( null == this.owner )
				{
					return new int[1] { this.index }; 
				}
				else
				{
					List<int> indices = this.owner.Index.ToList();
					indices.Add( this.index );
					return indices.ToArray();
				}
			}
		}

		public LocalDevice Local
		{
			get
			{
				return this.local;
			}
		}

		public List<UseCaseInformationType> UseCaseInformations
		{
			get
			{
				List<string> actors = new();
				foreach ( var useCase in this.UseCases )
					if ( -1 == actors.IndexOf( useCase.Actor ) )
						actors.Add( useCase.Actor );

				List<UseCaseInformationType> infos = new();

				foreach ( string actor in actors )
				{
					UseCaseInformationType info = new();

					info.address.device	= this.Local.Id;
					info.address.entity	= this.Index;
					info.actor			= actor;

					List<UseCaseSupportType> supports = new();

					foreach ( var useCase in this.UseCases )
						if ( useCase.Actor == actor )
							supports.Add( useCase.Information );

					info.useCaseSupport = supports.ToArray();

					infos.Add( info );
				}

				return infos;
			}
		}
	}
}
