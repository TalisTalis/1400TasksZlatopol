using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._92Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Работа светофора для водителей запрограммирована следующим образом:
            // в начале каждого часа в течение трех минут горит зеленый сигнал,
            // затем в течение одной минуты – желтый,в течение двух минут – красный,
            // в течение трех минут – опять зеленый и т. д.
            // Дано вещественное число t, означающее время в минутах, прошедшее с начала очередного часа.
            // Определить,сигнал какого цвета горит для водителей в этот момент.

            Console.Write("Введите число t: ");

            double t = double.Parse(Console.ReadLine());

            if (t % 6 < 3)
            {
                Console.WriteLine("Горит зелёный.");
            }
            else if (t % 6 < 4)
            {
                Console.WriteLine("Горит жёлтый.");
            }
            else
            {
                Console.WriteLine("Горит красный.");
            }
            // 123 1 12 123 1 1 2  1 2 3
            // 012 3 45 678 9 1011 121314 
        }
    }
}
