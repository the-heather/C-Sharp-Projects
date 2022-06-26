using System;
using System.Collections.Generic;
using System.Text;

namespace UsingGenerics
{
    class Employee<T>
    {
      public List<T> Things { get; set; }
    }
}
