using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Подъезде № 1 пятиэтажного жилого дома 15 квартир.
            // Определить, на каком этаже этого подъезда находится квартира с заданным номером

            Console.Write("Введите номер квартиры от 1 до 15: ");

            int numberFlat = int.Parse(Console.ReadLine());

            int numberFloor = (numberFlat + 2) / 3;

            Console.WriteLine($"Квартира под №{numberFlat} находится на {numberFloor} этаже");
        }
    }
}
