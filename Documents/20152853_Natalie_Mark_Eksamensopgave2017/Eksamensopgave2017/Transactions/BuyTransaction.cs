using System;
namespace Eksamensopgave2017
{
    public class BuyTransaction : Transaction
    {
        private Product _product;

        public BuyTransaction(int iD, User user, DateTime date, Product product) : base(iD, user, date)
        {
            this.Product = product;
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public override string ToString()
        {
            return string.Format($"{User}\n" +
                                 $"You have made following transaction:\n" +
                                 $" Bought: {Product}\n" +
                                 $" Time: {Date}\n" +
                                 $" [Transaction ID {ID}]\n" +
                                 $" You now have {User.Balance - Product.Price},- left");
        }

        public override void Execute()
        {
            decimal newBalance = User.Balance - Product.Price;
            Console.WriteLine(newBalance);
            if (Product.Active)
            {
                if (!(newBalance < 50))
                    User.Balance = newBalance;
                else if (newBalance < 50 && newBalance >= 0)
                    User.UserBalanceNotification(User, newBalance);
                else
                    throw new InsufficientCreditsException($"{User.Firstname} {User.Lastname} (ID {User.ID}) does not have money enough for the attempted purchase\n" +
                                                           $"Tried to buy: {Product.Name} (ID {Product.ID}) which costs {Product.Price},-\n" +
                                                           $"Current balance: {User.Balance}");
			}
            else
                throw new Exception("Product is not active and can't be bought");
        }
    }
}
