using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper.Util
{
	public static class UIUtils
	{
		public static void UpdateTextAndScrollToEnd(this TextBox textBox, string text)
		{
			textBox.Text = text;
			textBox.Select(textBox.TextLength, 0);
			textBox.ScrollToCaret();
		}

		public static string FilePickFilterWithAllFile(string type, IEnumerable<string> extensions)
		{
			var sb = new StringBuilder();
			foreach (string extension in extensions) {
				sb.Append($"{type}ファイル|*{extension}|");
			}
			sb.Append("すべてのファイル|*.*");
			return sb.ToString();
		}
	}
}
