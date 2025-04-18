using EEBUS.SPINE.Commands;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EEBUS.Models
{
	public class Function
	{
		public Function( string name, bool read, bool write )
		{
			this.name  = name;
			this.read  = read;
			this.write = write;
		}

		private string name;
		private bool   read;
		private bool   write;

		public SupportedFunctionType SupportedFunction
		{
			get
			{
				SupportedFunctionType supportedFunction = new();

				supportedFunction.function = this.name;

				if ( this.read )
					supportedFunction.possibleOperations.read = new();

				if ( this.write )
					supportedFunction.possibleOperations.write = new { partial = new { } };

				return supportedFunction;
			}
		}
	}
}
