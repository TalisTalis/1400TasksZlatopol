using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._06Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Считая, что Земля - идеальная сфера с радиусом R = 6350 км, определить расстояние до линии горизонта
            // от точки с заданной высотой над Землей
            // Расстояние от точки до линии горизонта - это катет прямоугольного треугольника со сторонами
            // один катет - R и гипотенуза R + h 
            // c = sqrt ((R + h)^2 - R^2)

            double h = 0.00188;

            double R = 6350;

            double c = Math.Sqrt(Math.Pow((R + h), 2) - Math.Pow(R, 2));

            Console.WriteLine("Расстояние до линии горизонта от точки с заданной высотой над  Землёй = " + c);
        }
    }
}
