using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 10\n7 см");

            Console.WriteLine("Введите число t");

            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число v");

            int v = int.Parse(Console.ReadLine());

            Console.WriteLine($"100 {t}\n1949 {v}");

            Console.WriteLine("Введите число x");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число y");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} 25\n{x} {y}");
        }
    }
}
