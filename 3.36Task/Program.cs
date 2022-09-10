using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._36Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В трёхзначном числе x зачеркнули его вторую цифру. 
            // Когда к образованному при этом двузначному числу слева приписали 
            // вторую цифру числа x, то получилось число 546. 
            // Найти число x.

            int n = 546;

            int x = (n / 10 % 10) * 100 + (n / 100) * 10 + n % 10;

            Console.WriteLine(x);
        }
    }
}
