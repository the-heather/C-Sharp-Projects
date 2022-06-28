using System;

namespace InterfaceQuitable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 1342;
            employee1.SayName();
            employee1.Quit();

        }
    }
}
