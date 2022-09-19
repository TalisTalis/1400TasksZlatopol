using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._39Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Работа светофора для пешеходов запрограммирована следующим образом:
            // в начале каждого часа в течение трёх минут горит зеленый сигнал,
            // затем в течение двух минут - красный, 
            // в течение трёх минут - опять зеленый и т.д.
            // Дано вещественное число t, означающее время в минутах, прошедшее 
            // с начала очередного часа. 
            // Определить, сигнал какого цвета горит для пешехода в этот момент.

            Console.Write("Введите знпечение t: ");

            double t = double.Parse(Console.ReadLine());

            if (t % 60 % 5 <= 3)
            {
                Console.WriteLine("Горит зелёный.");
            }

            if (t % 60 % 5 > 3)
            {
                Console.WriteLine("Горит красный.");
            }
        }
    }
}
