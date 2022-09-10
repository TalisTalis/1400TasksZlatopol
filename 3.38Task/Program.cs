using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._38Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его вторую цифру.
            // Когда к образованному при этом двузначному числу справа приписали
            // вторую цифру числа x, то получилось число 456.
            // Найти число x

            int n = 456;

            int x = (n / 100) * 100 + (n % 10) * 10 + n / 10 % 10;

            Console.WriteLine($"Число {n} получено из числа {x} перестановкой второй цифры в конец числа");
        }
    }
}
