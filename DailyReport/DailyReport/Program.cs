using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            //storing user input into variable 
            string studentName = Console.ReadLine();
            Console.WriteLine(studentName + ", what course are you on?");
            string studentCourse = Console.ReadLine();
            Console.WriteLine("What page number in the " + studentCourse + " course are you on?");
            string pageNumber = Console.ReadLine();
            //converting string to integer
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string help = Console.ReadLine();
            //converting string to bool
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string happyExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            //converting string to integer
            int totHours = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your answers, " + studentName + ". An Instructor will respond to this shortly. Have a great day!");



        }
    }
}
