using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._09Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // С начала суток прошло n секунд. Определить:
            // сколько полных часов прошло с начала суток;
            // сколько полных минут прошло с начала очередного часа;
            // сколько полных секунд прошло с начала очередной минуты.

            Console.Write("Введите количество секунд: ");

            int sec = int.Parse(Console.ReadLine());

            int hour = sec / 3600;

            int minute = sec % 3600 / 60;

            int second = sec % 60;

            Console.WriteLine($"С начала суток прошло {hour} полных часов");

            Console.WriteLine($"С начала очередного часа прошло {minute} полных минут");

            Console.WriteLine($"С начала очередной минуты прошло {second} полных секунд");
        }
    }
}
