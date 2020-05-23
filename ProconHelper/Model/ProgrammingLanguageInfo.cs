using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class ProgrammingLanguageInfo
	{
		public string Name;
		public ProcessInfo CompilerProcessInfo;
		public ProcessInfo ExecutionProcessInfo;
		public List<string> Extensions;
	}
}
