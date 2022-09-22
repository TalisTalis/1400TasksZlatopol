using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._50Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить:
            // входят ли в него цифры 4 или 7
            // входят ли в него цифры 3, 6 или 9

            Console.Write("Введите двузначное число: ");

            int n = int.Parse(Console.ReadLine());

            if (n / 10 == 4 || n % 10 == 4 || n / 10 == 7 || n % 10 == 7)
            {
                Console.WriteLine("В число входит цифра 4 или 7");
            }
            else
            {
                Console.WriteLine("В число не входят цифры 4 или 7.");
            }

            if (n / 10 == 3 || n % 10 == 3 || n / 10 == 6 || n % 10 == 6 || n / 10 == 9 || n % 10 == 9)
            {
                Console.WriteLine("В число входит цифра 3, 6 или 9");
            }
            else
            {
                Console.WriteLine("В число не входят цифры 3, 6 или 9.");
            }
        }
    }
}
