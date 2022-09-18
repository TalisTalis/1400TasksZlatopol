using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._08Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Составить программму для вычисления значений функции f(x)

            Console.Write("Введите значение x: ");

            int x = int.Parse(Console.ReadLine());

            int k = 0, f = 0;

            if (Math.Sin(x) >= 0)
            {
                k = (int)Math.Pow(x, 2);
            }
            else if (Math.Sin(x) < 0)
            {
                k = Math.Abs(x);
            }

            if (x >= k)
            {
                f = Math.Abs(x);
            }
            else
            {
                f = k * x;
            }

            Console.WriteLine($"Значение функции f(x) = {f}");
        }
    }
}
