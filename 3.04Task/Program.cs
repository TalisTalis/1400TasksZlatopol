using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._04Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, которая решает следующую задачу:
            // N школьников делят k яблок поровну так, чтобы каждому достались только целые яблоки,
            // остальные яблоки остаются в корзинке. Определить, сколько яблок достанется каждому
            // школьнику и сколько яблок останется в корзике.

            Console.Write("Введите количество школьников: ");

            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите количество яблок: ");

            int k = int.Parse(Console.ReadLine());

            int appleSchoolboys = k / N; // количество яблок каждому

            int appleBasket = k % N; // количество остатка от деления

            Console.WriteLine($"По {appleSchoolboys} яблок достанется каждому и {appleBasket} останется в корзинке");
        }
    }
}
