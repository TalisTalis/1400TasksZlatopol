using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._83Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для натурального числа k напечатать фразу «мы нашли k грибов в лесу»,
            // согласовав окончание слова «гриб» с числом k.

            Console.Write("Введите количество грибов k: ");

            int k = int.Parse(Console.ReadLine());

            string mushroom = "";

            if (k % 10 >= 5 || k % 10 == 0 || k / 10 == 1)
            {
                mushroom = "грибов";
            }
            else
            {
                if (k % 10 == 1)
                {
                    mushroom = "гриб";
                }
                else
                {
                    mushroom = "гриба";
                }
            }

            Console.WriteLine($"Мы нашли {k} {mushroom} в лесу.");
        }
    }
}
