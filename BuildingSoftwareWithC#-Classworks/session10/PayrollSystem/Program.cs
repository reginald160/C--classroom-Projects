using System;
using System.Collections.Generic;

namespace PayrollSystem {
    class Program {
        static void Main (string[] args) {
            SalariedEmployee salariedEmployee = new SalariedEmployee ("James", "Stuart", 123, 10000m);

            HourlyEmployee hourlyEmployee = new HourlyEmployee ("Ruth", "Rutherford", 124, 40, 500m);

            CommissionEmployee commissionEmployee = new CommissionEmployee ("Ruth", "Rutherford", 124, 0.08, 50000m);

            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee ("Ruth", "Rutherford", 124, 7000m, 0.06, 20000m);

            Invoice invoice1 = new Invoice ("Fan", "Century Standing Rechargeable Fan", 18000M, 2);

            Invoice invoice2 = new Invoice ("Projector", "EPSON Projector 3456", 68000M, 1);

                Console.WriteLine (salariedEmployee);
                Console.WriteLine ($"Earnings: {salariedEmployee.Earnings():C}\n");

                Console.WriteLine (hourlyEmployee);
                Console.WriteLine ($"Earnings: {hourlyEmployee.Earnings():C}\n");

                Console.WriteLine (commissionEmployee);
                Console.WriteLine ($"Earnings: {commissionEmployee.Earnings():C}\n");

                Console.WriteLine (basePlusCommissionEmployee);
                Console.WriteLine ($"Earnings: {basePlusCommissionEmployee.Earnings():C}\n");

                Console.WriteLine ("=== POLYMORPHICALLY ACCESSING METHODS OF OBJECTS CREATED FROM CONCRETE DERIVED-CLASSES OF AN ABSTRACT BASE CLASS =======");

                List<IPayment> paymentsDue = new List<IPayment> () { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee, invoice1, invoice2 };

                foreach (var payment in paymentsDue) {
                    Console.WriteLine (payment);
                    if (payment is BasePlusCommissionEmployee) {
                        var baseEmployee = (BasePlusCommissionEmployee) payment;
                        baseEmployee.BaseSalary *= 1.10M;
                        Console.WriteLine ($"Salary incremented by: 10% - {baseEmployee.BaseSalary:C}");
                    }
                    Console.WriteLine ($"Amount to be paid: {payment.GetPaymentAmount():C}\n");
                }
        }
    }
}