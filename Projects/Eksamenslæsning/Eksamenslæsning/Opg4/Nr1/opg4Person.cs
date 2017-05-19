using System;
namespace Eksamenslæsning
{
	public abstract class opg4Person
	{
		public opg4Person(string name) : this(name, 25) { }
		public opg4Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string name { get; set; }
		public int age { get; set; }

		public override string ToString()
		{
			return $"{name}, alder: {age}";
		}

		public virtual void Print()
		{
			Console.WriteLine($"{name} {age}");
		}
	}
}
