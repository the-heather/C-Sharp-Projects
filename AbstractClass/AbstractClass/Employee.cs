using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Employee : Person
    {
        public string sayName()
        {
            string add = FirstName;
            string together = LastName;
            string addtogether = add + " " + together;
            return addtogether;
         }
    }
}
