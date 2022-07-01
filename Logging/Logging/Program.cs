using System;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string value = Convert.ToString(Console.ReadLine());
            Console.WriteLine(value);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Admin\Documents\log.txt", true))
            {
                file.WriteLine(value);
            }

        }
    }
}
