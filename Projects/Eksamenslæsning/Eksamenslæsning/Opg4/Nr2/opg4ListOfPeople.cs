using System;
using System.Collections.Generic;
namespace Eksamenslæsning
{
	public class opg4ListOfPeople
	{
		public opg4ListOfPeople()
		{
		}

		public void List()
		{
			List<opg4Person> l = new List<opg4Person>();
			l.Add(new opg4Student("Hadil", 21));
			l.Add(new opg4Student("Natalie", 20));
			l.Add(new opg4Employee("Morten", 27));
			l.Add(new opg4Employee("Bogi", 20));

			opg4PersonFilter f = new opg4FilterIsh();
			List<opg4Person> filteredList = f.Filter(l);
		}
	}
}
