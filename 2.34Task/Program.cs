using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._34Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и V2 км/ч. 
            // Определить, через какое время автомобили встретятся, если расстояние между ними было S км.

            Console.Write("Введите скорость первого автомобиля: ");
            
            int speedFirstCar = int.Parse(Console.ReadLine());

            Console.Write("Введите скорость второго автомобиля: ");

            int speedSecondCar = int.Parse(Console.ReadLine());

            int S = 10;

            float meetingTime = S / (speedFirstCar + speedSecondCar);

            Console.WriteLine($"Автомобили встретять через t = {meetingTime} ч");
        }
    }
}
