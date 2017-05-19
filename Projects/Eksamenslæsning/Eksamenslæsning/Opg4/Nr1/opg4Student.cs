using System;
namespace Eksamenslæsning
{
	public class opg4Student : opg4Person
	{
		public opg4Student(string name) : base(name) { }

		public opg4Student(string name, int age) : base(name, age) { }

		private static int _studentIDCounter = 0;
		public int sutdentID { get; } = _studentIDCounter++;

		public override string ToString()
		{
			return $"{base.ToString()} #{sutdentID}";
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Student ID: {sutdentID}");
		}
	}
}
