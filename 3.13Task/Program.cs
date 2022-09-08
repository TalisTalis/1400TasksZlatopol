using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дана таблица из 10 строк и 5 столбцов. Определить:
            // в какой строке находится значение с порядковым номером n, если нумерацию 
            // вести построчно сверху вниз, а в каждой строке - слева направо.
            // в каком столбце находится это значение.

            Console.Write("Введите порядковый номер: ");

            int n = int.Parse(Console.ReadLine());

            int row = (n - 1) / 5 + 1;

            int col = (n - 1) % 5 + 1;

            Console.WriteLine($"Зачение {n} находится в {row} строке и {col} столбце");
        }
    }
}
