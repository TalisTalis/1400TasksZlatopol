using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._74Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1, где
            // a1, b1 - число единиц, a2, b2 - число десятков. 
            // Получить цифры числа, равного разности заданных чисел 
            // (известно, что это число двузначное).
            // Число-уменьшаемое, число-вычитаемое и число-разность не определять.

            Console.Write("Введите число единиц первого числа: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков первого числа: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число единиц второго числа: ");

            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков второго числа: ");

            int b2 = int.Parse(Console.ReadLine());

            int c1, c2;

            if (b1 < a1)
            {
                c1 = a1 - b1;

                c2 = a2 - b2;
            }
            else
            {
                c1 = a1 + 10 - b1;

                c2 = a2 - 1 - b2;
            }

            Console.WriteLine($"Цифры числа равного разности чисел {a2}{a1} и {b2}{b1} равны {c2} и {c1}.");
        }
    }
}
