using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._40Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Проверить принадлежит ли число, введеное с клавиатуры, интервалу (-5, 3)

            Console.Write("Введите число: ");

            int a = int.Parse(Console.ReadLine());

            if (a < 3 && a > -5)
            {
                Console.WriteLine("Число входит в интервал (-5, 3).");
            }
            else
            {
                Console.WriteLine("Число не входит в интервал.");
            }
        }
    }
}
