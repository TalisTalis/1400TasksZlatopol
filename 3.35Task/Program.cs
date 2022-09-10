using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._35Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули первую цифру.
            // Когда полученное число умножили на 10, а произведение сложили
            // с первой цифрой числа x, то получилось число n. 
            // По заданному n найти число x (значение n вводится с клавиатуры, 1 <= n <= 999).

            Console.Write("Введите число n от 1 до 999: ");

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 999)
            {
                Console.WriteLine("Число вне диапазона!");

                return;
            }

            int x = (n % 10) * 100 + n / 10;

            Console.WriteLine(x);
        }
    }
}
