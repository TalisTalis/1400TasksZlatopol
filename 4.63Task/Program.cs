using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._63Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, войдет ли в конверт с внутренними размерами a и b мм 
            // прямоугольная открытка с размерами c и d мм.
            // Для размещения открытки в конверте необходим зазор в 1 мм с каждой стороны

            Console.Write("Введите размер конверта a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите размер конверта b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите размер открытки c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите размер открытки d: ");

            int d = int.Parse(Console.ReadLine());

            if (c + 2 <= a && d + 2 <= b || c + 2 <= b && d + 2 <= a)
            {
                Console.WriteLine("Открытка войдет в конверт.");
            }
            else
            {
                Console.WriteLine("Открытка не войдет в конверт.");
            }
        }
    }
}
