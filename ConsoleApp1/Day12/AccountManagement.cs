using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1.Day12
{
    internal class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }   // Deposit / Withdraw
        public int Amount { get; set; }
    }

    internal class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public String AccountType { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }

    internal class AccountManagement
    {
        private Dictionary<String,Account> _accounts=new Dictionary<string, Account> ();
        public void CreateAccount()
        {
            Console.Write("Enter the name : ");
            String name= Console.ReadLine();
            Random random = new Random();
            string accountNumber = $"{random.Next(1000, 9999)}{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
            Account newAccount = new Account
            {
                AccountNumber = accountNumber,
                Name=name,
                Balance = 0,
            };
            _accounts[accountNumber] = newAccount;

            Console.WriteLine("\n============= Account successfully created =============");
            Console.WriteLine($"Account Holder : {name}");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Balance        : $0");
            Console.WriteLine("========================================================\n");

        }

        public void Deposit()
        {
            Console.Write("Enter the account no: ");
            String accNo = Console.ReadLine();
            if (_accounts.ContainsKey(accNo))
            {
                Console.Write("Enter the amount : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                var acc = _accounts[accNo];
                acc.Balance += amount;

                acc.Transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Type = "Deposit",
                    Amount = amount,

                });

                Console.WriteLine($"Deposited ${amount}. New Balance: ${acc.Balance}\n");

            }
            else Console.WriteLine("Account doesn't exist");
        }

        public void WithDraw()
        {
            Console.Write("Enter the account no: ");
            String accNo = Console.ReadLine();
            if (_accounts.ContainsKey(accNo))
            {
                Console.Write("Enter the amount : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                var acc = _accounts[accNo];
                if (acc.Balance > 0)
                {
                    acc.Balance -= amount;
                    acc.Transactions.Add(new Transaction
                    {
                        Date = DateTime.Now,
                        Type = "Withdraw",
                        Amount = amount,

                    });
                    Console.WriteLine($"Withdrawn ${amount}. New Balance: ${acc.Balance}\n");

                } 
                else Console.WriteLine("Insufficient balance");
            }
            else Console.WriteLine("Account doesn't exist");
        }

        public void AccountDetails() 
        {
            Console.Write("Enter the account number : ");
            string accno = Console.ReadLine();
            if (_accounts.ContainsKey(accno))
            {
                var acc = _accounts[accno];
                Console.WriteLine("\n======= Account details =============");
                Console.WriteLine($"Account number : {acc.AccountNumber}");
                Console.WriteLine($"Account Holder Name : {acc.Name}");
                Console.WriteLine($"Account Balance : {acc.Balance}");
                Console.WriteLine("===================================\n");
            }
            else Console.WriteLine("Account not exist");
        }

        public void TransactionHistory() {
            Console.Write("Enter the account number : ");
            string accno = Console.ReadLine();
            
            if (_accounts.ContainsKey(accno))
            {
                Console.Write($"Enter the type of transaction [1.Deposit 2.Withdraw  3. All] : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                var account = _accounts[accno];
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n============ Deposit Transaction History ===================");
                        foreach (var acc in account.Transactions.OrderByDescending(t => t.Date))
                        {
                            if (acc.Type == "Deposit")
                            {
                                Console.WriteLine($"The amount of {acc.Amount} was deposited at {acc.Date}");
                            }
                        }
                        Console.WriteLine("========================================================\n");
                        break;
                    case 2:
                        Console.WriteLine("\n============ Withdrawn Transaction History ===================");
                        foreach (var acc in account.Transactions.OrderByDescending(t => t.Date))
                        {
                            if (acc.Type == "Withdraw")
                            {
                                Console.WriteLine($"The amount of {acc.Amount} was withdrawn at {acc.Date}");
                            }
                        }
                        Console.WriteLine("========================================================\n");
                        break;
                    case 3:
                        Console.WriteLine("\n============ All Transaction History (Latest) ===================");
                        foreach (var acc in account.Transactions.OrderByDescending(t=> t.Date))
                        {
                            Console.WriteLine($"{acc.Date} - {acc.Type} - ${acc.Amount}");
                        }
                        Console.WriteLine("========================================================\n");
                        break;
                    default: Console.WriteLine("Enter the appropriate choice"); break;

                }
            }
            else Console.WriteLine("Account not exist");
        }

        public void CalculateInterest()
        {
            Console.Write("Enter account number: ");
            string accNo = Console.ReadLine();
            if (_accounts.ContainsKey(accNo))
            {
                Console.Write("Enter annual interest rate (in %): ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter time period (in years): ");
                double time = Convert.ToDouble(Console.ReadLine());

                var acc = _accounts[accNo];

                // Simple interest formula
                double interest = acc.Balance * (rate / 100) * time;

                Console.WriteLine($"\n Interest calculated for account {acc.AccountNumber}: ${interest:F2}");

                acc.Transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Type = "Interest",
                    Amount = (int)interest
                });
                acc.Balance += (int)interest;
                Console.WriteLine($"Updated balance after adding interest: ${acc.Balance}\n");

            }
            else Console.WriteLine("Account not exist");


        }

        public AccountManagement()
        {
            bool flag = true;
            do
            {
                Console.Write("Enter the choice \n 1. Create Account \n 2. Deposit \n 3. Withdraw \n 4. Account Details \n 5. Calculate Interest \n 6. Transaction History \n 7. Exit \n choice : ");
                int choice =Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        CreateAccount(); break;
                    case 2:
                        Deposit();break;
                    case 3:
                        WithDraw(); break;
                    case 4:
                        AccountDetails(); break;
                    case 5:
                        CalculateInterest(); break;
                    case 6:
                        TransactionHistory(); break;
                    case 7:
                        flag=false;
                        break;

                    default: Console.WriteLine("Enter the appropriate option");break;
                }
            }while (flag);
        }




    }
   
}
