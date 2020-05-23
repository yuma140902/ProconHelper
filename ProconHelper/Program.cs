using ProconHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	static class Program
	{
		public static readonly ApplicationSetting Setting = new ApplicationSetting()
		{
			ProgrammingLanguage = new ProgrammingLanguageInfo()
			{
				Name = "C++ 14 with Boost (g++)",
				CompilerProcessInfo = new ProcessInfo(new EmbedableString("g++ -std=gnu++14 -O2 -I/opt/boost/gcc/include -L/opt/boost/gcc/lib -o a.exe {srcPath}"), RunMode.InCommandLine),
				ExecutionProcessInfo = new ProcessInfo(new EmbedableString("a.exe"), RunMode.AsOneProcess),
				Extensions = new List<string>() { ".cpp" }
			}
		};

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
