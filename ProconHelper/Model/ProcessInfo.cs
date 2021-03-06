﻿using ProconHelper.Registry;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class ProcessInfo
	{
		public ProcessInfo() { }

		public ProcessInfo(EmbedableString commandAndArguments, RunMode runMode)
		{
			this.CommandAndArgs = commandAndArguments;
			this.RunMode = runMode;
		}

		public EmbedableString Command;
		public EmbedableString Arguments;

		[JsonPropertyName("mode")]
		public RunMode RunMode { get; set; }

		[JsonPropertyName("command")]
		public string CommandAndArgsForJson {
			get => this.CommandAndArgs.Image;
			set => this.CommandAndArgs = new EmbedableString(value);
		}

		[JsonIgnore]
		public EmbedableString CommandAndArgs {
			get => string.IsNullOrWhiteSpace(Arguments?.ToString()) ? Command : new EmbedableString($"{Command} {Arguments}");
			set {
				string[] cmdAndArg = value.ToString().Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
				if (cmdAndArg.Length >= 1) Command = new EmbedableString(cmdAndArg[0]);
				if (cmdAndArg.Length >= 2) Arguments = new EmbedableString(cmdAndArg[1]);
			}
		}

		public ProcessStartInfo CreateProcessStartInfo<T>(EmbedmentObjectDictionary<T> dictionary)
		{
			var info = new ProcessStartInfo();

			info.UseShellExecute = false;
			info.RedirectStandardOutput = true;
			info.RedirectStandardInput = true;
			info.RedirectStandardError = true;
			info.CreateNoWindow = true;

			if (this.RunMode == RunMode.InCommandLine) {
				// cmd.exe のパスを取得
				info.FileName = System.Environment.GetEnvironmentVariable("ComSpec");

				string command = CommandAndArgs?.Embed(dictionary);
				info.Arguments = $@"/c ""{command}""";
			}
			else {
				info.FileName = Command?.Embed(dictionary);
				info.Arguments = Arguments?.Embed(dictionary);
			}

			return info;
		}
	}
}
