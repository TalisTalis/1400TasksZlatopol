using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._09bTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.14(a + b)^3 + 2.75b^2 - 12.7a - 4.1

            double a = 4, b = 1;

            double firstArgument = 3.14 * Math.Pow((a + b), 3); // 3.14(a + b)^3

            double secondArgument = 2.75 * Math.Pow(b, 2); // 2.75b^2

            double thirdArgument = -12.7 * a; // -12.7a

            double x = firstArgument + secondArgument + thirdArgument - 4.1;

            Console.WriteLine(x);
        }
    }
}
