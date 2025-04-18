namespace EEBUS.Models
{
	public abstract class DataStructure
	{
		public DataStructure( string type )
		{
			Type = type;
		}

		protected string Type { get; private set; }
	}
}
