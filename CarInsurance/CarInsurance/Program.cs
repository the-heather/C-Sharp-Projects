using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int appAge = Convert.ToInt32(age);
            Console.WriteLine("True or False. Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool appDui = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int appTickets = Convert.ToInt32(tickets);
            int minAge = 15;
            bool ageResult = appAge == minAge || appAge > minAge;
            int maxTickets = 3;
            bool tkResults = appTickets == maxTickets || appTickets < maxTickets;
            bool qualified = ageResult == true && appDui == false && tkResults == true;
            Console.WriteLine("Qualified? " + qualified.ToString());
            ;
        }
    }
}
