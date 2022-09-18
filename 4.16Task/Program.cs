using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._16Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для условий предыдущей задачи в случае наличия вещественных корней
            // найти их, в противном случае - вывести на экран соответствующее сообщение.
            // Вариант равенства корней отдельно не рассматривать

            Console.Write("Введите значение a = ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b = ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c = ");

            int c = int.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2;

            if (a == 0)
            {
                Console.WriteLine("Переменная a не должна быть равна нулю!");

                return;
            }

            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);

                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"В уравнении ax2 + bx + c = 0 корни x1 = {Math.Round(x1, 2)}, x2 = {Math.Round(x2, 2)}");
            }
            else
            {
                Console.WriteLine("Уравнение корни не имеет.");
            }
        }
    }
}
