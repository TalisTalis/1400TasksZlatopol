using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._28Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции
            // S = ((a + b) / 2) * h
            // h = ((b - a) / 2) * tg(x)

            double a = 5; // меньшее основание

            double b = 8; // большее основание

            double x = 45; // угол при большем основании

            double h = (b - a) / 2 * Math.Tan(x); // высота трапеции

            Console.WriteLine("Высота h = " + h);

            double S = (a + b) / 2 * h;

            Console.WriteLine("Площадь равнобедренной трапеции S = " + S);
        }
    }
}
