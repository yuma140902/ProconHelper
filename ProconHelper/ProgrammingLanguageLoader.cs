using ProconHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProconHelper
{
	class ProgrammingLanguageLoader
	{
		public static IEnumerable<ProgrammingLanguageInfo> LoadFromJson(string json)
			=> JsonSerializer.Deserialize<List<ProgrammingLanguageInfo>>(json);
	}
}
