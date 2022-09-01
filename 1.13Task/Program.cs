using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._13Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            int number = int.Parse(Console.ReadLine());

            int beforeNumber = number - 1;
            int afterNumber = number + 1;

            Console.WriteLine("Следующее за числом " + number + " число - " + afterNumber);

            Console.WriteLine("Для числа " + number + " предыдущее число - " + beforeNumber);
        }
    }
}
