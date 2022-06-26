using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public int Q { get; private set; }

        public void Quit()
        {
            Q = 3;
        }

        public override void SayName()
        {
            // Calling the base class SayName method:
            base.SayName();        }
    }
}
