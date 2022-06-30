using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {   //create list of employees
            List<Employee> employees = new List<Employee>();
            //add employees to list 
            employees.Add(new Employee() { FirstName = "Ted", LastName = "Clark", Id = 12 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Ford", Id = 13 });
            employees.Add(new Employee() { FirstName = "Louis", LastName = "Clark", Id = 14 });
            employees.Add(new Employee() { FirstName = "Ted", LastName = "Phillips", Id = 15 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Adams", Id = 16 });
            employees.Add(new Employee() { FirstName = "Mary", LastName = "Jackson", Id = 17 });
            employees.Add(new Employee() { FirstName = "Ted", LastName = "Smith", Id = 18 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Willams", Id = 19 });
            employees.Add(new Employee() { FirstName = "Henry", LastName = "Brown", Id = 20 });
            employees.Add(new Employee() { FirstName = "Phil", LastName = "Thomas", Id = 21 });

             //create new list of employees for joes
             List<Employee> joe = new List<Employee>();

            foreach (Employee employee in employees)
            {   //if element has first name joe, add to joe list 
                if (employee.FirstName == "Joe")
                {
                    joe.Add(employee);
                } 
            }
            // display items on joe list
            foreach(Employee employee in joe)
            {   
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
            //create a new list where akk
            List<Employee> joe2 = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in joe2)
            { 
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }

            List<Employee> greaterThan = employees.Where(x => x.Id >= 5).ToList();

            foreach (Employee employee in greaterThan)
            {   //if element contains first name Joe
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
        }
    }
}