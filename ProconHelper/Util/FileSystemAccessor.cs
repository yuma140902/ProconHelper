using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Util
{
	public class FileSystemAccessor
	{
		public readonly string WorkingDirectory;
		private static readonly Encoding DefaultEncoding = Encoding.UTF8;

		public FileSystemAccessor(string workingDirectory) => this.WorkingDirectory = workingDirectory;

		public  FileSystemAccessor CreateSubFileSystemAccessor(string relPath)
		{
			string absPath = ToAbsolutePath(relPath);
			return new FileSystemAccessor(absPath);
		}

		public string ReadFileToEnd(string fileName)
		{
			fileName = ToAbsolutePath(fileName);

			if (!FileExists(fileName)) {
				return null;
			}

			string s;
			using(var reader = new StreamReader(fileName, DefaultEncoding)) {
				s = reader.ReadToEnd();
			}
			return s;
		}

		public void WriteFile(string fileName, string content)
		{
			fileName = ToAbsolutePath(fileName);
			CreateFileSafe(fileName);
			using (var writer = new StreamWriter(fileName, append: false, DefaultEncoding)) {
				writer.Write(content);
			}
			return;
		}

		public void CreateFileSafe(string fileName)
		{
			string dirName = Path.GetDirectoryName(fileName);
			if (!Directory.Exists(dirName)) {
				Directory.CreateDirectory(dirName);
			}
			if (!FileExists(fileName)) {
				File.Create(fileName).Dispose();
			}
		}

		public string ToAbsolutePath(string relPath) => Path.Combine(this.WorkingDirectory, relPath);

		public bool FileExists(string fileName) => File.Exists(ToAbsolutePath(fileName));

		public IEnumerable<string> EnumerateFiles(string dirName, string pattern)
		{
			dirName = ToAbsolutePath(dirName);
			return Directory.EnumerateFiles(dirName, pattern, SearchOption.TopDirectoryOnly);
		}
	}
}
