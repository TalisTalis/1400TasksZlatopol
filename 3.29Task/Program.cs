using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._29Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное n (n > 9). Найти:
            // число единиц в нём
            // число десятков в нём

            Console.Write("Введите натуральное число больше 9: ");

            int number = int.Parse(Console.ReadLine());

            int unitNumber = number % 10;

            int decNumber = number / 10 % 10;

            Console.WriteLine($"В числе {number}: {unitNumber} единиц, {decNumber} десятков");
        }
    }
}
