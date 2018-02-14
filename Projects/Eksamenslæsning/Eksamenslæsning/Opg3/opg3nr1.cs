using System;
namespace Eksamenslæsning
{
	public class opg3nr1
	{
		public opg3nr1()
		{ 
		}

		private bool _running;

		public void ConvertTryParse()
		{
			_running = true;
			int intNumber;
			string stringNumber;
			bool result;

			Console.WriteLine("Hello! Please type in a number down below:");

			while (_running)
			{
				stringNumber = Console.ReadLine();

				result = int.TryParse(stringNumber, out intNumber);

				Console.WriteLine(result);
				Console.WriteLine();
				Console.WriteLine("If you want to end, press Escape\n" +
				                  "Else press any key and again:");

				var e = Console.ReadKey();
				if (ConsoleKey.Escape == e.Key)
				{
					_running = false;
					Console.WriteLine(" Goodbye");
				}
				else
					Console.WriteLine("Please type in a number down below:");
			}
		}

		public void ConvertParse()
		{
			_running = true;

			Console.WriteLine("Hello! Please type in a number down below:");

			while (_running)
			{
				try
				{
					int intNumber = int.Parse(Console.ReadLine());
				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
				catch (OverflowException e)
				{
					Console.WriteLine(e.Message);
				}

				Console.WriteLine("If you want to end, press Escape\n" +
				                  "Else press any key and again:");

				var k = Console.ReadKey();
				if (ConsoleKey.Escape == k.Key)
				{
					_running = false;
					Console.WriteLine(" Goodbye");
				}
				else
					Console.WriteLine("Please type in a number down below:");
			}
		}

		public void ConvertHexi()
		{ 
			_running = true;
			int intValue;
			string hexValue;

			Console.WriteLine("Hello! Please type in a number down below:");

			while (_running)
			{
				try
				{
					intValue = int.Parse(Console.ReadLine());
					hexValue = intValue.ToString("X");
					Console.WriteLine(hexValue);
				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
				catch (OverflowException e)
				{
					Console.WriteLine(e.Message);
				}

				Console.WriteLine("If you want to end, press Escape\n" +
								  "Else press any key and again:");

				var k = Console.ReadKey();
				if (ConsoleKey.Escape == k.Key)
				{
					_running = false;
					Console.WriteLine(" Goodbye");
				}
				else
					Console.WriteLine("Please type in a number down below:");
			}
		}
	}
}
