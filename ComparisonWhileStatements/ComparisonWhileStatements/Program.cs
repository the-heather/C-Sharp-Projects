using System;

namespace ComparisonWhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0; // initialization

            while (true) // while condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment

                if (i > 5)
                    break; //exit loop
            }

            int n = 0; // initialization

            do // do while loop executes the code block at least once
            {
                Console.WriteLine("n = {0}", n);
                n++; // increment

            } while (n < 5); //condition
        }
    }
}
