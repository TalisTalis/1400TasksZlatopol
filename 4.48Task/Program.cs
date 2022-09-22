using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._48Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два целых числа. Определить, является ли хотя бы 
            // одно из них делителем другого

            Console.Write("Введите число a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");

            int b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("Число b является делителем числа a.");
            }
            else if (b % a == 0)
            {
                Console.WriteLine("Число a является делителем числа b.");
            }
            else
            {
                Console.WriteLine("Ни одно из чисел не является делителем.");
            }
        }
    }
}
