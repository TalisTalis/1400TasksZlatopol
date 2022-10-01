using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._69Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Имеется стол прямоугольной формы с размерами a x b (a и b - целые числа, a > b) и кости 
            // домино с размерами c x d x e (c, d и e - целые числа, c > d > e).
            // Найти вариант размещения на столе наибольшего количества костей.
            // Все размещаемые кости должны лежать на одной и той же грани в один ярус без свешивания 
            // со стола. Все ребра костей домино должны быть параллельны или перпендикулярны каждой стороне стола

            Console.Write("Введите длину стола a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину стола b: ");

            int b = int.Parse(Console.ReadLine());

            int quareTable = a * b;

            Console.Write("Ввведите длину домино c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Ввведите ширину домино d: ");

            int d = int.Parse(Console.ReadLine());

            Console.Write("Ввведите высоту домино e: ");

            int e = int.Parse(Console.ReadLine());

            if (a / d * b / c > a / c * b / d)
            {
                Console.WriteLine("Наибольшее количество костей при размещении d на c.");
            }
            else if (a / c * b / d > a / e * b / d)
            {
                Console.WriteLine("Наибольшее количество костей при размещении c на d.");
            }
            else if (a / e * b / d > a / e * b / c)
            {
                Console.WriteLine("Наибольшее количество костей при размещении e на d.");
            }
            else
            {
                Console.WriteLine("Наибольшее количество костей при размещении e на c.");
            }
        }
    }
}
