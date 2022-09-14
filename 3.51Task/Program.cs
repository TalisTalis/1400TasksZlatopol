using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._51Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два целых числа a и b. Если a делится на b или b делится на a,
            // то вывести 1, иначе - любое другое число.
            // Условные операторы и операторы цикла не использовать

            Console.Write("Введите целое число a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число b: ");

            int b = int.Parse(Console.ReadLine());

            int t = a % b % a + 1;

            Console.WriteLine(t);
        }
    }
}
