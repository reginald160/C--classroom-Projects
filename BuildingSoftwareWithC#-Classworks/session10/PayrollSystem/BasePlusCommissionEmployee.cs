using System;

namespace PayrollSystem {
    public class BasePlusCommissionEmployee : CommissionEmployee {
        public decimal BaseSalary { get; set; }

        public BasePlusCommissionEmployee (string firstname, string lastname, int empID, decimal baseSalary, double rate, decimal totalsales) : base (firstname, lastname, empID, rate, totalsales) {
            BaseSalary = baseSalary;
        }

        public override decimal Earnings () {
            return base.Earnings () + BaseSalary;
        }

        public override string ToString () {
            return $"Base Plus Commission Employee: {base.ToString()}\nWeekly Base Salary: {BaseSalary}";
        }

    }
}