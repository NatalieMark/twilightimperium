using System;
namespace Eksamensopgave2017
{
	public class User
	{
		public User()
		{
		}

		private int _iD;
		private string _firstname;
		private string _lastname;
		private string _username;
		private string _email;
		private decimal _balance;

		public int ID
		{
			get
			{
				return _iD;
			}
			set
			{
				if (value >= 0) //Not Null, but what about numbers?
					_iD = value;
				else
					throw new ArgumentException("ID must be larger than or equal to 0");
			}
		}

		public string Firstname
		{
			get 
			{
				return _firstname;
			}
			set 
			{
				if (value != null) //Not Null, but what about numbers?
					_firstname = value;
				else
					throw new ArgumentNullException("Firstname can't be empty");
			}
		}

		public string Lastname
		{
			get
			{
				return _lastname;
			}
			set
			{
				if (value != null) //Not Null, but what about numbers?
					_lastname = value;
				else
					throw new ArgumentNullException("Lastname can't be empty");
			}
		}

		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				if (value != null) //Not Null, but what about numbers?
					_username = value;
				else
					throw new ArgumentNullException("Username can't be empty");
			}
		}

		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != null) //Not Null, but what about numbers?
					_email = value;
				else
					throw new ArgumentNullException("Email can't be empty");
			}
		}

		public decimal Balance
		{
			get
			{
				return _balance;
			}
			set
			{
				_balance = value; //Balance can be less than 0
			}
		}
	}
}
