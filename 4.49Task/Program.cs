using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._49Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Определить:
            // входит ли в него цифра 3
            // входит ли в него цифра a

            Console.Write("Введите двузначное число: ");

            int n = int.Parse(Console.ReadLine());

            if (n / 10 == 3 || n % 10 == 3)
            {
                Console.WriteLine("Число содержит число 3.");
            }
            else
            {
                Console.WriteLine("Число не содержит число 3.");
            }

            Console.Write("Введите цифру a: ");

            int a = int.Parse(Console.ReadLine());

            if (n / 10 == a || n % 10 == a)
            {
                Console.WriteLine("Число содержит цифру a.");
            }
            else
            {
                Console.WriteLine("Число не содержит цифру a.");
            }
        }
    }
}
