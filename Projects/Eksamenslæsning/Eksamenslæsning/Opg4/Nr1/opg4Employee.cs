using System;
namespace Eksamenslæsning
{
	public class opg4Employee : opg4Person
	{
		public opg4Employee(string name) : base(name) { }

		public opg4Employee(string name, int age) : base(name, age){ }

		private static int _employeeIDCounter = 0;
		public int employeeID { get; } = _employeeIDCounter++;

		public override string ToString() 
		{
			return $"{base.ToString()} #{employeeID}";
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Emplyee ID: {employeeID}");
		}
	}
}
