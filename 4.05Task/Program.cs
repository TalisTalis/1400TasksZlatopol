using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._05Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, в какую из областей - I или II - попадает точка 
            // с заданными координатами. Для простоты принять, что точка 
            // не попадает на границу областей.

            Console.Write("Ввести координаты y: ");

            int y = int.Parse(Console.ReadLine());

            Console.Write("Ввести координаты x: ");

            int x = int.Parse(Console.ReadLine());

            if (y < 3)
            {
                Console.WriteLine("Точка входит во II область.");
            }
            else
            {
                Console.WriteLine("Точка входит во I область.");
            }
        }
    }
}
