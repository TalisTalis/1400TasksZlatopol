using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны площади круга и квадрата. Определить:
            // уместится ли круг в квадрате?
            // уместится ли квадрат в круге

            Console.Write("Введите площадь квадрата: ");

            int squareBox = int.Parse(Console.ReadLine());

            Console.Write("Введите площадь курга: ");

            int squareCircle = int.Parse(Console.ReadLine());

            float sideBox = squareBox / 2;

            double radius = squareCircle / (2 * Math.PI);

            if (2 * radius <= sideBox)
            {
                Console.WriteLine("Круг уместится в квадрате.");
            }
            else
            {
                Console.WriteLine("Круг не уместится в квадрат.");
            }

            if (sideBox <= 2 * radius)
            {
                Console.WriteLine("Квадрат уместится в кругe.");
            }
            else
            {
                Console.WriteLine("Квадрат не уместится в кругe.");
            }
        }
    }
}
