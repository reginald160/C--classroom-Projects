using System;

namespace PayrollSystem {
    public class SalariedEmployee : Employee {
        private decimal weeklySalary;

        public SalariedEmployee (string firstname, string lastname, int empID, decimal weeklysalary) : base (firstname, lastname, empID) {
            WeeklySalary = weeklysalary;
        }

        public decimal WeeklySalary {
            get => weeklySalary;
            set {
                if (value > 0M)
                    weeklySalary = value;
                else
                    throw new System.ArgumentOutOfRangeException ("Value out of range!");
            }
        }

        public override decimal Earnings () => WeeklySalary;

        public override string ToString () => $"Salaried Employee: {base.ToString()}";

    }
}