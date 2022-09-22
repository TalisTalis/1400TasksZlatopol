using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._44Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, попадает ли точка с заданными координатами в одну из областей I или III.
            // Для простоты принять, что точка  не попадает на границу этих областей.

            Console.Write("Введите координату x = ");

            int x = int.Parse(Console.ReadLine());

            if (x < -1)
            {
                Console.WriteLine("Точка входит в область I.");
            }
            else if (x > 5)
            {
                Console.WriteLine("Точка входит в область III.");
            }
            else
            {
                Console.WriteLine("Точка не входит в область I или III.");
            }
        }
    }
}
