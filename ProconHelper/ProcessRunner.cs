using ProconHelper.Model;
using ProconHelper.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	static class ProcessRunner
	{
		public static bool RunCompiler(string srcPath, TextBox compilerOutputBox, ProcessInfo compilerProcessInfo)
		{
			var embedObjs = new EmbedmentObjectDictionary<string>();
			embedObjs.UpdateObject("srcPath", srcPath);

			var proc = new Process
			{
				StartInfo = compilerProcessInfo.CreateProcessStartInfo(embedObjs)
			};
			proc.Start();

			//string stdout = proc.StandardOutput.ReadToEnd();
			string stderr = proc.StandardError.ReadToEnd();

			proc.WaitForExit();
			proc.Close();

			compilerOutputBox.UpdateTextAndScrollToEnd(stderr.ReplaceN2RN());

			return string.IsNullOrWhiteSpace(stderr);
		}
	}
}
