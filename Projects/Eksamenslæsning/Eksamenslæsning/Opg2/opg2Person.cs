using System;
namespace Eksamenslæsning
{
	public class Person
	{
		/// ------------------------------------------
		/// Constructors
		/// ------------------------------------------


		public Person(string firstName, int age)
		{
			this.firstName = firstName;
			this.age = age;
		}

		public Person(string firstName, int age, Person mom, Person dad)
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

		public Person mom { get; set; }
		public Person dad { get; set; }

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
