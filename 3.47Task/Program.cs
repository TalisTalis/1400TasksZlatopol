using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._47Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны целые числа h, m, s (0 < h <= 23, 0 <= m <= 59, 0 <= s <= 59),
            // указыввающие момент времени: "h часов, m минут, s секунд".
            // Определить угол (в градусах) между положением часовой стрелки в начале суток 
            // и в указанный момент времени

            Console.Write("Введите значение h от 0 до 23: ");

            int h = int.Parse(Console.ReadLine());

            Console.Write("Введите значение m от 0 до 59: ");
            
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение s от 0 до 59: ");

            int s = int.Parse(Console.ReadLine());

            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
            {
                Console.WriteLine("Значения вне диапазона!");

                return;
            }

            float alpha = (float)h * 360 / 12 + (float)m * 360 / (12 * 60) + (float)s * 360 / (12 * 60 * 60);

            Console.WriteLine($"Угол между часовой стрелкой в начале суток и в {h}:{m}:{s} равен {alpha}");
        }
    }
}
