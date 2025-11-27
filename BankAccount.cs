using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber => accountNumber;

        public double Balance
        {
            get => balance;
            private set
            {
                if (value > 0)
                    balance = value;
            }
        }

        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }
    }
}
