using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // С начала 1990 года по некоторый день прошло n месяцев и 2 дня.
            // Присвоить целочисленной величине x значение 1, 2, ..., 11 или 12
            // в зависимости от того, каким месяцем (январем, февралем и т.п.) является
            // месяц этого дня. Например, при n=3 значение x равно 4

            Console.Write("Введите сколько месяцев прошло с начала года: ");

            int n = int.Parse(Console.ReadLine());

            int x = (n + 1) % 12;

            Console.WriteLine($"С начала года прошло {n} месяцев и 2 дня и этот месяц - {x}");
        }
    }
}
