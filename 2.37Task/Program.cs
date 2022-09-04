using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._37Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // У американского писателя-фантаста Рэя Бредбери есть роман "450 градусов по Фаренгейту".  
            // Разработать программу, которая определяет, какой температуре по шкале Цельсия соответствует
            // указанное в названии значение.

            float tempFahrenheit = 450.0f;

            float tempCelsius = 5.0f / 9.0f * (tempFahrenheit - 32.0f);

            Console.WriteLine($"Температура '450 градусов по Фаренгейту' соответствует {tempCelsius} по шкале Цельсия");
        }
    }
}
