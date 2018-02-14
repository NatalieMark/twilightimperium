using System;
using System.Collections.Generic;
namespace Eksamenslæsning
{
	public class opg5Person : IComparable<opg5Person>
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public DateTime birthday { get; set; }

		public opg5Person(string firstname, string lastname, DateTime birthday)
		{
			this.firstname = firstname;
			this.lastname = lastname;
			this.birthday = birthday;
		}

		public int CompareTo(opg5Person other)
		{
			if (this.firstname == other.firstname)
				return this.lastname.CompareTo(other.lastname);
			return other.firstname.CompareTo(this.firstname);
		}

		public override string ToString()
		{
			return string.Format($"[opg5Person: {firstname}\t{lastname}    \t{birthday}");
		}
	}
}
