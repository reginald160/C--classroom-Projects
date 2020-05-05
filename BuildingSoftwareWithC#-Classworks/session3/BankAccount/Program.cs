using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Polaris Bank");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("\nEnter initial balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter 1 for deposit\nEnter 2 for withdrawal");
            int transactionType = Convert.ToInt32(Console.ReadLine());

            Account account = new Account(name, initialBalance);

            if(transactionType == 1){
                Console.Write("Enter amount to deposit: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"adding {amount:C} to account balance...");

                account.deposit(amount);

                Console.WriteLine($"Your current account balance is {account.Balance:C}");

            } else if(transactionType == 2){
                Console.Write("Enter amount to withdraw: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"debitting {amount:C} from account balance...");

                string response = account.withdraw(amount);

                Console.WriteLine($"{response}");
                Console.WriteLine($"Your balance is {account.Balance:C}");
            } else
            {
                Console.WriteLine("Invalid entry!!!");
            }
            

            Console.WriteLine($"Thank you for banking with us!");



        }
    }
}
