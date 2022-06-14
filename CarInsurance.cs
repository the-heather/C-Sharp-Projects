using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("What is your age?");
            //storing user input into variable 
            string age = Console.ReadLine();
            //converting string to integer
            int appAge = Convert.ToInt32(age);
            Console.WriteLine("True or False. Have you ever had a DUI?");
            string dui = Console.ReadLine();
            //converting string to boolean
            bool appDui = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            //converting string to integer
            int appTickets = Convert.ToInt32(tickets);
            int minAge = 15;
            //comparing user's age to the min age of 15
            bool ageResult = appAge == minAge || appAge > minAge;
            int maxTickets = 3;
            //comparing user's # of tickets to the max of 3
            bool tkResults = appTickets == maxTickets || appTickets < maxTickets;
            //checking if age is >= 15, dui=false, tickets <= 3
            bool qualified = ageResult == true && appDui == false && tkResults == true;
            //returns if user is qualified for insurance or not
            Console.WriteLine("Qualified? " + qualified.ToString());
            ;
        }
    }
}
