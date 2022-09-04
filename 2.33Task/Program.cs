using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._33Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Возраст Тани - X лет, а возраст Миши - Y лет. Найти их средний возраст, а также определить, 
            // на сколько отличается возраст каждого ребёнка от среднего возраста.

            int ageTanya, ageMisha;

            Console.Write("Введите возраст Тани: ");

            ageTanya = int.Parse(Console.ReadLine());

            Console.Write("Введите возраст Миши: ");

            ageMisha = int.Parse(Console.ReadLine());

            int middleAge = (ageTanya + ageMisha) / 2; // средний возраст

            Console.WriteLine($"Средний возраст детей {middleAge}");

            Console.WriteLine($"Возраст Тани отличается от среднего возраста на {Math.Abs(middleAge - ageTanya)}");

            Console.WriteLine($"Возраст Миши отличается от среднего возраста на {Math.Abs(middleAge - ageMisha)}");
        }
    }
}
