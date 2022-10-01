using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._70Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число k (1 <= k <= 365)
            // Определить, каким будет k-й день года: выходным (суббота и воскресенье) или рабочим, 
            // если 1 января - понедельник

            Console.Write("Введите число k от 1 до 365: ");

            int k = int.Parse(Console.ReadLine());

            if (k % 7 == 0 || k % 7 == 6)
            {
                Console.WriteLine($"{k}-й день выходной.");
            }
            else
            {
                Console.WriteLine($"{k}-й день рабочий.");
            }
        }
    }
}
