using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Известны объём и масса тела. Определить плотность материала этого тела
            // V, m. p?
            // p = m / V

            double m = 50, V = 34;

            double p = m / V;

            Console.WriteLine(p);
        }
    }
}
