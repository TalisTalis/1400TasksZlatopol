using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._03Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период.

            int days = 234;

            int week = days / 7;

            Console.WriteLine($"За период {days} дней прошло {week} полных недель");
        }
    }
}
