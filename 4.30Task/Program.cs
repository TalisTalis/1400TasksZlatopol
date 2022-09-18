using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._30Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано трёхзначное число. Выяснить, является ли оно 
            // палиндромом ("перевёртышем"), т. е. таким числом, 
            // десятичная запись которого читается одинаково слева направо
            // и справа налево.

            Console.Write("Введите трёхзначное число: ");

            int n = int.Parse(Console.ReadLine());

            if (n / 100 == n % 10)
            {
                Console.WriteLine("Число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом.");
            }
        }
    }
}
