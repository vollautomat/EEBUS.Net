using System.Collections.Generic;

namespace EEBUS.Models
{
	public class UseCase
	{
		public UseCase()
		{
		}

		public string Type { get; set; }

		public List<Scenario> scenarios = new();
	}
}
