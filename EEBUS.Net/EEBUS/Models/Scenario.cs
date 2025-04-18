using System.Collections.Generic;

namespace EEBUS.Models
{
	public class Scenario
	{
		public Scenario( uint index, bool manditory, string name )
		{
			this.Index	   = index;
			this.Manditory = manditory;
			this.Name	   = name;
		}

		public uint				   Index		  { get; set; }
		public bool				   Manditory	  { get; set; }
		public string			   Name			  { get; set; }

		public List<DataStructure> DataStructures = new();
	}
}
