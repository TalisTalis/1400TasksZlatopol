using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // На складе товары находятся в 10-ярусном стеллаже, разбитом на 8 секций.
            // В каждой секции на каждом ярусе предусмотрено 15 мест для товаров.
            // Нумерация мест 
            // Склад обслуживается роботом.
            // Определить, в какой секции и на каком ярусе робот должен взять товар, 
            // находящийся на месте с заданным номером.

            Console.Write("Введите номер товара: ");

            int numberGoods = int.Parse(Console.ReadLine());

            int index = numberGoods - 1;

            int tier1 = index / (8 * 15) + 1; // вычисление яруса если счет идет по ярусам

            int section1 = index / 15 % 8 + 1; // вычисление секции

            Console.WriteLine($"Товар с номером {numberGoods} находится в {section1} секции на {tier1} ярусе");

            int tier2 = index % 10 + 1; // вычисление яруса если счет вертикальный

            int section2 = index / (10 * 15) + 1; // вычисление секции

            Console.WriteLine($"Товар с номером {numberGoods} находится в {section2} секции на {tier2} ярусе");

        }
    }
}
