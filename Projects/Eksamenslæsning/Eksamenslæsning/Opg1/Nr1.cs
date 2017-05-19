using System;
using System.Collections.Generic;

namespace Eksamenslæsning
{
	public class nr1
	{
		public nr1()
		{
		}

		public void opg2()
		{
			/*
			char a = "a";
			bool b = 0;
			int c = 8.0;
			decimal d = 6.7;
			string e = "Har du set "Holger"?";
			*/

			char a = 'a';
			bool b = true;
			int c = 8;
			double d = 6.7;
			string e = "Har du set Holger?";

			Console.WriteLine($"Opg2:\n{a}\n{b}\n{c}\n{d}\n{e}");
		}

		public void opg3()
		{
			// Determine the color
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();

			// ------------------------------------------

			// Variables used in opg3
			string firstName = null;
			string lastName = null;

			Random r = new Random();
			int randomNumber = r.Next(1, 10);
			int inputNumber;

			// ------------------------------------------

			// Asking for first- and lastname
			Console.WriteLine($"Hello! And you are?");
			Console.Write($"First name: ");
			firstName = Console.ReadLine();
			Console.Write($"Last name: ");
			lastName = Console.ReadLine();

			// Clearing the terminal
			Console.Clear();

			// Greeting the given name
			Console.WriteLine($"Hello {firstName} {lastName}");

			// Guess a number
			Console.WriteLine($"Guess a number I generated from 1 - 10");
			inputNumber = Int32.Parse(Console.ReadLine());
			Console.WriteLine("hi");

			if (inputNumber == randomNumber)
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.Clear();
				Console.WriteLine($"Congratulations! You guessed correct!");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Clear();
				Console.WriteLine($"Sorry, the generated number was {randomNumber}");
			}

			/*
			while (inputNumber < 1 && inputNumber > 11)
			{
				Console.WriteLine($"Input number out of range, try again");
				Console.WriteLine($"Guess a number I generated from 1 - 10");
				inputNumber = Int32.Parse(Console.ReadLine());
			}


			if (inputNumber > 0 && inputNumber < 11)
			{
				if (inputNumber == randomNumber)
				{
					Console.WriteLine($"Congratulations! You guessed right!");
				}
				else
					Console.WriteLine($"Sorry, the generated number was {randomNumber}");
			}
			*/
		}

		public void opg4()
		{
			Console.WriteLine("Write a number and press 'Enter'");
			try
			{
				int tal = int.Parse(Console.ReadLine());
				Console.WriteLine($"The square root of {tal} if {Math.Sqrt(tal)}");
			}
			catch (FormatException e)
			{
				Console.WriteLine($"{e}");
			}


		}

		public void opg5()
		{
			int[] array = { 12, 15, 35, 1, 62, 31, 8 };
			List<int> lotto = new List<int>() { 12, 15, 35, 1, 62, 31, 8 };

			for (int i = 0; i < array.Length; i++)
			{
				if (i < array.Length - 1)
					Console.Write($"{array[i]}, ");
				if (i == array.Length - 1)
					Console.Write($"{array[i]}");
			}

			Console.WriteLine();

			for (int i = 0; i < lotto.Count; i++)
			{
				if (i < lotto.Count - 1)
					Console.Write($"{lotto[i]}, ");
				if (i == lotto.Count - 1)
					Console.Write($"{lotto[i]}");
			}
		}

		public void opg6()
		{
			// Graderne på en cirkel
			double a = 167;
			double b = 24;
			double c = 345;

			// Radian til en cirkel
			double x = 0.4;
			double y = 1.0;
			double z = 1.8;

			// Grader til radianer
			double radian_a = a * (Math.PI / 180);
			double radian_b = b * (Math.PI / 180);
			double radian_c = c * (Math.PI / 180);

			// Radianer til grader
			double grade_x = x * (180 / Math.PI);
			double grade_y = y * (180 / Math.PI);
			double grade_z = z * (180 / Math.PI);

			// Printing
			Console.WriteLine($"{radian_a}");
			Console.WriteLine($"{radian_b}");
			Console.WriteLine($"{radian_c}");
			Console.WriteLine($"{grade_x}");
			Console.WriteLine($"{grade_y}");
			Console.WriteLine($"{grade_z}");
		}

		public void opg7()
		{
			int numberOfMembers = 0;
			List<string> ListNamesOfMembers = new List<string>();

			Console.WriteLine($"How many members does your group consist of?");
			numberOfMembers = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Write their names, one after one.\n" +
							  "After writing ones name, please push the 'Enter' button");

			for (int i = 0; i < numberOfMembers; i++)
			{
				ListNamesOfMembers.Add(Console.ReadLine());
			}

			ListNamesOfMembers.Sort();

			Console.WriteLine("\nSorted: ");
			for (int i = 0; i < numberOfMembers; i++)
			{
				Console.WriteLine($"{ListNamesOfMembers[i]}");
			}
		}

		public void opg8()
		{
			int number = 0;
			char star = '*';

			Console.Write("Write an integer: ");
			number = Int32.Parse(Console.ReadLine());

			for (int i = 0; i < number; i++)
			{
				for (int k = 0; k < i + 1; k++)
					Console.Write($"{star}");

				for (int j = 0; j < i; j++)
					Console.Write(" ");

				Console.WriteLine();
			}

			for (int i = number; i > 0; i--)
			{
				for (int k = i; k > 0; k--)
					Console.Write($"{star}");

				for (int j = i; j > 0; j--)
					Console.Write(" ");

				Console.WriteLine();
			}
		}

		public void opg9()
		{
			int number = 0;
			char star = '*';

			Console.Write("Write an integer: ");
			number = Int32.Parse(Console.ReadLine());

			for (int i = number; i > 0; i--)
			{
				for (int k = i; k > 0; k--)
					Console.Write($"{star}");

				for (int j = i; j > 0; j--)
					Console.Write(" ");

				Console.WriteLine();
			}
		}
	}
}
