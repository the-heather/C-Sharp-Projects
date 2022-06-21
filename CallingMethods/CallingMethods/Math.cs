using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math //Creating 1st. class
    {
        public int numb; //property of class

        public int Add(int doMath, int userNumb)//addition method
        {               // take var created from math obj and user input as parameters
            // do maths with those vars and store in a new var
            int addAnswer = doMath + userNumb;
            return addAnswer; //return answer 
        }

        public int Sub(int doMath, int userNumb)//subtraction method
        {
            int subAnswer = doMath - userNumb;
            return subAnswer;
        }

        public int Multi(int doMath, int userNumb)//mulitply method 
        {
            int mAnswer = doMath * userNumb;
            return mAnswer;
        }
    }
}
