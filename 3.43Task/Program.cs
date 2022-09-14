using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._43Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны цифры двух двузначных чисел, записываемых в виде
            // a2a1 и b2b1, где a1 и b1 - число единиц, a2 и b2 - число десятков
            // Получить цифры числа, равного сумме заданных чисел (известно, что это двузначное число)
            // Слагаемое - двузначное число и число результат не определять; условный оператор не использовать

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

            Console.WriteLine($"Цифры числа суммы двух чисел: {c2}, {c1}");
        }
    }
}
