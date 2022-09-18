using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._19Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны площади круга и равностороннего треугольника. Определить:
            // уместится ли круг в треугольнике?
            // уместится ли треугольник в круге?

            Console.Write("Введите площадь круга: ");

            int squareCircle = int.Parse(Console.ReadLine());

            Console.Write("Введите площадь равностороннего треугольника: ");

            int squareTriangle = int.Parse(Console.ReadLine());

            double radiusCircle = squareCircle / 2 * Math.PI;

            double sideTriangle = Math.Sqrt(4 * squareTriangle / Math.Sqrt(3));

            double RadiusTriangle = sideTriangle * Math.Sqrt(3) / 3;

            double radiusTriangle = sideTriangle * Math.Sqrt(3) / 6;

            if (radiusCircle <= radiusTriangle)
            {
                Console.WriteLine("Круг уместится в треугольнике.");
            }
            else
            {
                Console.WriteLine("Круг не уместится в треугольнике");
            }

            if (radiusCircle >= RadiusTriangle)
            {
                Console.WriteLine("Треугольник уместится в круге");
            }
            else
            {
                Console.WriteLine("Треугольник не уместится в круге.");
            }
        }
    }
}
