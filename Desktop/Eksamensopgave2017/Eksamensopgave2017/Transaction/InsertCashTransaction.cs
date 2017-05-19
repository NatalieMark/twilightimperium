using System;
namespace Eksamensopgave2017
{
	public class InsertCashTransaction : Transaction
	{
		private decimal _deposit;

		public InsertCashTransaction(User user, DateTime date, decimal deposit) : base(user, date)
		{
			this.Deposit = deposit;
		}

		public decimal Deposit
		{
			get { return _deposit; }
			set { _deposit = value; }
		}

		public override string ToString()
		{
			return string.Format($"[Transaction ID {ID}]\n" +
								 $" {Date}\n" +
								 $" {User}\n" +
								 $" You have made following deposit:\n" +
								 $" Deposit: {Deposit},-\n" +
								 $" Current amount: {User.Balance + Deposit},- left on your account");
		}

		public override void Execute()
		{
			User.Balance += Deposit;
		}
	}
}