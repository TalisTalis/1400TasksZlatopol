using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _4._101Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны три различных вещественных числа.
            // Не используя полный условный оператор, определить:
            // а) наибольшее из них;
            // б) наименьшее из них.

            Console.Write("Введите первое число: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");

            double c = double.Parse(Console.ReadLine());

            double min, max;

            max = a;

            if (b > c)
            {
                max = b;
            }

            if (c > a)
            {
                max = c;
            }

            Console.WriteLine($"Наибольшее число {max}");

            min = a;

            if (a > b)
            {
                min = b;
            }

            if (b > c)
            {
                min = c;
            }

            Console.WriteLine($"Наименьшее число {min}");
        }
    }
}
