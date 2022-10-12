using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._91Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дата некоторого дня определяется тремя натуральными числами: g(год), m(порядковый номер месяца) и n(число).
            // По заданным g, n и m определить:
            // а) дату предыдущего дня;
            // б) дату следующего дня.
            // В обеих задачах рассмотреть два случая:
            // 1) заданный год не является високосным;
            // 2) заданный год может быть високосным(см.задачу 4.68).

            Console.Write("Введите год g: ");

            int g = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца m: ");

            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число n: ");

            int n = int.Parse(Console.ReadLine());

            int prevDay = 0;

            int prevMonth = 0;

            int prevYear = 0;

            int nextDay = 0, nextMonth = 0, nextYear = 0;

            if (n - 1 == 0)
            {
                prevMonth = m - 1;

                if (prevMonth == 2)
                {
                    if ((g % 100 == 0 && g % 400 == 0) || (g % 100 != 0 && g % 4 == 0))
                    {
                        prevDay = 29;
                    }
                    else
                    {
                        prevDay = 28;
                    }
                }
                else if (prevMonth == 0)
                {
                    prevMonth = 12;

                    prevDay = 31;

                    prevYear = g - 1;
                }
                else if (prevMonth < 7)
                {
                    if (prevMonth % 2 == 0)
                    {
                        prevDay = 30;
                    }
                    else
                    {
                        prevDay = 31;
                    }
                }
                else if (prevMonth == 7)
                {
                    prevDay = 31;
                }
                else if (prevMonth > 7)
                {
                    if (prevMonth % 2 == 0)
                    {
                        prevDay = 31;
                    }
                    else
                    {
                        prevDay = 30;
                    }
                }
            }
            else
            {
                prevDay = n - 1;

                prevMonth = m;

                prevYear = g;
            }

            Console.WriteLine($"{prevDay}.{prevMonth}.{prevYear}");

            if (n == 31 && m == 12)
            {
                nextMonth = 1;

                nextYear = g + 1;

                nextDay = 1;
            }
            else if (n == 31 && ((m < 7 && m % 2 == 0) || m == 7 || (m > 7 && m % 2 == 1)))
            {
                nextDay = 1;
            }
            else if (n == 29 && m == 2)
            {
                if ((g % 100 == 0 && g % 400 == 0) || (g % 100 != 0 && g % 4 == 0))
                {
                    nextDay = 1;

                    nextMonth = m + 1;
                }
                else
                {
                    nextDay = 1;
                }
            }

            Console.WriteLine($"{nextDay}.{nextMonth}.{nextYear}");
        }
    }
}
