using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны радиус круга и сторона квадрата.
            // У какой фигуры площадь больше?

            Console.Write("Введите радиус круга: ");

            int radius = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону квадрата: ");

            int box = int.Parse(Console.ReadLine());

            double squareCircle = 2 * Math.PI * radius;

            double squareBox = Math.Pow(box, 2);

            if (squareCircle > squareBox)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
        }
    }
}
