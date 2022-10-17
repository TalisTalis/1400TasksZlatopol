using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._98Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В подъезде жилого дома имеется n квартир, пронумерованных подряд, начиная с номера a.
            // Определить, является ли сумма номеров всех квартир четным числом.
            // Формулу суммы членов арифметической прогрессии не использовать.

            Console.Write("Введите количество квартир n: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите номер первой квартиры a: ");

            int a = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = a; i <= n; i++)
            {
                sum += i;
            }

            if ((a % 2 + n) / 2 % 2 == 0)
            {
                Console.WriteLine("Сумма номеров квартир чётная.");
            }
            else
            {
                Console.WriteLine("Сумма номеров квартир нечётная.");
            }

            Console.WriteLine($"В подъезде {n}, начиная с номера {a}, сумма номеров квартир равна {sum}");
        }
    }
}
