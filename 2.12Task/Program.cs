using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны количество жителей в государстве и площадь его территории.
            // Определить плотность населения в этому государстве

            double numberCitizen = 145557576; // количество жителей

            double squareTerritory = 17125191; // площадь территории

            double populationDensity = numberCitizen / squareTerritory; // плотность населения

            Console.WriteLine("Плотность населения " + populationDensity);
        }
    }
}
