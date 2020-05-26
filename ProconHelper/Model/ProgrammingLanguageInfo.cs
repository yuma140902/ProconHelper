using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class ProgrammingLanguageInfo
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("compiler")]
		public ProcessInfo CompilerProcessInfo { get; set; }

		[JsonPropertyName("execution")]
		public ProcessInfo ExecutionProcessInfo { get; set; }

		[JsonPropertyName("extensions")]
		public List<string> Extensions { get; set; }
	}
}
