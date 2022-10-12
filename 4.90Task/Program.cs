using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._90Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дата некоторого дня определяется двумя натуральными числами: m(порядковый номер месяца) и n(число).
            // По заданным n и m определить:
            // а) дату предыдущего дня(принять, что n и m не определяют 1 января);
            // б) дату следующего дня(принять, что n и m не определяют 31 декабря).
            // Примечание: В обеих задачах принять также, что год не является високосным.

            Console.Write("Введите номер месяца m: ");

            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число n: ");

            int n = int.Parse(Console.ReadLine());

            int previousDay = n - 1;
            int previousMonth = m;

            int nextDay = n + 1;
            int nextMonth = m;

            if (n - 1 == 0)
            {
                previousMonth = m - 1;
                
                if (previousMonth == 2)
                {
                    previousDay = 28;
                }

                if (previousMonth == 7)
                {
                    previousDay = 31;
                }

                if ((previousMonth % 2 == 0 && previousMonth < 7) || 
                    (previousMonth % 2 == 1 && previousMonth > 7))
                {
                    previousDay = 30;
                }
                else
                {
                    previousDay = 31;
                }
            }

            Console.WriteLine($"Дата предыдущего дня: {previousDay}.{previousMonth}");

            
            if ((m == 2 && n % 28 == 0) || 
                (m < 7 && (n % 30 == 0 || n % 31 == 0)) || 
                (m == 7 && n % 31 == 0) ||
                (m > 7 && (n % 31 == 0 || n % 30 == 0)))
            {
                nextDay = 1;

                nextMonth = m + 1;
            }
            else
            {
                nextDay = n + 1;

                nextMonth = m;
            }

            Console.WriteLine($"Дата следующего дня: {nextDay}.{nextMonth}");
        }
    }
}
