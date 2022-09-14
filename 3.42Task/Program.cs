using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._42Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух чисел: двузначного a2a1 и однозначного b,
            // где a1 - число единиц, a2 - число десятков.
            // Получить цифры числа, равного сумме заданных чисел (известно, что это
            // число двузначное).
            // Слагаемое - двузначное число и число-результат не определять;
            // условный оператор не использовать

            Console.Write("Введите число единиц a1: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите число десятков a2: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число b1: ");

            int b1 = int.Parse(Console.ReadLine());

            int c1 = (a1 + b1) % 10; // вычисление числа единиц числа суммы двух чисел

            int c2 = a2 + (a1 + b1) / 10; // вычисление числа десятков числа суммы двух чисел

            Console.WriteLine($"Цифры числа, равного сумме чисел {a2 * 10 + a1}, {b1}, - {c2} и {c1}");
        }
    }
}
