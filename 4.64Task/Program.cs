using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._64Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вася пытается высунуть голову в форточку размерами a и b см.
            // Приняв условно, что его голова - круглая диаметром d см,
            // определить, сможет ли Вася сделать это.
            // Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны

            Console.Write("Введите размер форточки a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите размер форточки b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите диаметр головы Васи d: ");

            int d = int.Parse(Console.ReadLine());

            if (d + 2 <= a && d + 2 <= b)
            {
                Console.WriteLine("Вася сможет высунуть голову в форточку.");
            }
            else
            {
                Console.WriteLine("Высунуть голову не получится.");
            }

        }
    }
}
