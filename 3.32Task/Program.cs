using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._32Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Из трёхзначного числа x вычли его последнюю цифру.
            // Когда результат разделили на 10. а к частному слева приписали
            // последнюю цирфу числа x, то получилось число 237. 
            // Найти число x.

            int number = 237;

            int x = number / 100;

            int y = number % 100;

            int z = y *  10 + x;

            Console.WriteLine($"Число x = {z}");
        }
    }
}
