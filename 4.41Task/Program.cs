using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._41Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное число. Определить, является ли оно двузначным.

            Console.Write("Введите число: ");

            int a = int.Parse(Console.ReadLine());

            if (a / 10 > 0 && a / 100 == 0)
            {
                Console.WriteLine("Число двузначное.");
            }
            else
            {
                Console.WriteLine("Число не двузначное.");
            }
        }
    }
}
