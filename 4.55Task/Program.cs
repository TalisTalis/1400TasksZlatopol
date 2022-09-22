using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._55Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано четырёхзначное число. Определить:
            // входят ли в него цифры 2 или 7
            // входят ли в него цифры 3, 6 или 9

            Console.Write("Введите четырёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            string str = n.ToString();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)(n / Math.Pow(10, str.Length - (1 + i))) % 10 == 2 ||
                    (int)(n / Math.Pow(10, str.Length - (1 + i))) % 10 == 7)
                {
                    Console.WriteLine("В число входят цифры 2 или 7.");
                    break;
                }

                count++;

                if (count == 4)
                {
                    Console.WriteLine("В число не входят цифры 2 или 7.");
                }
            }

            count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)(n / Math.Pow(10, str.Length - (1 + i))) % 10 == 3 ||
                    (int)(n / Math.Pow(10, str.Length - (1 + i))) % 10 == 6 ||
                    (int)(n / Math.Pow(10, str.Length - (1 + i))) % 10 == 9)
                {
                    Console.WriteLine("В число входят цифры 3, 6 или 9.");
                    break;
                }

                count++;

                if (count == 4)
                {
                    Console.WriteLine("В число не входят цифры 3, 6 или 9.");
                }
            }
        }
    }
}
