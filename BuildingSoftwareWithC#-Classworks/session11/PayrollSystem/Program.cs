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

            Console.WriteLine ("=== POLYMORPHICALLY ACCESSING METHODS OF OBJECTS FROM A GENERIC COLLECTION CLASS =======");

            // List<IPayment> paymentsDue = new List<IPayment> () { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee, invoice1, invoice2 };

            PaymentCollection<IPayment> payments = new PaymentCollection<IPayment> (6);

            payments.Add (salariedEmployee);
            payments.Add (hourlyEmployee);
            payments.Add (basePlusCommissionEmployee);
            payments.Add (commissionEmployee);
            payments.Add (invoice1);
            payments.Add (invoice2);

            foreach (var payment in payments) {
                try {
                    Console.WriteLine (payment);
                    if (payment is BasePlusCommissionEmployee) {
                        var baseEmployee = (BasePlusCommissionEmployee) payment;
                        baseEmployee.BaseSalary *= 1.10M;
                        Console.WriteLine ($"Salary incremented by: 10% - {baseEmployee.BaseSalary:C}");
                    }
                    Console.WriteLine ($"Amount to be paid: {payment.GetPaymentAmount():C}\n");
                } catch (System.Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}