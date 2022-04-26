using System;

namespace OOP.Exercises
{
    public class Account
    {
        public string Name;
        public double Balance;




        public Account(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public double Withdrawal(double takenAmount)
        {
            if (takenAmount > Balance)
            {
                Console.WriteLine("You have not enough money");
            }
            else
            {
                Balance -= takenAmount;
            }

            return Balance;
        }

        public double Deposit(double dipositedAmount)
        {
            Balance += dipositedAmount;

            return Balance;
        }

        public void Transfer(double amount, Account a)
        {
            if (amount > this.Balance)
            {
                Console.WriteLine("You have not enough money to transfer");
            }
            else
            {
                Withdrawal(amount);

                a.Balance += amount;
            }

        }

    }
    
}
