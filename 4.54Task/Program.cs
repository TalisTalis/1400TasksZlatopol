using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._54Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано четырёхзначное число. Определить:
            // входит ли в него цифра 4
            // входит ли в него цифра b

            Console.Write("Введите чертырёхзначное число: ");

            int a = int.Parse(Console.ReadLine());

            string str = a.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)(a / Math.Pow(10, str.Length - (1 + i))) % 10 == 4)
                {
                    Console.WriteLine("В число входит цифра 4.");
                    break;
                }
            }

            Console.Write("Введите цифру b: ");

            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)(a / Math.Pow(10, str.Length - (1 + i))) % 10 == b)
                {
                    Console.WriteLine("В число входит цифра b.");
                    break;
                }
            }
        }
    }
}
