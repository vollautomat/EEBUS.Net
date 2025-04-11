using System.Collections.Generic;

namespace EEBUS.Models
{
	public class Entity
	{
		public Entity()
		{
		}

		public string Type { get; set; }

		public List<Entity>  Entities = new();
		public List<Feature> Features = new();
		public List<UseCase> UseCases = new();
	}
}
