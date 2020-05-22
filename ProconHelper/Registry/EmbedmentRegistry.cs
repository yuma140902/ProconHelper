using ProconHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Registry
{
	static class EmbedmentRegistry
	{
		private static readonly List<Embedment> embedments = new List<Embedment>()
		{
			new Embedment("srcPath", "ソースファイルのフルパス")
		};

		private static readonly Dictionary<string, object> objects = new Dictionary<string, object>();
		

		public static void Register(Embedment embedment) => embedments.Add(embedment);

		public static void Remove(Embedment embedment) => embedments.Remove(embedment);

		public static Embedment GetOrNull(string target)
		{
			foreach(var embedment in embedments) {
				if (embedment.Target == target) return embedment;
			}
			return null;
		}

		public static void UpdateObject(string target, object obj)
		{
			if (objects.ContainsKey(target)) objects[target] = obj;
			else objects.Add(target, obj);
		}

		public static IEnumerator<Embedment> Enumerate() => embedments.GetEnumerator();

		public static Dictionary<string, object> Objects() => objects;

	}
}
