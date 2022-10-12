using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._87Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны год, номер месяца и день рождения каждого из двух человек.
            // Определить, кто из них старше.

            Console.Write("Введите год рождения первого человека: ");

            int yearFirstMan = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца рождения первого человека: ");

            int monthFirstMan = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения первого человека: ");

            int dayFirstMan = int.Parse(Console.ReadLine());

            Console.Write("Введите год рождения второго человека: ");

            int yearSecondMan = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца рождения второго человека: ");

            int monthSecondMan = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения второго человека: ");

            int daySecondMan = int.Parse(Console.ReadLine());

            int allDayFirstMan = yearFirstMan * 365 + monthFirstMan * 30 + dayFirstMan;

            int allDaySecondMan = yearSecondMan * 365 + monthSecondMan * 30 + daySecondMan;

            if (allDayFirstMan > allDaySecondMan)
            {
                Console.WriteLine("Второй человек старше первого.");
            }
            else
            {
                Console.WriteLine("Первый человек старше второго.");
            }
        }
    }
}
