using System;

namespace Stopwatch
{
	class Stopwatch
	{
		public bool Enabled;
		public DateTime StartTime;
		public DateTime EndTime;

		public void Start()
		{
			StartTime = DateTime.Now;
			Enabled = true;
		}

		public void Stop()
		{
			EndTime = DateTime.Now;
			Enabled = false;
		}

		public TimeSpan TimeElapsed
		{
			get
			{
				var totalTime = StartTime - EndTime;
				return totalTime;
			}
		}
	}
}
