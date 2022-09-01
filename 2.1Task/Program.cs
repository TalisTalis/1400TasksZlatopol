using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareNumber;

            Console.WriteLine("Введите значение x");

            int x = int.Parse(Console.ReadLine());

            squareNumber = x * x;

            int firstArgument = 17 * squareNumber;

            int secondArgument = - (6 * x);

            int y = firstArgument + secondArgument + 13;

            Console.WriteLine("17 * x^2 - 6 * x + 13 = " + y);

            Console.WriteLine("Введите значение a");

            int a = int.Parse(Console.ReadLine());

            squareNumber = a * a;

            firstArgument = 3 * squareNumber;

            secondArgument = 5 * squareNumber;

            y = firstArgument + secondArgument - 21;

            Console.WriteLine("3 * a^2 + 5 * a - 21 = " + y);

        }
    }
}
