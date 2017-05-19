using System;
using System.Collections.Generic;

namespace Eksamensopgave2017
{
	public abstract class Transaction
	{
		private int _iD = 0; //Starting with 0 and counts up 1 for every transaction
		private User _user;
        private DateTime _date = DateTime.Now; 

		public Transaction(int iD, User user, DateTime date)
		{
			this.ID = iD;
			this.User = user;
			this.Date = date;
		}

		public int ID
		{
			get { return _iD; }
			set
			{
				if (value >= 0)
					_iD = value;
				else
					throw new ArgumentException("ID must be larger than or equal to 0");
			}
		}

		public User User
		{
			get { return _user; }
			set { _user = value; }
		}

		public DateTime Date 
		{ 
			get { return _date; } 
			set { _date = value; } 
		}

		public override string ToString()
		{
			return string.Format($"{User}\n" +
                                 $"[Transaction ID {ID}] ({Date})\n");
		}
		
        public abstract void Execute();
    }
}
