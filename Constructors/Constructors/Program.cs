using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Heather";
            Console.WriteLine("My name is " + name);
            Employee emp1 = new Employee("Hazel", "32");
        }
    }
}
