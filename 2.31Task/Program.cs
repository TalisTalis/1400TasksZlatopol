using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._31Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известна стоимость 1 кг конфет, печенья, яблок. Найти стоимость всей покупки, если купили
            // x кг конфет, y кг печенья и z кг яблок.

            int costCandyPerKilogram = 6; // стоимость конфет за килограмм

            int costCookiesPerKilogram = 2; // стоимость печенья за килограмм

            int costApplePerKilogram = 5; // стоимость яблок за килограмм

            int weightCandy, weightCookies, weightApple; // веса конфет, печенья, яблок

            Console.Write("Сколько кг конфет Вы купили: ");

            weightCandy = int.Parse(Console.ReadLine());

            Console.Write("Сколько кг печенья Вы купили: ");

            weightCookies = int.Parse(Console.ReadLine());

            Console.Write("Сколько кг яблок Вы купили: ");

            weightApple = int.Parse(Console.ReadLine());
            // стоимость всей покупки
            int costPurchase = weightCandy * costCandyPerKilogram + weightCookies * costCookiesPerKilogram + weightApple * costApplePerKilogram;
            
            Console.Write($"Стоимость всей покупки: {costPurchase}");

            Console.WriteLine();
        }
    }
}
