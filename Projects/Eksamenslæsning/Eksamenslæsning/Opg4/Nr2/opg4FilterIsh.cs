using System;
namespace Eksamenslæsning
{
	class opg4FilterIsh : opg4PersonFilter
	{
		public override bool Match(opg4Person person)
		{
			// det samme som if(person.Navn == "Thomas") return true; else return false;!
			return person.name == "Natalie";
		}
	}
}
