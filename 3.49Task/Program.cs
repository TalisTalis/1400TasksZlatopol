using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._49Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Часовая стрелка образует угол y с лучом, проходящим
            // через центр и через точку, соотвутствующую 12 часов на циферблате,
            // 0 < y <= 2п.
            // Определить значение угла для минутной стрелки,
            // а также количество полных часов и полных минут

            Console.Write("Введите угол y: ");

            float y = float.Parse(Console.ReadLine());

            int h = (int)(y / 30);

            int m = (int)((y / 30) * 60) % 60;

            float mAlpha = m * 6;

            Console.WriteLine($"Угол {y} соответствует {h} полным часам и {m} полным минутам");

            Console.WriteLine($"Угол для минутной стрелки равен {mAlpha}");
        }
    }
}
