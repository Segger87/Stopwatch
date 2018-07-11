using System;

namespace Stopwatch
{
	class Stopwatch
	{
		public bool Enabled;
		private DateTime _startTime;
		private DateTime _endTime;

		public void Start()
		{
			_startTime = DateTime.Now;
			Enabled = true;
		}

		public void Stop()
		{
			_endTime = DateTime.Now;
			Enabled = false;
		}

		public TimeSpan TimeElapsed
		{
			get
			{
				return _endTime - _startTime;		
			}
		}
	}
}
