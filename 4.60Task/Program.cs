using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._60Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известен рост трёх человек. Определить, одинков ли их рост

            Console.Write("Введите рост первого человека: ");

            int firstPerson = int.Parse(Console.ReadLine());

            Console.Write("Введите рост второго человека: ");

            int secondPerson = int.Parse(Console.ReadLine());

            Console.Write("Введите рост третьего человека: ");

            int thirdPerson = int.Parse(Console.ReadLine());

            if (firstPerson == secondPerson && secondPerson == thirdPerson)
            {
                Console.WriteLine("Рост трёх человек одинаков.");
            }
            else
            {
                Console.WriteLine("Рост трёх человек не одинаков.");
            }
        }
    }
}
