using System;

namespace Stopwatch
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = new Program();
			p.Execute();
		}

		private void Execute()
		{
			Console.WriteLine("Please type start to begin the stop watch and stop when you are finished.");
			var initSw = Console.ReadLine().ToLower();
			var sw = new Stopwatch();

			switch (initSw)
			{
				case "start":
					sw.Start();
					Console.WriteLine("Timer has started");
					break;
				default:
					Console.WriteLine("Sorry that is not a recognised command");
					Execute();
					break;
			}


			if (sw.Enabled)
			{
				Console.WriteLine("Please type stop when you are finished.");
				var stopSw = Console.ReadLine().ToLower();

				switch (stopSw)
				{
					case "start":
						throw new InvalidOperationException("Stopwatch is already running");
					case "stop":
						sw.Stop();
						var elapsedTime = sw.TimeElapsed;
						Console.WriteLine($"The total time elapsed is {elapsedTime}");
						Execute();
						break;
					default:
						Console.WriteLine("Sorry that is not a recognised command");
						break;
				}
			}
		}
	}
}
