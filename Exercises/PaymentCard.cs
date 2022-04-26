using System;

namespace OOP.Exercises
{
    public class PaymentCard
    {
        public double Balance { get; set; }

        public PaymentCard(double openingBalance)
        {
            Balance = openingBalance;
        }


        public double DrinkCoffee(double price)
        {
            if (Balance < price)
            {
                Console.WriteLine("You have not enough money");
                return Balance;
            }
            else
            {
                return Balance -= price;
            }


        }

        public double EatLunch(double price)
        {
            if (Balance < price)
            {
                Console.WriteLine("You have not enough money");
                return Balance;
            }
            else
            {
                return Balance -= price;
            }


        }

        public double AddMoney(double amount)
        {
            if (amount < 0 || amount > 150)
            {
                Console.WriteLine("Invalid amount");
                return Balance;
            }
            else
            {
                return Balance += amount;
            }
        }

        public void CardInfo()
        {
            Console.WriteLine(this.Balance);

        }
    }
}