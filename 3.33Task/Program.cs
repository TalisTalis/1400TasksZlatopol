using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._33Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Из трёхзначного числа x вычли его последнюю цифру.
            // Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x,
            // то получилось число n. Найти число n.

            Console.Write("Введите число x: ");

            int x = int.Parse(Console.ReadLine());

            int n = (x % 10) * 100 + x / 10;

            Console.WriteLine($"Число n = {n}");
        }
    }
}
