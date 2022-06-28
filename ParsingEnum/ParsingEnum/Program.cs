using System;

namespace ParsingEnum
{
    class Program
    {
            enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week:");
            string input = Console.ReadLine();
                try
                {
                WeekDays values = (WeekDays)Enum.Parse(typeof(WeekDays), input);
                Console.WriteLine(values);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, that is not a day of the week.");
                }
            Console.ReadLine();
        }
    }
}
    
