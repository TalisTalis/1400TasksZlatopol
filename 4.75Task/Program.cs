using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._75Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух десятичных чисел: трехзначного a3a2a1 и двузначного b2b1, где
            // a1, b1 - число единиц, a2, b2 - число десятков, a3 - число сотен. 
            // Получить цифры, составляющие сумму этих чисел 
            // (известно, что это число трехзначное).
            // Числа-слагаемые и число-сумму не определять.

            Console.Write("Введите число единиц трёхзначного числа: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков трёхзначного числа: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число сотен трёхзначного числа: ");

            int a3 = int.Parse(Console.ReadLine());

            Console.Write("Введите число единиц двузначного числа: ");

            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков двузначного числа: ");

            int b2 = int.Parse(Console.ReadLine());

            int c1 = 0, c2 = 0, c3 = 0;

            if ((a1 + b1) / 10 >= 1 && (a2 + 1 + b2) / 10 >= 1)
            {
                c1 = (a1 + b1) % 10;
                
                c2 = (a2 + 1 + b2) % 10;

                c3 = a3 + 1;
            }
            else if ((a1 + b1) / 10 >= 1 && (a2 + 1 + b2) / 10 < 1)
            {
                c1 = (a1 + b1) % 10;

                c2 = a2 + 1 + b2;

                c3 = a3;
            }
            else
            {
                c1 = a1 + b1;

                c2 = a2 + b2;

                c3 = a3;
            }

            Console.WriteLine($"Цифры, составляющие сумму чисел {a3}{a2}{a1} и {b2}{b1}, {c3}, {c2} и {c1}.");
        }
    }
}
