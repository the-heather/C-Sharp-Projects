using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: Enter hourly rate:");
            string oneHourly = Console.ReadLine();
            decimal oneHrly = Convert.ToDecimal(oneHourly);
            Console.WriteLine("Person 1: Enter hours worked per week:");
            string onePerWeek = Console.ReadLine();
            int oneWklyhrs = Convert.ToInt32(onePerWeek);
            Console.WriteLine("Person 2: Enter hourly rate:");
            string twoHourly = Console.ReadLine();
            decimal twoHrly = Convert.ToDecimal(twoHourly);
            Console.WriteLine("Person 2: Enter hours worked per week:");
            string twoPerWeek = Console.ReadLine();
            int twoWklyhrs = Convert.ToInt32(twoPerWeek);
            int wksInYear = 52;
            decimal oneSalary = oneHrly * oneWklyhrs * wksInYear;
            decimal twoSalary = twoHrly * twoWklyhrs * wksInYear;
            bool oneMoreThanTwo = oneSalary > twoSalary;
            Console.WriteLine("Annual salary of Person 1: " + oneSalary.ToString());
            Console.WriteLine("Annual salary of Person 2: " + twoSalary.ToString());
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(oneMoreThanTwo);









        }
    }
}
