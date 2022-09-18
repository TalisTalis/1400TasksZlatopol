using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._17Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны год и номер месяца рождения человека,
            // а также год и номер месяца сегодняшнего дня (январь - 1 и т.д.).
            // Определить возраст человека (число полных лет).
            // В случае совпадения указанных номеров месяцев считать, что прошел полный год

            Console.Write("Введите год рождения человека: ");

            int yearBirthDay = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца рождения человека: ");

            int monthBirthDay = int.Parse(Console.ReadLine());

            int currentYear = 2022;

            int currentMonth = 9;

            int agePerson = currentYear - yearBirthDay;

            if (monthBirthDay == currentMonth)
            {
                agePerson++;
            }

            Console.WriteLine($"Возраст человека (полных лет) = {agePerson}");
        }
    }
}
