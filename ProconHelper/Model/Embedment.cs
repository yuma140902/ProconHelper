using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class Embedment
	{
		public Embedment(string target, string description)
		{
			this.Target = target;
			this.Description = description;
		}

		public readonly string Target;
		public readonly string Description;
	}
}
