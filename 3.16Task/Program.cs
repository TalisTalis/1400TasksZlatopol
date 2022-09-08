using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано двузначное число. Найти
            // число десятков в нём
            // число единиц в нём

            Console.Write("Введите двузначное число: ");

            int number = int.Parse(Console.ReadLine());

            int dec = number / 10;

            int unit = number % 10;

            Console.WriteLine($"В числе {number} число десятков {dec}, число единиц {unit}");
        }
    }
}
