using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            float res; //var to store output
            Math.Divide(userNum, out res);        
        }
    }
}
