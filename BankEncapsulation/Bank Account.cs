using System;
namespace BankEncapsulation
{
    public class Bank_Account
    {
        public Bank_Account()
        {
        }

        private double balance = 0;

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }


    }
}

