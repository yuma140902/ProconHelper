using ProconHelper.Registry;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class EmbedableString
	{
		public EmbedableString(string image) => this.Image = image;

		public readonly string Image;

		public string Embed<T>(EmbedmentObjectDictionary<T> dictionary)
		{
			string image = Image;
			foreach(var value in dictionary.Objects) {
				string target = value.Key;
				object obj = value.Value;
				image = image.Replace("{" + target + "}", obj.ToString());
			}
			return image;
		}

		public override string ToString() => Image;
	}
}
