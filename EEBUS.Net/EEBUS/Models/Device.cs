namespace EEBUS.Models
{
	public class Device
	{
		public Device( string id, byte[] ski )
		{
			this.Id  = id;
			this.SKI = new SKI( ski );
		}

		public Device( string id, string ski )
		{
			this.Id  = id;
			this.SKI = new SKI( ski );
		}

		public string			   Id			  { get; private set; }
								 
		public string			   Name			  { get; set; }
								 
		public SKI				   SKI			  { get; set; }
								 
		public string			   Error		  { get; set; }
								 
								 
		public List<Entity>		   Entities		  = new();
		public List<DataStructure> DataStructures = new();
		public List<KeyValue>	   KeyValues	  = new();


		public override bool Equals( object obj )
		{
			if ( (obj == null) || ! GetType().Equals( obj.GetType() ) )
				return false;

			Device org = (Device) obj;
			return this.SKI == org.SKI;
		}

		public override int GetHashCode()
		{
			return this.SKI.GetHashCode();
		}

		public int GetId( KeyValue keyValue )
		{
			return this.KeyValues.IndexOf( keyValue );
		}

		public void Add( DataStructure dataStructure )
		{
			dataStructure.Id = (uint) this.DataStructures.Count;
			this.DataStructures.Add( dataStructure );
		}

		public List<T> GetDataStructures<T>() where T : DataStructure
		{
			List<T> datas = new();

			foreach ( var data in this.DataStructures )
				if ( data is T )
					datas.Add( data as T );

			return datas;
		}

		public T GetDataStructure<T>( uint id ) where T : DataStructure
		{
			foreach ( var data in this.DataStructures )
				if ( data is T && data.Id == id )
					return data as T;

			return null;
		}

		public void Add( KeyValue keyValue )
		{
			this.KeyValues.Add( keyValue );
		}

		public void AddUnique( KeyValue keyValue )
		{
			if ( ! this.KeyValues.Any( kv => kv.KeyName == keyValue.KeyName ) )
				this.KeyValues.Add( keyValue );
		}
	}
}
