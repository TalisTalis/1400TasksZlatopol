using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._08Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // В кинотеатре имеется 20 рядов мест для зрителей, в каждом из которых
            // расположено 15 кресел. Билет для зрителей имеет серию АВ и номер билета,
            // для первого места в первом ряду равного 01643 (далее этот номер увеличивается
            // согласно условному обозначению мест
            // Определить, в каком ряду находится место, билет на которое имеет заданный серийный номер

            Console.Write("Введите номер билета: ");

            int numberTicket = int.Parse(Console.ReadLine());

            int a = numberTicket - 1642;

            int numberRow = (a + 15) / 15;

            Console.WriteLine($"Место по билету АВ № 0{numberTicket} находится в {numberRow} ряду");
        }
    }
}
