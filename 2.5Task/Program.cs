using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._06Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rEarth = 6350000.0; // радиус Земли в метрах

            double h = 1.88; // Рост человека в метрах

            double s; // Расстояние от наблюдателя до линии горизонта

            double c = rEarth + h; // Сумма радиуса Земли и роста человека

            s = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(rEarth, 2)) / 1000; // в километрах

            Console.WriteLine("Расстояние от наблюдателя ростом " + h + " метра до линии горизонта составляет " + s + " километров");
        }
    }
}
