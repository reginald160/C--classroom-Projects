namespace SDSDEmp
{
    public class SalrayEmployee : Employee
    {
        public decimal Salary { get; set; } 

        public SalrayEmployee(string firstname, string last, string address, string gender, Date birthday, Date hiredate, decimal salary) : base (firstname, last, address, gender, birthday, hiredate)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employment Type: Salary Employee\n{FirstName}, {LastName}\nHired on {HireDate}\nDate of Birth: {Birthday}\nSalaray: {Salary:C}";
        }
    }
}