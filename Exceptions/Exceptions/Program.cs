using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Divide-O-Matic!");
            //try to excute block of code
            try
            {
                // Create a list of values
                List<int> nums = new() { 5, 73, 237, 7945, 39846 };
                Console.WriteLine("Enter a whole number to divide by: ");
                int getNum = Convert.ToInt32(Console.ReadLine());
                //Loop over items in list 
                foreach (int num in nums)
                {   //dividing each by the number entered by user
                    int total = num / getNum;
                    Console.WriteLine(num + " divided by " + getNum + " equals " + total);
                }
            }
            //if this exception occurs
            catch (FormatException)
            {   //print this message
                Console.WriteLine("Entry not valid. Please enter a whole number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by 0 is not possible. Please try again.");
            }
            //after handling the exception
            finally
            {   //print this message
                Console.WriteLine("Want to try with different numbers? Restart the program!");
            }
        }
    }
}