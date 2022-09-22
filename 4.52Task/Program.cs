using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._52Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Определить, входит ли в него цифра 6

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            if (n / 100 == 6 || n % 10 / 10 == 6 || n % 10 == 6)
            {
                Console.WriteLine("В число входит цифра 6.");
            }
            else
            {
                Console.WriteLine("В число не входит цифра 6.");
            }
        }
    }
}
