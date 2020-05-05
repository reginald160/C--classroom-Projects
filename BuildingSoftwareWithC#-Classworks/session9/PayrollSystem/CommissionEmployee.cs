using System;

namespace PayrollSystem {
    public class CommissionEmployee : Employee {
        private double commRate;
        private decimal totalSales;

        public CommissionEmployee (string firstname, string lastname, int empID, double comm, decimal sales) : base (firstname, lastname, empID) {
            CommissionRate = comm;
            TotalSales = sales;
        }

        public double CommissionRate {
            get => commRate;

            set {
                if (value > 0 && value <= 1) {
                    commRate = value;
                } else {
                    throw new ArgumentOutOfRangeException ("CommissionRate must be > 0 and <= 1");
                }
            }
        }

        public decimal TotalSales {
            get => totalSales;

            set {
                if (value > 0M) {
                    totalSales = value;
                } else {
                    throw new ArgumentOutOfRangeException ("TotalSales must be > 0");
                }
            }
        }

        public override decimal Earnings () {
            return (decimal) CommissionRate * TotalSales;
        }

        public override string ToString () {
            return $"Commission Employee: {base.ToString()}\nTotal Sales: {TotalSales}\nCommission Rate: {CommissionRate*100}%";
        }
    }
}