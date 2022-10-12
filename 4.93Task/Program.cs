using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._93Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число k (1 ≤ k ≤ 365).
            // Определить, каким будет k - й день года: субботой, воскресеньем или рабочим днем,
            // если 1 января:
            // а) понедельник;
            // б) d - й день недели(если 1 января – понедельник, то d = 1,
            // если вторник – d = 2, ..., если воскресенье – d = 7).
            // Замечание
            // В задачах 4.94–4.97 величины строкового типа не использовать.

            Console.Write("Введите k (от 1 до 365): ");

            int k = int.Parse(Console.ReadLine());

            Console.Write("Введите день недели d: ");

            int d = int.Parse(Console.ReadLine());

            if ((k - 1 + d) % 7 == 0)
            {
                Console.WriteLine("Воскресенье.");
            }
            else if ((k - 1 + d) % 6 == 0)
            {
                Console.WriteLine("Суббота.");
            }
            else
            {
                Console.WriteLine("Рабочий день.");
            }
        }
    }
}
