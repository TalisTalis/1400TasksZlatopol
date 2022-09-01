using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._03bTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");

            double x = double.Parse(Console.ReadLine());

            double modulePath = Math.Abs(5 * x);

            double squarePath = Math.Sqrt(1 + x);

            double divisible = 3.2 + squarePath;

            double res = Math.Sin(divisible / modulePath);

            Console.WriteLine(res);
        }
    }
}
