using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._48Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // С начала суток часовая стрелка поверунулась на y градусов (0 <= y <= 360, y - вещественное число)
            // Определить число полных часов и число полных минут, прошедших с начала суток

            Console.Write("Ввести угод часовой стрелки от 0 до 360: ");

            float y = float.Parse(Console.ReadLine());

            int h = (int)((y * 12) / 360);

            int m = (int)((y * 12 * 60) / 360) % 60;

            Console.WriteLine($"При повороте часовой стрелки на угол {y} прошло {h} полных часов и {m} полных минут");
        }
    }
}
