using System;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Multi(34, 25); //calling method
            Math.Multi(firstNum: 47, secondNum: 25); //calling method with named parameters.

        }
        }
}
