using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Util
{
	public static class StringUtils
	{
		public static string ReplaceN2RN(this string str) => str.Replace("\n", "\r\n");
	}
}
