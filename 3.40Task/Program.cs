using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._40Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его последнюю цифру, 
            // Когда в оставшемся двузначному числе переставили цифры,
            // а затем приписали к ним слева последнюю цифру числа x,
            // то получилось число 654. Найти число x

            int n = 654;

            int x = (n % 10) * 100 + (n % 100 / 10) * 10 + n / 100;

            Console.WriteLine($"Число {n} получено из числа {x} перестановкой последней цифры в начало, а двух первых между собой");
        }
    }
}
