using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._44Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух десятичныхцелых чисел, трёхзначного
            // a3a2a1 и двузначного b2b1, где a1 и b1 - число единиц, a2 и b2 - число десятков, a3 - число сотен.
            // Получить цифры числа, равного сумме заданных чисел (известно, что это число трёхзначное)
            // Числа-слагаемые и число-результат не определять; условный оператор не использовать

            Console.Write("Введите число сотен a3: ");

            int a3 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков a2: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число единиц a1: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков b2: ");

            int b2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число единиц b1: ");

            int b1 = int.Parse(Console.ReadLine());

            int c1 = (a1 + b1) % 10;

            int c2 = (a2 + b2) % 10 + (a1 + b1) / 10;

            int c3 = a3 + (a2 + b2) % 10 + (a1 + b1) / 10;

            Console.WriteLine($"Цифры числа суммы двух чисел: {c3}, {c2}, {c1}");
        }
    }
}
