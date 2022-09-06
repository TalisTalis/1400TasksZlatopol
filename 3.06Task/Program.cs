using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._06Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В купейном вагоне имеется 9 купе с четырьмя местами для пассажиров в каждом.
            // Определить номер купе, в котором находится место с заданным номером (нумерация мест
            // сквозная, начинается с 1).

            Console.Write("Введите № места: ");

            int numberSit = int.Parse(Console.ReadLine());

            int numberCupe = (numberSit + 3) / 4;

            Console.WriteLine($"Номер купе, в котором находится место №{numberSit}, равен {numberCupe}");
        }
    }
}
