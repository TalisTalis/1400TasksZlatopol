using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._26Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить:
            // какия из его цифр больше: первая или вторая
            // одинаковы ли его цифры

            Console.Write("Введите двузначное число: ");

            int a = int.Parse(Console.ReadLine());

            if (a / 10 > a % 10)
            {
                Console.WriteLine("Первая цифра больше.");
            }
            else if (a / 10 < a % 10)
            {
                Console.WriteLine("Вторая цифра больше.");
            }

            if (a / 10 == a % 10)
            {
                Console.WriteLine($"В числе {a} цифры одинаковы.");
            }
            else
            {
                Console.WriteLine($"В числе {a} цифры не одинаковы.");
            }
        }
    }
}
