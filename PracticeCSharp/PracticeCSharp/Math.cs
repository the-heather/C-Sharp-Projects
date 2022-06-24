using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Math
    {
        public static void Divide(int number1, out int result)
        {
            result = number1 / 2;
        }

        public static void Divide(int userNum, out float userResult)
        {
            userResult = userNum / 2;
            Console.WriteLine("The answer is: " +(userNum, userResult));
        }
    }
}


