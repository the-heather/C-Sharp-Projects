using System;
using System.IO;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Please enter a number: ");
                string value = Convert.ToString(Console.ReadLine());
                using (StreamWriter file = new StreamWriter(@"C:\Users\Admin\Documents\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(value);
                }
                string txtFile = File.ReadAllText(@"C:\Users\Admin\Documents\log.txt");
                Console.WriteLine(txtFile);
            }
        }
    }
}
