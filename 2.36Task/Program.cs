using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._36Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известно значение температуры по шкале Цельсия. Найти соотвутствующее значение температуры по шкале
            // Фаренгейта
            // Кельвина
            
            Console.Write("Введите температуру по шкале Цельсия: ");

            float tempCelsius = float.Parse(Console.ReadLine());

            float tempFahrenheit = (9.0f / 5.0f) * tempCelsius + 32.0f;

            float tempKelvin = tempCelsius + 273.15f;

            Console.WriteLine($"{tempCelsius} по шкале Цельсия = {tempFahrenheit} по шкале Фаренгейта");

            Console.WriteLine($"{tempCelsius} по шкале Цельсия = {tempKelvin} по шкале Кельвина");
        }
    }
}
