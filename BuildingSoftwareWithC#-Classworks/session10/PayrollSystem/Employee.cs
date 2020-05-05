using System.Collections.Generic;
namespace PayrollSystem {
    abstract public class Employee : IPayment {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }

        public Employee (string firstname, string lastname, int empID) {
            FirstName = firstname;
            LastName = lastname;
            EmployeeID = empID;
        }

        public override string ToString () => $"{FirstName} {LastName}\nEmployee ID: {EmployeeID}";

        public abstract decimal Earnings ();

        public decimal GetPaymentAmount () {
            return Earnings ();
        }

    }

   
}