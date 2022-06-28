using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SayName()
        {
            string add = FirstName;
            string together = LastName;
            string addtogether = add + " " + together;
            return addtogether;
        }
    }
}
