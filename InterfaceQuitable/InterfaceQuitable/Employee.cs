using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceQuitable
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public string Q { get; private set; }

        public void Quit()
        {
            Q = "I quit";
            Console.WriteLine(Q);
        }

        public override void SayName()
        {
            // Calling the base class SayName method:
            base.SayName();
        }
    }
}
