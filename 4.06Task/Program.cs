using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._06Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для функций, заданных графически, определить значение y при заданном x

            Console.WriteLine("Введите версию");

            string str = Console.ReadLine();

            int y; 

            Console.Write("Введите значение x: ");

            int x = int.Parse(Console.ReadLine());

            if (str == "a")
            {
                if (x > 2)
                {
                    y = 2;


                }
                else
                {
                    y = x;
                }

                Console.WriteLine($"При x = {x} y = {y}.");
            }
            else if (str == "b")
            {
                if (x > 3)
                {
                    y = -3;
                }
                else
                {
                    y = x;
                }

                Console.WriteLine($"При x = {x} y = {y}.");
            }
        }
    }
}
