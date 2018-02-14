using System;
namespace Eksamenslæsning
{
	public class opg2Person
	{
		/// ------------------------------------------
		/// Constructors
		/// ------------------------------------------


		public opg2Person(string firstName, int age)
		{
			this.firstName = firstName;
			this.age = age;
		}

		public opg2Person(string firstName, int age, opg2Person mom, opg2Person dad)
		{
			this.firstName = firstName;
			this.age = age;
			this.mom = mom;
			this.dad = dad;
		}

		/// ------------------------------------------
		/// Variables
		/// ------------------------------------------

		public string firstName { get; set; }
		public string lastName { get; set; }
		public int age { get; set; }

		public opg2Person mom { get; set; }
		public opg2Person dad { get; set; }

		public readonly int ID = _nextID++;
		private static int _nextID = 1;

		/// ------------------------------------------
		/// Print
		/// ------------------------------------------

		public void Print()
		{
			Console.WriteLine($"ID: {ID} Age: {this.age}\n" +
			                  $"Name: {this.firstName}" +
			                  $"{this.lastName}\n");
		}

		public void PrintTree()
		{
			Print();

			if (mom != null)
				mom.PrintTree();

			if (dad != null)
				dad.PrintTree();
		}
	}
}
