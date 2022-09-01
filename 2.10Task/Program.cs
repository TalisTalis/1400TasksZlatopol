using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 5;

            double secondNumber = 2;

            double arithmeticMean = (firstNumber + secondNumber) / 2;

            double geometricMean = Math.Sqrt(firstNumber * secondNumber);

            Console.WriteLine("Среднее арифметическое чисел " + firstNumber + " и " + secondNumber + " равно " + arithmeticMean);

            Console.WriteLine("Серднее геометрическое чисел " + firstNumber + " и " + secondNumber + " равно " + geometricMean);
        }
    }
}
