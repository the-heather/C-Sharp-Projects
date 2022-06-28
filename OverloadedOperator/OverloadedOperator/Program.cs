using System;

namespace OverloadedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 1342;


            Employee employee2 = new Employee();
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.Id = 1342;

            Console.WriteLine(employee1 == employee2);
        }
    }
}
