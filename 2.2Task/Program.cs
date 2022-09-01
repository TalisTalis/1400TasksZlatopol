using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a");

            double a = double.Parse(Console.ReadLine());

            double squareNumber = Math.Pow(a, 2); // Квадрат числа а

            double divisible = squareNumber + 10; // Вычисление делимого

            Console.WriteLine(divisible);

            double divider = Math.Sqrt(squareNumber + 1); // Вычисление делителя

            Console.WriteLine(divider);

            double res = divisible / divider; // Результат 

            Console.WriteLine(res);
        }
    }
}
