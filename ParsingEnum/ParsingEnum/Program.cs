using System;

namespace ParsingEnum
{
    class Program
    {
        static void Main(string[] args)
        { // ?? <-- as soon as I add the enum it throws an error
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
        Console.WriteLine("Please enter a day of the week:");
            string input = Console.ReadLine();
        var values = Enum.GetValues(typeof(DayOfTheWeek));

            try
            {
                foreach (DayOfTheWeek status in values) 
                {
                    if (input == values)
                    {
                        Console.WriteLine("Yay! Parse succeeded");
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid day of the week");
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a valid day of the week: ");
            }
        }
    }
}
    
