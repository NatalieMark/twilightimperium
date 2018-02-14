using System;
namespace Eksamenslæsning
{
	public class Run6
	{
		public Run6()
		{
		}
		public void run()
		{
			Swap();
		}

		public void Swap()
		{
			/*
			Console.WriteLine("Give me an integer:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Give me another integer:");
			int b = int.Parse(Console.ReadLine());
			*/
			int a = 1;
			int b = 2;

			opg6Pair<int> intPair = new opg6Pair<int>(a, b);
			Console.WriteLine($"Before swapping: {intPair.first} {intPair.second}");
			intPair = intPair.Swap();
			Console.WriteLine($"After swapping: {intPair.first} {intPair.second}");
		}
	}
}
