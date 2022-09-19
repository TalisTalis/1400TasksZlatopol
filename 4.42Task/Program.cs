using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._42Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, попадает ли точка с заданными координатами в область I.
            // Для простоты принять, что точка не попадает на границу этой области.

            Console.Write("Введите значение координату x: ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите значение координату y: ");

            int y = int.Parse(Console.ReadLine());

            if (x > 2 && y > 2)
            {
                Console.WriteLine($"Точка с координатами x = {x}, y = {y} входит в область I.");
            }
            else
            {
                Console.WriteLine("Точка не входит в область I.");
            }
        }
    }
}
