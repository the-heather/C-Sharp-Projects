using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight:");
            string pkWeight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(pkWeight);
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width:");
                string pkWidth = Console.ReadLine();
                int packageWidth = Convert.ToInt32(pkWidth);
                Console.WriteLine("Please enter package height:");
                string pkHeight = Console.ReadLine();
                int packageHeight = Convert.ToInt32(pkHeight);
                Console.WriteLine("Please enter package length:");
                string pkLength = Console.ReadLine();
                int packageLength = Convert.ToInt32(pkLength);
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int quote = (packageWidth * packageHeight * packageLength) * packageWeight / 100;
                    decimal amount = Convert.ToDecimal(string.Format("{0:.00}", quote));
                    Console.WriteLine("It will cost $" + amount + " to ship your package today!");
                }
            }
        }
    }
}   