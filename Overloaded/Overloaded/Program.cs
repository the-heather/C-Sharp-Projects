using System;

namespace Overloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //instantiated class 
            math.numb = 13; //by creating new obj. and set it's 'numb' property
            int doMath = math.numb; // created var from math obj. 

            Console.Write("Enter your a decimal number:");
            string userNum = Console.ReadLine(); //take user input
            int userNumb = Convert.ToInt32(userNum); //convert to an int
            Console.WriteLine(doMath + " plus " + userNumb + " equals " + math.Calc(doMath, userNumb)); //use method on math obj

            Console.Write("Enter your a whole number:");
            string userNumTwo = Console.ReadLine(); //take user input
            int userNumbTwo = Convert.ToInt32(userNumTwo); //convert to an int
            Console.WriteLine(doMath + " minus " + userNumb + " equals " + math.Calc(doMath, userNumb));

            Console.Write("Enter your a whole number:");
            string userNumThree = Console.ReadLine(); //take user input
            Console.WriteLine(doMath + " divided by " + userNumb + " equals " + math.Calc(doMath, userNumb));
        }
    }
}
