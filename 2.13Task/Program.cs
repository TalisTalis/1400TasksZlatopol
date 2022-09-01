using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Программа решения линейного уравнения
            // ax + b = 0 (a != 0)

            Console.WriteLine("Программа решения линейного уравнения ax + b = 0");

            Console.Write("Введите коэффициент a = ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите коэффициент b = ");

            double b = double.Parse(Console.ReadLine());

            double x;

            if (a == 0)
            {
                Console.WriteLine("Корней нет!");
            }
            else if (b == 0)
            {
                Console.WriteLine("x = 0!");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Корень решения x = " + x);
            }
        }
    }
}
