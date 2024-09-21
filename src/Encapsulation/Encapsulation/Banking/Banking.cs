using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { if (value < 0) { _balance = 0.0; } else { _balance = value; } }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            _accountNumber = string.IsNullOrEmpty(accountNumber) ? "Unknown" : accountNumber;
            _accountHolder = string.IsNullOrEmpty(accountHolder) ? "Unknown" : accountHolder;
            Balance = balance < 0 ? 0.0 : balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}