namespace BankAccount
{
    public abstract class Account
    {
        public string AccountName { get; }
        public string AccountNumber { get; }
        protected decimal Balance { get; set; } 

        public Account(string name, string acctNum, decimal bal)
        {
            AccountName = name;
            AccountNumber = acctNum;
            Balance = bal;
        }

        public override string ToString()
        {
            return $"Account Name: {AccountName}\nAccount Number: {AccountNumber}\nCurrent Balance: {Balance:C}";
        }

        public abstract string Credit(decimal amount);
        public abstract string Debit(decimal amount);

    }
}