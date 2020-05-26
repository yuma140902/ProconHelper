using ProconHelper.Model;
using ProconHelper.Registry;
using ProconHelper.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	static class Program
	{
		public static readonly FileSystemAccessor FileSystem = new FileSystemAccessor(".");

		public static readonly ApplicationSetting Setting = new ApplicationSetting();

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			foreach(var jsonFile in FileSystem.EnumerateFiles(References.ProgrammingLanguagesFolderName, "*.json")) {
				var json = FileSystem.ReadFileToEnd(jsonFile);
				var language = ProgrammingLanguageLoader.LoadFromJson(json);
				ProgrammingLanguageRegistry.Register(language);
			}
			Setting.ProgrammingLanguage = ProgrammingLanguageRegistry.GetOrNull("C++ 14 with Boost (g++)");
			if(Setting.ProgrammingLanguage == null) {
				MessageBox.Show("必要なファイルが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
