using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account1 = new SavingsAccount("James Stuart", "0027476177", 40000m, 0.03);

            CurrentAccount account2 = new CurrentAccount("Abayomi Igwubor", "0027476177", 30000m);

            List<Account> accounts = new List<Account>(){account1, account2};

            Console.Write("Welcome to Access Bank PLC!\nEnter type of transaction (Debit or Credit): ");
            string TransactionType = Console.ReadLine();

            Console.Write("Enter amount: ");
            decimal Amount = Convert.ToDecimal(Console.ReadLine());

            foreach (var account in accounts)
            {
                if (TransactionType.ToUpper() == "CREDIT")
                {
                    if (account is SavingsAccount)
                    {
                        SavingsAccount savings = account as SavingsAccount;
                        savings.CalculateInterest();                        
                    }
                    account.Credit(Amount);
                    Console.WriteLine(account);

                } else if (TransactionType.ToUpper() == "DEBIT")
                {
                    account.Debit(Amount);
                    Console.WriteLine(account);
                }
                Console.WriteLine("=========================\n");
            }

        }
    }
}
