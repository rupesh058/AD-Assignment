using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class BankAccount
    {
        // private fields to store account number and balance
        private string accountNumber;
        private double balance;

        // public property to only get the account number (read only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // public property to get the balance
        // balance can only be set inside this class
        public double Balance
        {
            get { return balance; }
            private set
            {
                // checking value is positive before setting
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be zero or negative.");
                }
            }
        }

        // constructor to set initial values when object is created
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber; // setting account number

            // checking initial balance is valid
            if (initialBalance > 0)
            {
                balance = initialBalance;
            }
            else
            {
                // if invalid then set to 1
                Console.WriteLine("Initial balance must be greater than 0. Setting balance to 1.");
                balance = 1;
            }
        }

        // method to deposit money
        public void Deposit(double amount)
        {
            // amount must be positive
            if (amount > 0)
            {
                balance += amount; // adding deposit to balance
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }

        // method to withdraw money
        public void Withdraw(double amount)
        {
            // amount must be positive
            if (amount > 0)
            {
                // checking if there is enough balance
                if (amount <= balance)
                {
                    balance -= amount; // subtracting from balance
                    Console.WriteLine($"Withdrawn: {amount}");
                }
                else
                {
                    Console.WriteLine("Not enough balance to withdraw.");
                }
            }
            else
            {
                Console.WriteLine("Withdraw amount must be greater than 0.");
            }
        }
    }
}
