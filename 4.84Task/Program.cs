using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._84Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано натуральное число n (1 ≤ n ≤ 9999),
            // определяющее стоимость товара в копейках.
            // Выразить стоимость в рублях и копейках, например 3 рубля 21 копейка,
            // 15 рублей 5 копеек, 1 рубль ровно и т. п.

            Console.Write("Введите стоимость товара в копейках (от 1 до 9999): ");

            int n = int.Parse(Console.ReadLine());

            int penny, rub;

            penny = n % 100;

            rub = n / 100;

            string rubCount = "";

            string pennyCount = "";

            
                if (rub == 0 || rub / 10 == 1 || rub % 10 >= 5)
                {
                    rubCount = "рублей";
                }
                else if (rub % 10 < 5 && rub % 10 > 1)
                {
                    rubCount = "рубля";
                }
                else
                {
                    rubCount = "рубль";
                }

                if ((penny / 10 != 0 && penny % 10 == 0) || penny / 10 >= 1 || penny % 10 >= 5)
                {
                    pennyCount = penny + " копеек";
                }
                else if (penny == 0)
                {
                    pennyCount = "ровно";
                }
                else
                {
                    pennyCount = penny + " копейка";
                }

            Console.WriteLine($"{rub} {rubCount} {pennyCount}");
        }
    }
}
