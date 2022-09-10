using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._37Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его вторую цифру.
            // Когда к образованному при этом двузначному числу 
            // слева приписали вторую цифру числа x, то получилось число n.
            // По заданному n найти число x (значение n вводится с клавиатуры,
            // 10 <= n <= 999, и при этом число десятков в n не равно нулю)

            Console.Write("Ввести число n от 10 до 999: ");

            int n = int.Parse(Console.ReadLine());

            if (n < 10 || n > 999 || (n / 10 % 10) == 0)
            {
                Console.WriteLine("Число вне диапазона или число десятков равно нулю!");

                return;
            }

            int x = (n / 10 % 10) * 100 + (n / 100) * 10 + n % 10;

            Console.WriteLine($"Число {n} получено из числа {x}");
        }
    }
}
