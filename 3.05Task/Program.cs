using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._05Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дан прямоугольник с размерами 543х130 мм. Сколько квадратов со стороной 130 мм
            // можно отрезать от него.

            int quad = 543;

            int box = 130;

            int numberCuts = quad / box;

            Console.WriteLine($"От прямоугольника 543х130 мм можно отрезать {numberCuts} квадрата со стороной 130 мм");
        }
    }
}
