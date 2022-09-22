using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._53Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить:
            // входят ли в него цифры 4 или 7
            // входят ли в него цифры 3, 6 или 9

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            if (n / 100 == 4 || n % 100 / 10 == 4 || n % 10 == 4 ||
                n / 100 == 7 || n % 100 / 10 == 7 || n % 10 == 7)
            {
                Console.WriteLine("В число входят цифры 4 или 7.");
            }
            else
            {
                Console.WriteLine("В число не входят цифры 4 или 7.");
            }

            if (n / 100 == 3 || n % 10 / 10 == 3 || n % 10 == 3 ||
                n / 100 == 6 || n % 10 / 10 == 6 || n % 10 == 6 ||
                n / 100 == 9 || n % 10 / 10 == 9 || n % 10 == 9)
            {
                Console.WriteLine("В число входят цифры 3, 6 или 9.");
            }
            else
            {
                Console.WriteLine("В число не входят цифры 3, 6 или 9");
            }
        }
    }
}
