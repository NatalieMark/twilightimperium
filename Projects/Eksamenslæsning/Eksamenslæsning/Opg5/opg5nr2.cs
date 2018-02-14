using System;
using System.Collections.Generic;
using System.Linq;

namespace Eksamenslæsning
{
	public class opg5nr2
	{
		public opg5nr2()
		{
		}

		bool _runSort = false;
		bool _runPrint = false;
		List<string> customList = new List<string>();
		string listName = null;

		public void Program()
		{
			Choice();
			var choice = Console.ReadKey();
			Console.Clear();

			if (choice.Key == ConsoleKey.P)
			{
				_runPrint = true;
				PrintList();
			}
			else if (choice.Key == ConsoleKey.A)
			{
				_runSort = true;
				MakeList();
			}
			else if (choice.Key == ConsoleKey.D)
			{
				customList.Clear();
				Program();
			}
			else if (choice.Key == ConsoleKey.Escape)
			{
				_runSort = false;
				_runPrint = false;
			}
			else if (choice.Key != ConsoleKey.P || 
			         choice.Key != ConsoleKey.A || 
			         choice.Key != ConsoleKey.D || 
			         choice.Key != ConsoleKey.Escape)
				Program();
		}


		public void MakeList()
		{
			Console.Clear();
			Console.WriteLine($"Add an item to the list of {listName}: ");

			while (_runSort)
			{
				customList.Add(Console.ReadLine());
				Console.Clear();

				Choice1();
				var answer = Console.ReadKey();
				Console.Clear();

				if (answer.Key == ConsoleKey.N)
				{
					_runSort = false;
					Program();
				}
				else if (answer.Key == ConsoleKey.Y || answer.Key == ConsoleKey.Enter)
				{
					Console.WriteLine($"Add another {listName}");
				}
				else
				{
					Console.WriteLine("I'll take that as 'yes'");
					Console.WriteLine($"Add another {listName}");
				}
			}
		}

		public void PrintList()
		{
			Choice2();
			var answer = Console.ReadKey();
			Console.Clear();

			while (_runPrint)
			{
				if (answer.Key == ConsoleKey.P)
				{
					Printing();
					Console.WriteLine("\nPress Enter to go back");
					Console.ReadLine();
					PrintList();
				}
				else if (answer.Key == ConsoleKey.B)
					Program();
				else if (answer.Key == ConsoleKey.S)
				{
					customList.Sort();
					Printing();
					Console.WriteLine("Press Enter to go back");
					Console.ReadLine();
					PrintList();
				}
				else if (answer.Key != ConsoleKey.B || answer.Key != ConsoleKey.S)
					Choice2();
			}
		}

		public void Printing()
		{
			foreach (string item in customList)
			{
				Console.WriteLine(item.First().ToString().ToUpper() + item.Substring(1));
			}
		}

		public void Choice()
		{
			Console.Clear();

			if (customList.Count == 0)
			{
				Console.WriteLine("Hello! Now you are going to make your own custommade list!\n" +
								  "What do you want to make a list about?\n");
				listName = Console.ReadLine();
				_runSort = true;
				MakeList();
			}
			else
			{
				Console.WriteLine($"{listName}\n");
				Console.WriteLine("Now, you have the following options:\n" +
								  "· Print out the list\n" +
								  "· Add item to the list\n" +
								  "· Delete list and make a new one\n" +
				                  "· Quit program\n");
				Console.WriteLine("Print = p\n" +
								  "Add = a\n" +
				                  "Delete = d\n" +
				                  "Quit = esc");
			}
		}
		
		public void Choice1()
		{
			Console.Clear();
			Console.WriteLine("Do you want to add another item to the list?\n");
			Console.WriteLine("Yes = Enter / y\n" +
			                  "No = n\n");
		}
		
		public void Choice2()
		{
			Console.Clear();
			Console.WriteLine("Now, you have the following options:\n" +
			                  "· Print the list\n" +
			                  "· Go back to the main menu\n" +
			                  "· Sort the list\n");
			Console.WriteLine("Print = p\n" +
			                  "Back = b\n" +
			                  "Sort = s");
		}
	}
}
