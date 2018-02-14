using System;
namespace Eksamenslæsning
{
	public class opg3nr3
	{
		public opg3nr3()
		{
		}

		public struct Swap
		{
			public int a;
			public int b;

			public Swap(int a, int b)
			{
				this.a = a;
				this.b = b;
			}
		}

		public Swap SwapIntegers(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp; 

			return new Swap(a, b);
		}

		public void print()
		{
			Console.Write($"1: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write($"2: ");
			int b = int.Parse(Console.ReadLine());

			Console.WriteLine($"{a} {b}");
			Swap s = SwapIntegers(a, b);
			Console.ReadKey();
			Console.WriteLine($"{s.a} {s.b}");
		}
	}
}
