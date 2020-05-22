using ProconHelper.Forms;
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

		public static ExecutionInfo RunProgram(string srcPath, string stdin, ProcessInfo executionProcessInfo)
		{
			var embedObjs = new EmbedmentObjectDictionary<string>();
			embedObjs.UpdateObject("srcPath", srcPath);

			int terminateMs = 5000;
			var execInfo = new ExecutionInfo();

			var proc = new Process
			{
				StartInfo = executionProcessInfo.CreateProcessStartInfo(embedObjs)
			};

			proc.Start();

			proc.StandardInput.Write(stdin);
			proc.StandardInput.Flush();

			try {
				execInfo.SetMemory(proc.PrivateMemorySize64 / 1024, "KB");
			}
			catch (InvalidOperationException) {
				execInfo.SetMemoryNoData();
			}

			proc.WaitForExit(terminateMs);

			if (proc.HasExited) {
				execInfo.SetTime(proc.UserProcessorTime.TotalMilliseconds, "ms");
				execInfo.ExitCode = proc.ExitCode;

				execInfo.stdout = proc.StandardOutput.ReadToEnd();
				execInfo.stderr = proc.StandardError.ReadToEnd();

				proc.Close();
			}
			else {
				if (!proc.CloseMainWindow()) proc.Kill();
				execInfo.SetTerminated(terminateMs, "ms");
			}

			return execInfo;
		}
	}
}
