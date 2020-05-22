using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProconHelper.Model
{
	class ExecutionInfo
	{
		public long Memory;
		public string MemoryUnit = "KB";
		public double Time;
		public string TimeUnit = "ms";
		public int ExitCode = 0;

		public bool IsTerminated = false;
		public int WaitTime;
		public string WaitTimeUnit = "ms";

		public void SetMemory(long memory, string memoryUnit)
			=> (this.Memory, this.MemoryUnit) = (memory, memoryUnit);

		public void SetTime(double time, string timeUnit)
			=> (this.Time, this.TimeUnit) = (time, timeUnit);

		public void SetTerminated(int waitTime, string waitTimeUnit)
		{
			this.IsTerminated = true;
			(this.WaitTime, this.WaitTimeUnit) = (waitTime, waitTimeUnit);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			if (!this.IsTerminated) {
				sb.AppendLine($"Memory: {this.Memory}{this.MemoryUnit}");
				sb.AppendLine($"Time: {this.Time}{this.TimeUnit}");
				sb.AppendLine($"Return: {this.ExitCode}");
			}
			else {
				sb.AppendLine($"Time: >= {this.WaitTime}{this.WaitTimeUnit}");
				sb.AppendLine("Proccess Terminated");
			}
			return sb.ToString();
		}
	}
}
