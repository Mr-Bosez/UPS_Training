using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day13
{
    internal class BankAccounts
    {
        public double balance;
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }

    }

    internal class SavingsAccount : BankAccounts
    {
        public override void Withdraw(double amount)
        {
            double limit = 1000; 

            if (amount > limit)
            {
                Console.WriteLine("Withdrawal limit exceeded! Max limit is " + limit);
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Savings withdrawal: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance in savings account!");
            }
        }
    }

    class CheckingAccount : BankAccounts
    {
     
        double limit = 5000;
        public override void Withdraw(double amount)
        {
            double fee = 10; // withdrawal fee
            double totalAmount = amount + fee;

            if (amount > limit)
            {
                Console.WriteLine("Withdrawal limit exceeded! Max limit is " + limit);
            }
            else if (amount <= balance)
            {
                balance -= totalAmount;
                Console.WriteLine("Checking withdrawal: " + amount + " (Fee: " + fee + ")");
            }
            else
            {
                Console.WriteLine("Insufficient balance in savings account!");
            }
        }
    }
}
