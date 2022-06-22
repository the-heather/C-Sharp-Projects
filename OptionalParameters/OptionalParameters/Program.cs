using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            string firstNum = Console.ReadLine(); //take user input
            int numOne = Convert.ToInt32(firstNum); //convert to an int
            Console.WriteLine("Enter second number, ");
            Console.WriteLine("(A default value of 0 will be used if left blank):");

            int numTwo;
            int result;
            if (int.TryParse((Console.ReadLine(), out numTwo))
            {
                result = Math.Multi(numOne, numTwo);
            }
            else
            {
                result = Math.Multi(numOne);

            }
            Console.WriteLine(result);
        }
    }
}
