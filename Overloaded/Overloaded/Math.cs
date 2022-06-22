using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded
{
    class Math
    {
        public int numb; //property of class

        public int Calc(int doMath, int userNumb)//addition method
        {               // take var created from math obj and user input as parameters
            // do maths with those vars and store in a new var
            int addAnswer = doMath + userNumb;
            return addAnswer; //return answer 
        }

        public float Calc(int doMath, float userNumbTwo) //subtraction method
        {
            float subAnswer = doMath - userNumbTwo;
            return subAnswer;
        }

        public float Calc(int doMath, string userNumbThree)//multiply method 
        {
            int userInt = Convert.ToInt32(userNumbThree);
            float mAnswer = doMath * userInt;
            return mAnswer;
        }
    }
}
