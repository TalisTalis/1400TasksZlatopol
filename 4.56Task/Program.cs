using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._56Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли запись заданного четырёхзначного 
            // натурального числа симметричной

            Console.Write("Введите четырёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            int firstPart = n / 100;

            int firstDigitSecondPart = n % 100 / 10;

            int secondDigitSecondPart = n % 10;

            int secondPart = secondDigitSecondPart * 10 + firstDigitSecondPart;

            if (firstPart == secondPart)
            {
                Console.WriteLine("Запись числа является симметричной.");
            }
            else
            {
                Console.WriteLine("Запись числа не является симметричной.");
            }
        }
    }
}
