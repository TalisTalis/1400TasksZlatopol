using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._68Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Год является високосным, если его номер кратен 4,
            // однако из кратных 100 високосных являются лишь кратные 400,
            // например 1700, 1800 и 1900 - не високосные года, 2000 - високосный.
            // Дано натуральное число n.
            // Определить, является ли високосным год с таким номером.

            Console.Write("Введите число n: ");

            int n = int.Parse(Console.ReadLine());

            if (n % 100 == 0)
            {
                if (n % 400 == 0)
                {
                    Console.WriteLine("Год високосный.");
                }
                else
                {
                    Console.WriteLine("Год не високосный.");
                }
            }
            else
            {
                if (n % 4 == 0)
                {
                    Console.WriteLine("Год високосный.");
                }
                else
                {
                    Console.WriteLine("Год не високосный.");
                }
            }
        }
    }
}
