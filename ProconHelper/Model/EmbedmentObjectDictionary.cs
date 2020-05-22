using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class EmbedmentObjectDictionary<T>
	{
		public readonly Dictionary<string, T> Objects = new Dictionary<string, T>();

		public void UpdateObject(string key, T value)
		{
			if (Objects.ContainsKey(key)) Objects[key] = value;
			else Objects.Add(key, value);
		}
	}
}
