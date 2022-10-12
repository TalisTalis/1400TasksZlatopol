using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._82Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число n (1 ≤ n ≤ 99), определяющее возраст человека(в годах).
            // Для этого числа напечатать фразу «мне n лет», учитывая,
            // что при некоторых значениях n слово «лет» надо заменить на слово «год» или «года».

            Console.Write("Введите позраст человека (от 1 до 99): ");

            int n = int.Parse(Console.ReadLine());

            string age = "";

            if (n % 10 >= 5 || n / 10 == 1 || n % 10 == 0)
            {
                age = "лет";
            }
            else
            {
                if (n % 10 == 1)
                {
                    age = "год";
                }
                else
                {
                    age = "года";
                }
            }

            Console.WriteLine($"Мне {n} {age}.");
        }
    }
}
