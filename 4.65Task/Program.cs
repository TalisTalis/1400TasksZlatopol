using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._65Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные положительные числа a, b, c, x, y.
            // Выяснить, пройдёт ли кирпич с ребрами a, b, c в прямоугольное
            // отверстие со сторонами x, y. 
            // Просовывать кирпич в отверстие разрешается только так,
            // чтобы каждое из его ребер было параллельно или перпендикулярно каждой из сторон отверстия

            Console.Write("Введите ребро кирпича a: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите ребро кирпича b: ");

            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите ребро кирпича c: ");

            double c = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону прямоугольника x: ");

            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону прямоугольника y: ");

            double y = double.Parse(Console.ReadLine());

            if (a <= x && b <= y || a <= y && b <= x ||
                b <= x && c <= y || b <= y && b <= x ||
                a <= x && c <= y || a <= x || c <= x)
            {
                Console.WriteLine("Кирпич пройдёт в прямоугольное отверстие.");
            }
            else
            {
                Console.WriteLine("Кирпич не пройдёт.");
            }
        }
    }
}
