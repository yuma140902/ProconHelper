using ProconHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProconHelper
{
	class ProgrammingLanguageLoader
	{
		private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
		{
			ReadCommentHandling = JsonCommentHandling.Skip,
			AllowTrailingCommas = true,
			PropertyNameCaseInsensitive = true
		};

		static ProgrammingLanguageLoader()
		{
			options.Converters.Add(new JsonStringEnumConverter());
		}

		public static ProgrammingLanguageInfo LoadFromJson(string json)
			=> JsonSerializer.Deserialize<ProgrammingLanguageInfo>(json, options);
	}
}
