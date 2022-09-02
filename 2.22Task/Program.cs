using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._22Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны два числа. Найти среднее арифметическое и среднее геометрическое их модулей.

            double firstNumber = 4;

            double secondNumber = -6;

            double firstModule = Math.Abs(firstNumber);

            double secondModule = Math.Abs(secondNumber);

            double arithmeticMean = (firstModule + secondModule) / 2;

            double geometricMean = Math.Sqrt(firstModule * secondModule);

            Console.WriteLine("Среднее ариметическое модулей чисел " + firstNumber + " и " + secondNumber + " равно " + arithmeticMean);

            Console.WriteLine("Среднее геометрическое модулей чисел " + firstNumber + " и " + secondNumber + " равно " + geometricMean);
        }
    }
}
