using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название футбольного клуба");

            string nameClub = Console.ReadLine();

            Console.WriteLine($"{nameClub} - это чемпион!");
        }
    }
}
