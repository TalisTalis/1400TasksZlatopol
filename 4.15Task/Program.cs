using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны коэффициенты a, b и c квадратного уравнения ax^2 + bx + c = 0 (a!=0).
            // Выяснить, имеет это уравнение корни или нет (сами корни, если они есть, вычислять не нужно)

            Console.Write("Введите значение a = ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b = ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c = ");

            int c = int.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0)
            {
                Console.WriteLine("Переменная a не должна быть равна нулю!");

                return;
            }

            if (D >= 0)
            {
                Console.WriteLine("Уравнение ax2 + bx + c = 0 имеет корни.");
            }
            else
            {
                Console.WriteLine("Уравнение корни не имеет.");
            }
        }
    }
}
