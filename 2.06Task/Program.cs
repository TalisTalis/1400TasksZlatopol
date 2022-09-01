using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._07Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3; // Длина ребра куба

            double volumeCub = Math.Pow(a, 3); // Объём куба V = a^3

            double squareSurfaceCub = 4 * Math.Pow(a, 2); // Площадь боковой поверхности куба S = 4 * a^2            
            
            Console.WriteLine("Объём куба при длине ребра " + a + " равен " + volumeCub);

            Console.WriteLine("Площадь боковой поверхности куба при длине ребра " + a + " равна " + squareSurfaceCub);
        }
    }
}
