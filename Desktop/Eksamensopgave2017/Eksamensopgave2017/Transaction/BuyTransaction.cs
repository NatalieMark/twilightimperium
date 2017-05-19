using System;
using System.Collections.Generic;

namespace Eksamensopgave2017
{
    public class BuyTransaction : Transaction
    {
        private Product _product;

        public BuyTransaction(User user, DateTime date, Product product) : base(user, date)
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
            return string.Format($"[Transaction ID {ID}]\n" +
                                 $" {Date}\n" +
                                 $" {User}\n" +
                                 $" Bought: {Product}\n");
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
                throw new InactiveException("Product is not active and can't be bought");
        }

      
    }
}