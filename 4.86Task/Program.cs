using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._86Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны год, номер месяца и день рождения человека,
            // а также год, номер месяца и день сегодняшнего дня.
            // Определить возраст человека(число полных лет).

            Console.Write("Введите год рождения человека: ");

            int yearMan = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца рождения человека: ");

            int monthMan = int.Parse(Console.ReadLine());

            Console.Write("Введите день рождения человека: ");

            int dayMan = int.Parse(Console.ReadLine());

            Console.Write("Введите сегодняшний год: ");

            int yearNow = int.Parse(Console.ReadLine());

            Console.Write("Введите сегодняшний номер месяца: ");

            int monthNow = int.Parse(Console.ReadLine());

            Console.Write("Введите сегодняшний день: ");

            int dayNow = int.Parse(Console.ReadLine());

            string yearString = "";

            int ageYear = ((yearNow * 12 + monthNow) - (yearMan * 12 + monthMan)) / 12;

            if (ageYear > 0)
            {
                if ((ageYear % 10 == 0 && ageYear / 10 > 1) || ageYear % 10 >= 5 || ageYear / 10 == 1)
                {
                    yearString = ageYear + " лет ";
                }
                else if (ageYear / 10 >= 2)
                {
                    yearString = ageYear + " года ";
                }
                else
                {
                    yearString = ageYear + " год ";
                }

                Console.WriteLine($"Человеку полных {yearString}");
            }
            else
            {
                Console.WriteLine($"Человеку нет полных лет");
            }
        }
    }
}
