using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._41Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его последнюю цифру.
            // Когда в оставшемся двузначном числе переставили цифры,
            // а затем приписали к ним слева последнюю цифру числа x,
            // то получилось число n. 
            // По заданному n найти число x (значение n вводится с клавиатуры,
            // 1 <= n <= 999, и при этом число единиц в n не равно нулю)

            Console.Write("Введите число n от 1 до 999, но еденицы не должны быть равны нулю: ");

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 999 || n % 10 == 0)
            {
                Console.WriteLine("Число вне диапазона или единицы числа равны нулю");
                return;
            }

            int x = (n % 10) * 100 + (n / 10 % 10) * 10 + n / 100;

            Console.WriteLine($"Число {n} получено перестановкой последней цифры числа {x} в начало и перестановки двух цифр");
        }
    }
}
