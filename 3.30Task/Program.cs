using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._30Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное n (n > 99). Найти:
            // число десятков в нём
            // число сотен в нём

            Console.Write("Введите натуральное число больше 99: ");

            int number = int.Parse(Console.ReadLine());

            int decNumber = number / 10 % 10;

            int hundrNumber = number / 100 % 10;

            Console.WriteLine($"В числе {number} {decNumber} десятков, {hundrNumber} сотен");
        }
    }
}
