using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._71Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Траектория снаряда, вылетающего из орудия под углом a с начальной скоростью V0,
            // задается уравнением x = V0tcosa, y = V0tsina-gt^2/2, где g = 9,8 м/с^2 - ускорение свободного падения
            // t - время.
            // Даны значения a и V0. Определить, поразит ли снаряд цель высотой P, расположенную в вертикальной
            // плоскости ствола орудия на расстоянии R на высоте H.

            Console.Write("Введите угол траектории снаряда a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите начальную скорость снаряда V0: ");

            int v0 = int.Parse(Console.ReadLine());

            int R = 4000;

            int H = 400;

            int P = 100;

            double g = 9.8;

            double t = R / (v0 * Math.Cos(a));

            double y = v0 * t * Math.Sin(a) - (g * Math.Pow(t, 2)) / 2;

            if (y > H && y < H + P)
            {
                Console.WriteLine("Снярад поразит цель.");
            }
            else
            {
                Console.WriteLine("Снаряд не поразит цель.");
            }
        }
    }
}
