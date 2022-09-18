using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны два расстояния: одно выражено в километрах,
            // другое - в футах (1 фут = 0,3048 м). Какое из расстояний меньше?

            Console.Write("Введите расстояние в километрах: ");

            float kilometr = float.Parse(Console.ReadLine());

            Console.Write("Введите расстояние в футах: ");

            float foot = float.Parse(Console.ReadLine()) * 0.3048f;

            if (kilometr * 1000 > foot * 0.3048f)
            {
                Console.WriteLine($"Расстояние в {foot}ft меньше.");
            }
            else
            {
                Console.WriteLine($"Расстояние в {kilometr}км меньше.");
            }
        }
    }
}
