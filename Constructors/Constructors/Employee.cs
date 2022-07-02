using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Employee
    {
        public const int Months = 12;

        public Employee() : this(string.Empty, string.Empty, string.Empty)
        {
            Console.WriteLine("Employee() constructor called");
        }

        public Employee(string Name, string EmpId) : this(Name, EmpId, string.Empty)
        {
            Console.WriteLine("Employee(Name,EmpId) constructor called");
        }

        public Employee(string Name, string EmpId, string Department)
        {
            Console.WriteLine("Employee(Name,EmpId,Department) constructor called");
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(EmpId) && !string.IsNullOrEmpty(Department));  
        }
    }
}

