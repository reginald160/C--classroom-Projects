using System;
using System.Collections.Generic;

namespace PayrollSystem {
    class Program {
        static void Main (string[] args) {
            SalariedEmployee salariedEmployee = new SalariedEmployee ("James", "Stuart", 123, 10000m);

            HourlyEmployee hourlyEmployee = new HourlyEmployee ("Ruth", "Rutherford", 124, 40, 500m);

            CommissionEmployee commissionEmployee = new CommissionEmployee ("Ruth", "Rutherford", 124, 0.08, 50000m);

            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee ("Ruth", "Rutherford", 124, 7000m, 0.06, 20000m);

            Console.WriteLine (salariedEmployee);
            Console.WriteLine ($"Earnings: {salariedEmployee.Earnings():C}\n");

            Console.WriteLine (hourlyEmployee);
            Console.WriteLine ($"Earnings: {hourlyEmployee.Earnings():C}\n");

            Console.WriteLine (commissionEmployee);
            Console.WriteLine ($"Earnings: {commissionEmployee.Earnings():C}\n");

            Console.WriteLine (basePlusCommissionEmployee);
            Console.WriteLine ($"Earnings: {basePlusCommissionEmployee.Earnings():C}\n");

            Console.WriteLine ("=== POLYMORPHICALLY ACCESSING METHODS OF OBJECTS CREATED FROM CONCRETE DERIVED-CLASSES OF AN ABSTRACT BASE CLASS =======");

            List<Employee> employees = new List<Employee> () { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };

            foreach (var employee in employees) {
                Console.WriteLine (employee);
                if (employee is BasePlusCommissionEmployee) {
                    var baseEmployee = (BasePlusCommissionEmployee) employee;
                    baseEmployee.BaseSalary *= 1.10M;
                    Console.WriteLine ($"Salary incremented by: 10% - {baseEmployee.BaseSalary:C}");
                }
                Console.WriteLine ($"Earnings: {employee.Earnings():C}\n");
            }
        }
    }
}