using ProconHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Registry
{
	static class ProgrammingLanguageRegistry
	{
		private readonly static Dictionary<string, ProgrammingLanguageInfo> registry = new Dictionary<string, ProgrammingLanguageInfo>();

		public static void Register(ProgrammingLanguageInfo language) => registry.Add(language.Name, language);

		public static ProgrammingLanguageInfo GetOrNull(string name)
		{
			if (registry.ContainsKey(name)) {
				return registry[name];
			}
			return null;
		}
	}
}
