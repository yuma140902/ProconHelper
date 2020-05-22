using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Util
{
	static class TimeUtil
	{
		public static string Now(string format) => DateTime.Now.ToString(format);

		public static string NowDateTimeSecFile() => Now("yyyy-MM-dd_HHmmss");
	}
}
