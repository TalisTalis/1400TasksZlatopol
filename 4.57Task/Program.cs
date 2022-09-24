using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._57Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, верно ли, что при делении неотрицательного целого числа a
            // на положительное число b получается остаток, равный одному из двух заданных чисел c или d

            Console.Write("Введите неотрицательное целое число a: ");

            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Число a - отрицательное.");
                return;
            }

            Console.Write("Введите положительное число b: ");

            int b = int.Parse(Console.ReadLine());

            if (b < 0)
            {
                Console.WriteLine("Число b отрицательное.");
                return;
            }

            Console.Write("Введите число c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите число d: ");

            int d = int.Parse(Console.ReadLine());

            if (a % b == c || a % b == d)
            {
                Console.WriteLine("Остаток от деления числа a на число b равен числам c или d.");
            }
            else
            {
                Console.WriteLine("Остаток не равен числам c или d.");
            }
        }
    }
}
