using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._03aTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a");

            double a = double.Parse(Console.ReadLine());

            double moduleNumber = Math.Abs(3 * a); // Модуль числа 3 * a

            double sinNumber = Math.Sin(moduleNumber); // Вычисление sin|3 * a|

            double divisible = 2 * a + sinNumber; //Вычисление делимого 2a + sin|3a|

            double res = Math.Sqrt(divisible / 3.56); // Вычисление квадратного корня из дроби

            Console.WriteLine(res);
        }
    }
}
