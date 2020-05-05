namespace BankAccount
{
    public class Account
    {
        public string Name { get; set; }   
        private decimal balance;

        public Account(string name, decimal initialBalance){
            Name = name;
            Balance = initialBalance;
        }
        public decimal Balance
        {
            get { return balance; }
            private set {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void deposit(decimal amount){
            Balance = Balance + amount;
        }

        public string withdraw(decimal amount){
            if (amount > Balance)
            {
                return "Insufficient balance!";   
            } else {
                Balance = Balance - amount;
                return "Account debited successfully!";
            }
        }
        
    }
}