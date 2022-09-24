using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._66Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пассажир должен был сдать в камеру хранения пустой чемодан
            // в форме параллелепипеда размерами a1, a2 и a3 см и коробку
            // размерами b1, b2 и b3 см.
            // Оплачивать нужно каждый размещаемый предмет.
            // Определить, сможет ли пассажир сэкономить на оплате, поместив коробку в чемодан так,
            // что стороны чемодана и коробки будут параллельны либо перпендикулярны друг другу

            Console.Write("Введите размер чемодана a1: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите размер чемодана a2: ");

            int a2 = int.Parse(Console.ReadLine());

            Console.Write("Введите размер чемодана a3: ");

            int a3 = int.Parse(Console.ReadLine());

            Console.Write("Введите размер коробки b1: ");

            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Введите размер коробки b2: ");

            int b2 = int.Parse(Console.ReadLine());

            Console.Write("Введите размер коробки b3: ");

            int b3 = int.Parse(Console.ReadLine());

            if (b1 <= a1 && b2 <= a2 && b3 <= a3 ||
                b2 <= a1 && b3 <= a2 && b1 <= a3 ||
                b3 <= a1 && b1 <= a2 && b2 <= a3)
            {
                Console.WriteLine("Коробка поместится в чемодан.");
            }
            else
            {
                Console.WriteLine("Коробка не поместится.");
            }
        }
    }
}
