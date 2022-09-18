using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Даны объёмы и массы двух тел из разных металлов.
            // Материал какого тела имеет большую плотность?
            // p = m / v

            Console.Write("Введите объём первого металла: ");

            int volumeFirstMetal = int.Parse(Console.ReadLine());

            Console.Write("Введите массу первого металла: ");

            int weightFirstMetal = int.Parse(Console.ReadLine());

            Console.Write("Введите объём второго металла: ");

            int volumeSecondMetal = int.Parse(Console.ReadLine());

            Console.Write("Введите массу второго металла: ");

            int weightSecondMetal = int.Parse(Console.ReadLine());

            float pFirstMetal = weightFirstMetal / volumeFirstMetal;

            float pSecondMetal = weightSecondMetal / volumeSecondMetal;

            if (pFirstMetal > pSecondMetal)
            {
                Console.WriteLine("Первый металл имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Второй металл имеет большую плотность.");
            }
        }
    }
}
