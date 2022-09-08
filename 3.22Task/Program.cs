using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._22Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. В нём зачеркнули первую слева цифру и приписали её в конце.
            // Найти полученное число.

            Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int firstNumber = number / 100;

            int decNumber = number % 100 / 10;

            int unitNumber = number % 100 % 10;

            int res = decNumber * 100 + unitNumber * 10 + firstNumber;

            Console.WriteLine($"В числе {number} зачеркнули первую цифру и приписали её в конце, тем самым получили {res}");
        }
    }
}
