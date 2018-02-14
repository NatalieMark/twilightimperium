using System;
namespace Eksamenslæsning
{
	public class opg3nr4
	{
		public opg3nr4()
		{
		}

		public double tal = 0;
		private bool _running = true;

		public double plus(double a, double b) { return (a + b); }

		public double minus(double a, double b) { return (a - b); }

		public double times(double a, double b) { return (a * b); }

		public double divide(double a, double b) { return (a / b); }

		public void Calculator()
		{
			Console.WriteLine("Calculator");
			double o = '0';
			tal = Console.Read() - o;
			double b;

			while (_running)
			{
				var k = Console.ReadKey();


				if (ConsoleKey.Add == k.Key)
				{
					b = Console.Read() - o;
					tal = plus(tal, b);
				}

				if (ConsoleKey.Subtract == k.Key)
				{
					b = Console.Read() - o;
					tal = minus(tal, b);
				}

				if (ConsoleKey.Multiply == k.Key)
				{
					b = Console.Read() - o;
					tal = times(tal, b);
				}

				if (ConsoleKey.Divide == k.Key)
				{
					b = Console.Read() - o;
					tal = divide(tal, b);
				}

				if (ConsoleKey.Enter == k.Key)
				{
					Console.WriteLine($" = {tal}");
					tal = 0;
				}

				if (ConsoleKey.Escape == k.Key)
				{
					Console.WriteLine($"  = {tal}");
					Console.WriteLine("Bye!");
					_running = false;
				}
			}
		}
	}
}
