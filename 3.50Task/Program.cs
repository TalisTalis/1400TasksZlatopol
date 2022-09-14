using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._50Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны целые числа h, m (0 < h <= 12, 0 <= m <= 59),
            // указывающие момент времени: "h часов, m минут".
            // Определить наименьшее время (число полных минут),
            // которое должно пройти до того момента,
            // когда часовая и минутная стрелки на циферблате:
            // совпадут
            // распаложатся перпендикулярно друг другу

            Console.Write("Введите количество часов h (от 0 до 12): ");

            int h = int.Parse(Console.ReadLine());

            Console.Write("Введите количество часов m (от 0 до 59): ");

            int m = int.Parse(Console.ReadLine());

            int alphaH = h * 30 + m / 2;

            int alphaM = m * 6;

            int a = (h * 30 + m * 6) / 360; // определение была встреча или нет

            int b = 5 * h - m + (h - 1) / 2;

            double t = (h + a) * 30 / 5.5 - m + 60 * a;

            double d = ((b / Math.Abs(b)) + 1) / 2;

            double n = b + 65 * (1 - d);

            Console.WriteLine($"Стрелки часов совпадут через {Math.Round(t,0)} минут");

            Console.WriteLine($"Стрелки распаложаться перпендикулярно друг другу через {Math.Round(n,0)}");
        }
    }
}
