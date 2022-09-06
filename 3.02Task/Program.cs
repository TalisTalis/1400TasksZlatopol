using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дана масса в килограммах. Найти число полных центнеров в ней.

            Console.Write("Введите массу в килограммах: ");

            int kilogramm = int.Parse(Console.ReadLine());

            int centner = kilogramm / 100;

            Console.WriteLine($"В {kilogramm} кг полных центнеров {centner}");
        }
    }
}
