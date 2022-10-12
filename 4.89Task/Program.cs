using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._89Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поезд прибывает на станцию в a часов b минут и отправляется в c часов d минут.
            // Пассажир пришел на платформу в n часов m минут.
            // Будет ли поезд стоять на платформе?
            // Числа a, b, c, d, n, m – целые, 0 < a ≤ 23, 0 < b ≤ 59, 0 < c ≤ 23, 0 < d ≤ 59, 0 < n ≤ 23, 0 < m ≤ 59.

            Console.Write("Введите час прибытия поезда на станцию a (от 0 до 23): ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите муниты прибытия поезда на станцию b (от 0 до 59): ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите час отбытия поезда от станции c (от 0 до 23): ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите муниты отбытия поезда от станции d (от 0 до 59): ");

            int d = int.Parse(Console.ReadLine());

            Console.Write("Введите час прихода пассажира на станцию n (от 0 до 23): ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите муниты прихода пассажира на станцию m (от 0 до 59): ");

            int m = int.Parse(Console.ReadLine());

            if ((a * 60 + b) <= (n * 60 + m) && (c * 60 + d) >= (n * 60 + m))
            {
                Console.WriteLine("Поезд еще стоит на платформе.");
            }
            else
            {
                Console.WriteLine("Поезда нет на платформе.");
            }
        }
    }
}
