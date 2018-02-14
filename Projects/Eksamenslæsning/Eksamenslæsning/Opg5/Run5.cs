using System;
using System.Collections.Generic;
namespace Eksamenslæsning
{
	public class Run5
	{
		public Run5()
		{
		}

		public void run()
		{
			opg3();
		}

		public void opg2()
		{
			opg5nr2 o = new opg5nr2();
		}

		public void opg3()
		{ 
			List<opg5Person> list = new List<opg5Person>();
			list.Add(new opg5Person("Per", 		"Larsen", 		new DateTime(1997, 03, 12)));
			list.Add(new opg5Person("Inge", 	"Getrudsen", 	new DateTime(1983, 03, 11)));
			list.Add(new opg5Person("Natalie", 	"Mark", 		new DateTime(1996, 06, 22)));
			list.Add(new opg5Person("Jane", 	"Mark", 		new DateTime(1973, 11, 27)));
			list.Add(new opg5Person("Per", 		"Persson", 		new DateTime(1981, 02, 27)));
			
			list.Sort();
			
			foreach (opg5Person item in list)
				Console.WriteLine(item);
		}
	}
}
