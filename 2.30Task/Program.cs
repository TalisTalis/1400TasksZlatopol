using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._30Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырёхугольника как сумму
            // площадей треугольников

            int x1 = 1, y1 = 2;

            int x2 = 4, y2 = 8;

            int x3 = 6, y3 = 9;

            int x4 = 7, y4 = 1;

            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"Длина стороны a = {a}");

            double b = Math.Sqrt(Math.Pow((x4 - x2), 2) + Math.Pow((y4 - y2), 2));

            Console.WriteLine($"Длина стороны b = {b}");

            double c = Math.Sqrt(Math.Pow((x4 - x1), 2) + Math.Pow((y4 - y1), 2));

            Console.WriteLine($"Длина стороны c = {c}");

            double d = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

            Console.WriteLine($"Длина стороны d = {d}");

            double e = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            Console.WriteLine($"Длина стороны e = {e}");

            double Pabc = (a + b + c) / 2;

            double Pbde = (b + d + e) / 2;

            double Sabc = Math.Sqrt(Pabc * (Pabc - a) * (Pabc - b) * (Pabc - c));

            Console.WriteLine($"Площадь треугольника ABC Sabc = {Sabc}");

            double Sbde = Math.Sqrt(Pbde * (Pbde - b) * (Pbde - d) * (Pbde - e));

            Console.WriteLine($"Площадь треугольника BDE Sbde = {Sbde}");

            double S = Sabc + Sbde;

            Console.WriteLine($"Площадь выпуклого четырёхугольника S = {S}");
        }
    }
}
