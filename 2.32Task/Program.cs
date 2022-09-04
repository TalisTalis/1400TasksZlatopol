using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._32Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить
            // 3 компьютера из этих элементов? N компьютеров?

            int costMonitor = 4;

            int costComputeTower = 7;

            int costKeyboard = 3;

            int costMouse = 5;

            int costComputer = costMonitor + costComputeTower + costKeyboard + costMouse;

            Console.Write("Введите количество компьютеров: ");
            
            int quanityComputer = int.Parse(Console.ReadLine());

            int totalCost = quanityComputer * costComputer;

            Console.WriteLine($"Стоимость {quanityComputer} компьютеров равна {totalCost}");

        }
    }
}
