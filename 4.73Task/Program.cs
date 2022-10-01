using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._73Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух чисел: двузначного a2a1 и одногозначного b, где 
            // a1 - число единиц, a2 - число десятков. 
            // Получить цифры числа, равного разности заданных чисел 
            // (известно, что это число двузначное).
            // Число-уменьшаемое и число-разность не определять.

            Console.Write("Введите число единиц двузначного числа: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков двузначного числа: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите однозначное число: ");

            int b = int.Parse(Console.ReadLine());

            int c1, c2;

            if (b < a1)
            {
                c1 = a1 - b;

                c2 = a2;
            }
            else
            {
                c1 = a1 + 10 - b;

                c2 = a2 - 1;
            }

            Console.WriteLine($"Цифры числа равного разности чисел {a2}{a1} и {b} равны {c2} и {c1}.");
        }
    }
}
