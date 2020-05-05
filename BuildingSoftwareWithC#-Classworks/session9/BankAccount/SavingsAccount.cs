namespace BankAccount
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }   
        public SavingsAccount(string name, string acctNum, decimal bal, double interest) : base (name, acctNum, bal)
        {
            InterestRate = interest;
        }

        public override string Credit(decimal amount)
        {
            Balance += amount;
            return $"{amount:C} credited to account:\n{base.ToString()}";
        }

        public override string Debit(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return $"{amount:C} debited from account:\n{base.ToString()}";
            } 
            return $"{amount:C} - Insufficient fund in account.\n{base.ToString()}";
        }

        public string CalculateInterest()
        {
            decimal InterestAmount = (decimal)InterestRate * Balance;
            Credit(InterestAmount);
            return $"{InterestRate*100}% interest ({InterestAmount:C}) received.";
        }

    }
}