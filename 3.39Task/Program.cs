using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._39Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его вторую цифру.
            // Когда к образованному при этом двузначному числу справа
            // приписали вторую цифру числа x, то получилось число n.
            // По заданному n найти число x (значение n вводится с клавиатуры, 100 <= n <= 999)

            Console.Write("Введите число n от 100 до 999: ");

            int n = int.Parse(Console.ReadLine());

            if (n < 100 || n > 999)
            {
                Console.WriteLine("Число вне диапазона!");
                return;
            }

            int x = (n / 100) * 100 + (n % 10) * 10 + n % 100 / 10;

            Console.WriteLine($"Число {n} получено из числа {x} перестановкой второй цифры в конец");
        }
    }
}
