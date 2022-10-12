using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._81Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны вещественные положительные числа a, b, c.
            // Если существует треугольник со сторонами a, b, c, то:
            // а) определить его вид(прямоугольный, остроугольный или тупоугольный);
            // б) определить его вид(прямоугольный, остроугольный или тупоугольный)
            // и особенности(равносторонний, равнобедренный, разносторонний).

            Console.Write("Введите значение a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");

            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Треугольник существует.");

                if (a*a + b*b < c*c)
                {
                    Console.WriteLine("Треугольник тупоугольный.");
                }
                else if (a*a + b*b == c*c)
                {
                    Console.WriteLine("Треугольник прямоугольный.");
                }
                else if (a*a + b*b > c*c)
                {
                    Console.WriteLine("Треугольник остроугольный.");
                }

                if (a != b && b != c && c != a)
                {
                    Console.WriteLine("Треугольник разностороний.");
                }
                else if ((a == b || b == c) && c != a)
                {
                    Console.WriteLine("Треугольник равнобедренный.");
                }
                else if (a == b && b == c)
                {
                    Console.WriteLine("Треугольник равносторонний.");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
        }
    }
}
