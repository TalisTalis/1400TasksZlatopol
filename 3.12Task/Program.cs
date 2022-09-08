using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В подъезде №1 пятиэтажного дома 20 квартир.
            // Определить:
            // 1) на каком этаже этого подъезда находится квартира с заданным номером
            // 2) какой по счету является эта квартира, если квартира с минимальным номером явлется на первом этаже

            Console.Write("Введите номер квартиры: ");
            
            int number = int.Parse(Console.ReadLine());

            int floor = (number - 1) % 20 / 4 + 1; // вычисление этажа

            int count = (number - 1) % 20 + 1; // вычисление номера квартиры по порядку

            Console.WriteLine($"Квартира с №{number} находится на {floor} этаже и она является {count} по счёту");
        }
    }
}
