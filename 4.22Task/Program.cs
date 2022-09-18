using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._22Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Если целое число m делится нацело на целое число n, 
            // то вывести на экран частное от деления, в противном случае
            // вывести сообщение "m на n нацело не делится".

            Console.Write("Введите значение m: ");

            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение n: ");

            int n = int.Parse(Console.ReadLine());

            if (m % n == 0)
            {
                Console.WriteLine($"Частное от деления m/n = {m / n}");
            }
            else
            {
                Console.WriteLine("m на n нацело не делится.");
            }
        }
    }
}
