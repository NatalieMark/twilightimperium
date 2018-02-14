using System;
using System.Collections.Generic;
namespace Eksamenslæsning
{
	abstract class opg4PersonFilter
	{
		public abstract bool Match(opg4Person person);

		public virtual List<opg4Person> Filter(List<opg4Person> people)
		{
			List<opg4Person> result = new List<opg4Person>();
			foreach (opg4Person person in people)
			{
				if (Match(person))
					result.Add(person);
			}
			return result;
		}
	}
}
