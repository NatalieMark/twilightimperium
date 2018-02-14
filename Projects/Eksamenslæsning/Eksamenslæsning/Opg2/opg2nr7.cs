using System;
using System.Collections.Generic;

namespace Eksamenslæsning
{
	public class opg2nr7
	{
		public opg2nr7()
		{
		}

		public void Vector()
		{
			int size;
			int i = 0;

			Console.WriteLine("How big of vector should i make?");
			size = int.Parse(Console.ReadLine());

			List<int> vector = new List<int>();

			while (i < size)
			{
				Console.Write($"{i + 1}: ");;
				vector.Add(int.Parse(Console.ReadLine()));
				i++;
			}
		}
	}
}
