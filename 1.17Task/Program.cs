using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число x");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число y");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("2 кг\n13 17");

            Console.WriteLine();

            Console.WriteLine($"{a} 1\n19 {b}");

            Console.WriteLine();

            Console.WriteLine($"{x} {y}\n5 {y}");
        }
    }
}
