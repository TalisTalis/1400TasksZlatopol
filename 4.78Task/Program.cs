using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._78Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поле шахматной доски определяется парой натуральных чисел,
            // каждое из которых не превосходит восьми: первое число – номер вертикали
            // (при счете слева направо), второе – номер горизонтали(при счете снизу вверх).
            // Даны натуральные числа a,b, c, d, каждое из которых не превосходит восьми.
            // Определить,являются ли поля(a, b) и(c, d) полями одного цвета.
            // Ответ проверить на шахматной доске или на клетчатой бумаге.

            Console.Write("Введите значение a от 1 до 8: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b от 1 до 8: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение c от 1 до 8: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите значение d от 1 до 8: ");

            int d = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) % 2 == Math.Abs(c - d) % 2)
            {
                Console.WriteLine("Поля одного цвета.");
            }
            else
            {
                Console.WriteLine("Поля разного цвета.");
            }
        }
    }
}
