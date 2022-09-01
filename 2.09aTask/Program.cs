using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._09aTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2x^3 - 3.44xy + 2.3x^2 - 7.1y + 2
            
            double x, y, z;

            x = 5;

            y = 2;

            double firstArgument = 2 * Math.Pow(x, 3); // 2x^3

            double secondArgument = -(3.44 * x * y); // - 3.44xy

            double thirdArgument = 2.3 * Math.Pow(x, 2); // 2.3x^2

            double fourthArgument = -(7.1 * y); // -7.1y 

            z = firstArgument + secondArgument + thirdArgument + fourthArgument + 2;

            Console.WriteLine(z);
        }
    }
}
