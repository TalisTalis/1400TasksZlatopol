using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти площадь кольца по заданным внешнему и внутреннему радиусам. S = п(R^2 - r^2)

            double R = 5; // Внешний радиус кольца

            double r = 2; // Внутренний радиус кольца

            double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));

            Console.WriteLine("Площадь кольца S = " + S);
        }
    }
}
