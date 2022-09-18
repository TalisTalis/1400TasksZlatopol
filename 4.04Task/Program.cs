using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._04Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, в какую из областей - I или II - попадает
            // точка с заданными координатами. Для простоты принять,
            // что точка не попадает на границу областей.

            Console.Write("Введите координаты y: ");

            int y = int.Parse(Console.ReadLine());

            Console.Write("Введите координаты x: ");

            int x = int.Parse(Console.ReadLine());

            if (x < 4)
            {
                Console.WriteLine($"Точка с координатами y: {y} и x: {x} входит в I область.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами y: {y} и x: {x} входит во II область.");
            }
        }
    }
}
