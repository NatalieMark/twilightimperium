using System;
namespace Eksamenslæsning
{
	public class Run4
	{
		public void run()
		{ 
			opg4Student a = new opg4Student("Natalie", 20);
			opg4Student b = new opg4Student("Hadil", 21);
			opg4Employee c = new opg4Employee("Morten", 27);
			opg4Employee d = new opg4Employee("Bogi", 20);
			opg4Employee e = new opg4Employee("Mikkel", 21);
			opg4Employee f = new opg4Employee("Frederik", 22);

			a.Print();
			b.Print();
			c.Print();
			d.Print();
			e.Print();
			f.Print();

		}
	}
}
