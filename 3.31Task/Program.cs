using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._31Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное n (n > 999). Найти:
            // число сотен в нём
            // число тысяч в нём

            Console.Write("Введите число больше 999: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100 % 10;

            int thousandNumber = number / 1000 % 10;

            Console.WriteLine($"В числе {number}: {hundrNumber} сотен, {thousandNumber} тысяч");
        }
    }
}
