using System;

namespace Inheritance
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
        }

            public static bool equals(Employee employee1, Employee employee2)
            {
                if (employee1.Id == employee2.Id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
}
