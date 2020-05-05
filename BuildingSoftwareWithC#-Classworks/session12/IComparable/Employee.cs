using System;
using System.Collections;
using System.Collections.Generic;

namespace IComparable
{
    public class Employee : IComparable<Employee>
    {
        public int EmpID { get; set; }  
        public string EmpName { get; set; }
        public string EmpDepartment { get; set; }   

        public Employee(int ID, string name, string dept)
        {
            EmpID = ID;
            EmpName = name;
            EmpDepartment = dept;
        }

        public int CompareTo(Employee other)
        {
            if (this.EmpID > other.EmpID)
            {
                return 1;
            } else if (this.EmpID < other.EmpID)
            {
                return -1;
            } else {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Employee ID: {EmpID}\nEmployee Name: {EmpName}\nEmployee Dept.: {EmpDepartment}\n======================";
        }
       
    }
}