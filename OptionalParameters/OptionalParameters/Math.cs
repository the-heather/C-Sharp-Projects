using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Math
    {
        public static int Multi(int numOne, int numTwo = 0)//multiply method 
        {
            int mAnswer = numOne * numTwo;
            return mAnswer;
        }
    }
}
