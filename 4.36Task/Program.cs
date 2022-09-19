using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._36Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное число:
            // верно ли, что оно заканчивается четной цифрой
            // верно ли, что оно заканчивается нечётной цифрой

            Console.Write("Введите число: ");

            int n = int.Parse(Console.ReadLine());

            if (n % 10 % 2 == 0)
            {
                Console.WriteLine("Число заканчивается на чётную цифру.");
            }

            if (n % 10 % 2 == 1)
            {
                Console.WriteLine("Число заканчивается на нечётную цифру.");
            }
        }
    }
}
