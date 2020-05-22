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
	}
}
