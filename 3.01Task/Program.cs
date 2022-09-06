using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._01Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано расстояние в сантиметрах. Найти число полных метров в нём.

            Console.Write("Введите расстояние в сантиметрах: ");

            int centimetre = int.Parse(Console.ReadLine());

            int metr = centimetre / 100;

            Console.WriteLine($"Из {centimetre} см полных метров {metr}");
        }
    }
}
