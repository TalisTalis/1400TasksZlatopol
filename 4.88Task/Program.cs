using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._88Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны год и номер месяца рождения человека, а так-же год и номер месяца сегодняшнего дня.
            // Определить возраст человека(число полных лет и число полных месяцев).
            // При определении числа полных месяцев дни месяца не учитывать,
            // а использовать разность между номерами месяцев.
            // Например, если месяц рождения – февраль, а текущий(сегодняшний) месяц – май,
            // то число полных месяцев равно трем независимо от дня рождения и сегодняшнего дня.

            Console.Write("Введите год рождения человека: ");

            int yearMan = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца рождения человека: ");

            int monthMan = int.Parse(Console.ReadLine());

            Console.Write("Введите сегодняшний год: ");

            int yearNow = int.Parse(Console.ReadLine());

            Console.Write("Введите номер сегодняшнего месяца: ");

            int monthNow = int.Parse(Console.ReadLine());

            int resYear = Math.Abs((yearNow * 12 + monthNow) - (yearMan * 12 + monthMan)) / 12;

            int resMonth = Math.Abs((yearNow * 12 + monthNow) - (yearMan * 12 + monthMan)) % 12;

            string yearString, monthString;

            if (resYear > 0)
            {
                if (resYear % 10 == 1)
                {
                    yearString = resYear + " год ";
                }
                else if (resYear / 10 != 1 && resYear < 5)
                {
                    yearString = resYear + " года ";
                }
                else
                {
                    yearString = resYear + " лет ";
                }
            }
            else
            {
                yearString = "";
            }

            if (resMonth > 0)
            {
                if (resMonth % 10 == 1)
                {
                    monthString = resMonth + " месяц";
                }
                else if (resMonth / 10 != 1 && resMonth < 5)
                {
                    monthString = resMonth + " месяца";
                }
                else
                {
                    monthString = resMonth + " месяцев";
                }
            }
            else
            {
                monthString = " ровно";
            }

            Console.WriteLine($"Человеку полных {yearString}{monthString}.");
        }
    }
}
