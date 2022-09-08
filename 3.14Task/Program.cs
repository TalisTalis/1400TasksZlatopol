using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В жилом 9-этажном доме имеется 4 подъезда, на каждом этаже - 6 квартир. Определить:
            // в каком подъезде находится квартира с заданным номером;
            // на каком этаже этого подъезда она находится;
            // какой по счету на этаже является эта квартира, если квартира с минимальным номером 
            // является первой на этаже.

            Console.Write("Введите номер квартиры: ");

            int numberFlat = int.Parse(Console.ReadLine());

            int entrance = (numberFlat - 1) / (9 * 6) + 1; // вычисление подъезда

            int floor = (numberFlat - 1) / 9 % 6 + 1; // вычисление этажа

            int count = (numberFlat - 1) % (9 * 6) + 1; // вычисление порядкого номера квартиры

            Console.WriteLine($"Квартира под №{numberFlat} находится в {entrance} подъезде, на {floor} этаже и является {count} по счёту");
        }
    }
}
