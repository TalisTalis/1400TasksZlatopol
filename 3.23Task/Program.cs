using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._23Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. В нём зачеркнули последнюю справа цифру и приписали её в начале.
            // Найти полученное число.

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int hundrNumber = number / 100;

            int decNumber = number % 100 / 10;

            int lastNumber = number % 100 % 10;

            int res = lastNumber * 100 + hundrNumber * 10 + decNumber;

            Console.WriteLine($"В числе {number} зачеркнули последнюю справа цифру и приписали её в начале, получив число {res}");
        }
    }
}
