using System;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "i ";
            string b = "love ";
            string c = "c#";
            Console.WriteLine(a + b + c);
            string join = a + b + c;
            string upper = join.ToUpper();
            Console.WriteLine(upper);

            // "40" is capacity
            StringBuilder s = new StringBuilder();
            // a new line append
            s.AppendLine("I do not like them in a house.");
            s.AppendLine("I do not like them with a mouse.");
            s.AppendLine("I do not like them here or there.");
            s.AppendLine("I do not like them anywhere.");
            s.AppendLine("I do not like green eggs and ham.");
            s.AppendLine("I do not like them, Sam - I - Am.");
            Console.WriteLine(s);
        }
    }
}
