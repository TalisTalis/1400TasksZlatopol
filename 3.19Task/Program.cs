using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._19Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, в которую вводится трехзначное число и выводятся на экран
            // его цифры (через запятую).

            Console.Write("Введите трёхзначное число: ");

            int origNumber = int.Parse(Console.ReadLine());

            int unitNumber = origNumber % 100 % 10;

            int decNumber = origNumber % 100 / 10;

            int hundrNumber = origNumber / 100;

            Console.WriteLine($"{hundrNumber}, {decNumber}, {unitNumber}");
        }
    }
}
