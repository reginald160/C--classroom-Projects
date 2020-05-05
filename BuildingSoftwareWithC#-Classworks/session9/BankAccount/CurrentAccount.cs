namespace BankAccount
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(string name, string acctNum, decimal bal) : base(name, acctNum, bal)
        {     }

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

    }
}