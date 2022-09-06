using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано целое число k (1<= k <= 365). Присвоить целочисленной величине n 
            // значение 1, 2, ..., 6 или 0 в зависимости от того на какой день недели 
            // (понедельник, вторник, ..., субботу или воскресенье) приходится k-й день года, 
            // в котором 1 января:
            // а) понедельник;
            // б) вторник;
            // в) d-й день недели.

            Console.Write("Введите номер дня года (от 1 до 365): ");

            int k = int.Parse(Console.ReadLine());

            Console.Write("Введите на какой день недели приходится 1 января (от 1 до 7): ");

            int d = int.Parse(Console.ReadLine()); // начальная точка отсчета дней

            int n = (k + d - 1) % 7;

            Console.WriteLine($"На {k}-й день года приходится {n}-й день недели");
        }
    }
}
