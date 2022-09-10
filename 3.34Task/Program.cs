using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._34Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули первую цифру.
            // Когда оставшееся число умножили на 10, а произведение
            // сложили с первой цифрой числа x, то получилось число 564.
            // Найти число x.

            int a = 564;

            int d = a / 10; // первые две цифры

            int x = (a % 10) * 100 + d; // последнюю цифру переводим в сотки и складываем с получеными двумя цифрами

            Console.WriteLine(x);
        }
    }
}
