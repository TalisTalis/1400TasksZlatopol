using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._08Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 5; // радиус окружности

            double l = 2 * Math.PI * r; // длина окружности 2пR

            double s = Math.PI * Math.Pow(r, 2); // площадь круга пR^2

            Console.WriteLine("При радиусе окружности " + r + " длина окружности равна " + l);

            Console.WriteLine("При радиусе окружности " + r + " площадь окрудности равна " + s);
        }
    }
}
