﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._15Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;

            Console.WriteLine("Введите первое число");

            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите четвёртое число");

            fourthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber}");
        }
    }
}
