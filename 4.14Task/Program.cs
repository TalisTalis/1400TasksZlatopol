using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны сопротивления двух не соединенных друг с другом
            // участков электрической цепи и напряжение на каждом из них.
            // По какому участку протекает меньший ток?

            Console.Write("Введите сопротивление первого участка цепи: ");

            int resistFirstRegion = int.Parse(Console.ReadLine());

            Console.Write("Введите напряжение на первом участке цепи: ");

            int voltageFirstRegion = int.Parse(Console.ReadLine());

            Console.Write("Введите сопротивление второго участка цепи: ");

            int resistSecondRegion = int.Parse(Console.ReadLine());

            Console.Write("Введите напряжение на втором участке цепи: ");

            int voltageSecondRegion = int.Parse(Console.ReadLine());

            float currentFirstRegion = voltageFirstRegion / resistFirstRegion;

            float currentSecondRegion = voltageSecondRegion / resistSecondRegion;

            if (currentFirstRegion > currentSecondRegion)
            {
                Console.WriteLine("По второму участку цепи протекает меньший ток.");
            }
            else
            {
                Console.WriteLine("По первому участку цепи протекает меньший ток.");
            }
        }
    }
}
