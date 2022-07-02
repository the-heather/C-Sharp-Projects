using System;
using System.IO;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number: ");
            // store input in value varable
            int value = Convert.ToInt32(Console.ReadLine());
            //store current datetime in varable
            DateTime dt = DateTime.Now;
            // store a new time span equal to user input (hrs, mins, secs)
            TimeSpan ts = new TimeSpan(value, 0, 0);
            // add timespan to current time
            DateTime value2 = dt.Add(ts);
            Console.WriteLine(value2);
        }
    }
}
