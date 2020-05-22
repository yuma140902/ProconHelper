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

		public static void RunProgram(string srcPath, TextBox stdInBox, TextBox stdOutBox, StandardErrorOutputView stdErrView, TextBox runInfoBox, ProcessInfo executionProcessInfo)
		{
			var embedObjs = new EmbedmentObjectDictionary<string>();
			embedObjs.UpdateObject("srcPath", srcPath);

			string stdout = "";
			string stderr = "";
			int terminateMs = 5000;
			var executionInfo = new ExecutionInfo();

			var proc = new Process
			{
				StartInfo = executionProcessInfo.CreateProcessStartInfo(embedObjs)
			};

			proc.Start();

			proc.StandardInput.Write(stdInBox.Text + Environment.NewLine);
			proc.StandardInput.Flush();

			try {
				executionInfo.SetMemory(proc.PrivateMemorySize64 / 1024, "KB");
			}
			catch (InvalidOperationException) {
				executionInfo.SetMemory(-1, " (No data)");
			}

			proc.WaitForExit(terminateMs);

			if (proc.HasExited) {
				executionInfo.SetTime(proc.UserProcessorTime.TotalMilliseconds, "ms");
				executionInfo.ExitCode = proc.ExitCode;

				stdout = proc.StandardOutput.ReadToEnd();
				stderr = proc.StandardError.ReadToEnd();

				proc.Close();
			}
			else {
				if (!proc.CloseMainWindow()) proc.Kill();
				executionInfo.SetTerminated(terminateMs, "ms");
			}

			stdOutBox.Text = stdout;
			stdErrView.SetStdError(stderr);
			runInfoBox.Text = executionInfo.ToString();
		}
	}
}
