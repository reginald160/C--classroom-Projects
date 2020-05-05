using System;
using System.Collections;
using System.Collections.Generic;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(){50, 40, 30, 10, 5};

            Console.WriteLine("Items in list before sorting...");
            foreach (var num in nums)
            {
                Console.WriteLine($"{num}");
            }

            nums.Sort();

            Console.WriteLine("Items in list after sorting...");
            foreach (var num in nums)
            {
                Console.WriteLine($"{num}");
            }

            List<Employee> employees = new List<Employee>(){new Employee(120, "James Stuart", "Sales"), new Employee(102, "David Joshua", "IT"), new Employee(103, "Anthony Web", "Account"), new Employee(100, "Ifeanyi Rutherford", "Maintenance"), new Employee(99, "Caleb Rose", "Marketting") };

            Console.WriteLine("Items in list before sorting...");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.ToString()}");
            }

            employees.Sort();

            Console.WriteLine("Items in list after sorting...");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.ToString()}");
            } 

            Queue<string> objDict = new Queue<string>();

            objDict.Enqueue("James Stuart");
            objDict.Enqueue("Bankole Obafemi");

            foreach (var item in objDict)
            {
                Console.WriteLine($"{item}");
            }     

            // Console.WriteLine(objDict.ContainsKey(1));


            // foreach (var item in objDict)
            // {
            //     Console.WriteLine($"{item.Key}\t\t{item.Value}");
            // }

        }
    }
}
