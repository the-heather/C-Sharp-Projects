using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            // Calling the base class SayName method:
            base.SayName();        }
    }
}
