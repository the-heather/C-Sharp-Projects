using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //instantiated class 
            math.numb = 13; //by creating new obj. and set it's 'numb' property
            int doMath = math.numb; // created var from math obj. 

            Console.Write("Enter your a whole number:");
            string userNum = Console.ReadLine(); //take user input
            int userNumb = Convert.ToInt32(userNum); //convert to an int
                                                                       //use Add method on math obj
            Console.WriteLine(doMath + " plus " + userNumb + " equals " + math.Add(doMath, userNumb));
            Console.WriteLine(doMath + " minus " + userNumb + " equals " + math.Sub(doMath, userNumb));
            Console.WriteLine(doMath + " divided by " + userNumb + " equals " + math.Multi(doMath, userNumb));
        }
    }
}
