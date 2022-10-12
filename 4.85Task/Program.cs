using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._85Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное число n (1 ≤ n ≤ 1188), определяющее возраст человека(в месяцах).
            // Выразить возраст в годах и месяцах,
            // например 21 год 10 месяцев, 52 года 1 месяц, 46 лет ровно и т. п.

            Console.Write("Введите возраст человека в месяцах (от 1 до 1188): ");

            int n = int.Parse(Console.ReadLine());

            string yearWord = "";

            string monthWord = "";

            int yearCount = n / 12;

            int monthCount = n % 12;

            if (yearCount % 10 >= 5 || yearCount / 10 == 1 || (yearCount % 10 == 0 && yearCount / 10 > 0))
            {
                yearWord = yearCount + " лет ";
            }
            else if (yearCount % 10 >= 2)
            {
                yearWord = yearCount + " года ";
            }
            else if (yearCount == 0)
            {
                yearWord = "";
            }
            else
            {
                yearWord = yearCount + " год ";
            }

            if (monthCount % 10 >= 5 || monthCount / 10 == 1 || (monthCount % 10 == 0 && monthCount / 10 > 1))
            {
                monthWord = monthCount + " месяцев";
            }
            else if (monthCount % 10 >= 2)
            {
                monthWord = monthCount + " месяца";
            }
            else if (monthCount % 10 == 1)
            {
                monthWord = monthCount + " месяц";
            }
            else
            {
                monthWord = "ровно";
            }

            Console.WriteLine($"{yearWord}{monthWord}.");
        }
    }
}
