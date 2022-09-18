using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны две скорости: одна выражена в километрах в час,
            // другая - в метрах в секунду. Какая из скоростей больше?

            Console.Write("Введите скорость в километрах в час: ");

            float speedKilometr = float.Parse(Console.ReadLine());

            Console.Write("Введите скорость в метрах в секунду: ");

            float speedMetr = float.Parse(Console.ReadLine());

            if (speedKilometr * 10 / 36 > speedMetr)
            {
                Console.WriteLine($"Скорость {speedKilometr}км/ч больше.");
            }
            else
            {
                Console.WriteLine($"Скорость {speedMetr}м/сек больше.");
            }
        }
    }
}
