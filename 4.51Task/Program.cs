using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._51Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить:
            // входит ли в него цифра 6
            // входит ли в него цифра n

            Console.Write("Введите трёхзначное число: ");

            int a = int.Parse(Console.ReadLine());

            if (a / 100 == 6 || a % 100 / 10 == 6 || a % 10 == 6)
            {
                Console.WriteLine("В число входит цифра 6.");
            }
            else
            {
                Console.WriteLine("В число не входит цифра 6.");
            }

            Console.Write("Введите цифру n: ");

            int n = int.Parse(Console.ReadLine());

            if (a / 100 == n || a % 100 / 10 == n || a % 10 == n)
            {
                Console.WriteLine($"В число входит цифра {n}.");
            }
            else
            {
                Console.WriteLine($"В число не входит цифра {n}.");
            }
        }
    }
}
