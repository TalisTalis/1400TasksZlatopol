using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._35Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Два автомобиля едут друг за другом с постоянными скоростями V1 и V2 км/ч (V1 > V2).
            // Определить какое расстояние будет между ними через 30 мин после того, как
            // первый автомобиль опередил второй на S км.

            Console.Write("Введите скорость первой машины: ");

            int speedFirstCar = int.Parse(Console.ReadLine());

            Console.Write("Введите скорость первой машины: ");

            int speedSecondCar = int.Parse(Console.ReadLine());

            Console.Write("Введите на сколько км первый автомобиль опередил второй: ");

            int distanceAhead = int.Parse(Console.ReadLine());

            float time = 0.5f;

            float distanceFirstCar = distanceAhead + speedFirstCar * time;

            float distanceSecondCar = speedSecondCar * time;

            float distance = distanceFirstCar - distanceSecondCar;

            Console.WriteLine($"Расстояние между двумя машинами через 30 минут будет {distance} км");
        }
    }
}
