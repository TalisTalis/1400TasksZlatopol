using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._77Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поле шахматной доски определяется парой натуральных чисел,
            // каждое из которых не превосходит восьми: первое число – номер вертикали(при счете слева направо),
            // второе – номер горизонтали(при счете снизу вверх).
            // Даны натуральные числа a,b, c, d, e, f, каждое из которых не превосходит восьми.
            // На поле(a, b) расположена белая фигура, на поле(c, d) – черная.
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // Рассмотреть следующие варианты сочетаний белой и черной фигур:
            // а) ладья и ладья;
            // б) ладья и ферзь;
            // в) ладья и конь;
            // г) ладья и слон;
            // д) ферзь и ферзь;
            // е) ферзь и ладья;
            // ж) ферзь и конь;
            // з) ферзь и слон;
            // и) конь и конь;
            // к) конь и ладья;
            // л) конь и ферзь;
            // м) конь и слон;
            // н) слон и слон;
            // о) слон и ферзь;
            // п) слон и конь;
            // р) слон и ладья;
            // с) король и слон;
            // т) король и ферзь;
            // у) король и конь;
            // ф) король и ладья.
            // Во всех задачах ответ проверить на шахматной доске или на клетчатой бумаге.

            Console.Write("Введите поле белой фигуры значение a: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите поле белой фигуры значение b: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите поле чёрной фигуры значение c: ");

            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите поле чёрной фигуры значение d: ");

            int d = int.Parse(Console.ReadLine());

            Console.Write("Введите значение e: ");

            int e = int.Parse(Console.ReadLine());

            Console.Write("Введите значение f: ");

            int f = int.Parse(Console.ReadLine());

            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // а) ладья и ладья;
            if ((a == e || b == f) && (c != e && d != f))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черной ладьи на поле {c}, {d}.");
            }
            else if ((a == e || b == f) && (c == e || d == f))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} попадает под удар черной ладьи на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
            }
            else
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} не может пойти на поле {e}, {f}.");                       
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // б) ладья и ферзь;
            if ((a == e || b == f) && ((Math.Abs(c - e) > 1 && Math.Abs(d - f) > 1) && Math.Abs(c - e) != Math.Abs(d - f)))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного ферзя на поле {c}, {d}.");
            }
            else if ((a == e || b == f) && ((Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1) || Math.Abs(c - e) == Math.Abs(d - f)))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} попадает под удар черного ферзя на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
            }
            else
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // в) ладья и конь;
            if ((a == e || b == f) && ((Math.Abs(c - e) != 2 || Math.Abs(d - f) != 1) || (Math.Abs(c - f) != 1 || Math.Abs(d - e) != 2)))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного коня на поле {c}, {d}.");
            }
            else if ((a == e || b == f) && (Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1 || Math.Abs(c - f) == 1 && Math.Abs(d - e) == 2))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} попадает под удар черного коня на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
            }
            else
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // г) ладья и слон;
            if ((a == e || b == f) && (Math.Abs(c - e) != Math.Abs(d - f)))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного слона на поле {c}, {d}.");
            }
            else if ((a == e || b == f) && (Math.Abs(c - e) == Math.Abs(d - f)))
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} попадает под удар черного слона на поле {c}, {d}, если пойдёт на поле {e}, {f}.");                
            }
            else
            {
                Console.WriteLine($"Белая ладья на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // д) ферзь и ферзь;
            if ((Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1) || Math.Abs(a - e) == Math.Abs(b - f))
            {
                if ((Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1) || Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} попадает под удар черного ферзя на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного ферзя на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый ферзь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // е) ферзь и ладья;
            if ((Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1) || Math.Abs(a - e) == Math.Abs(b - f))
            {
                if (c == e || d == f)
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} попадает под удар черной ладьи на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черной ладьи на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый ферзь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // ж) ферзь и конь;
            if ((Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1) || Math.Abs(a - e) == Math.Abs(b - f))
            {
                if ((Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1) || (Math.Abs(d - f) == 2 && Math.Abs(c - e) == 1))
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} попадает под удар черного коня на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного коня на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый ферзь на поле {a}, {b} не может пойти на поле {e}, {f}.");                
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // з) ферзь и слон;
            if ((Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1) || Math.Abs(a - e) == Math.Abs(b - f))
            {
                if (Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} попадает под удар черного слона на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый ферзь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного слона на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый ферзь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // и) конь и конь;
            if ((Math.Abs(a - e) == 2 && Math.Abs(b - f) == 1) || (Math.Abs(b - f) == 2 && Math.Abs(a - e) == 1))
            {
                if ((Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1) || (Math.Abs(d - f) == 2 && Math.Abs(c - e) == 1))
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} попадает под удар черного коня на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного конь на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый конь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // к) конь и ладья;
            if ((Math.Abs(a - e) == 2 && Math.Abs(b - f) == 1) || (Math.Abs(b - f) == 2 && Math.Abs(a - e) == 1))
            {
                if (c == e || d == f)
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} попадает под удар черной ладьи на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черной ладьи на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый конь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // л) конь и ферзь;
            if ((Math.Abs(a - e) == 2 && Math.Abs(b - f) == 1) || (Math.Abs(b - f) == 2 && Math.Abs(a - e) == 1))
            {
                if ((Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1) || Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} попадает под удар черного ферзя на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного ферзя на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый конь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // м) конь и слон;
            if ((Math.Abs(a - e) == 2 && Math.Abs(b - f) == 1) || (Math.Abs(b - f) == 2 && Math.Abs(a - e) == 1))
            {
                if (Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} попадает под удар черного слона на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый конь на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного слона на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый конь на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // н) слон и слон;
            if (Math.Abs(a - e) == Math.Abs(b - f))
            {
                if (Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} попадает под удар черного слона на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного слона на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый слон на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // о) слон и ферзь;
            if (Math.Abs(a - e) == Math.Abs(b - f))
            {
                if ((Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1) || Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} попадает под удар черного ферзя на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного ферзя на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый слон на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // п) слон и конь;
            if (Math.Abs(a - e) == Math.Abs(b - f))
            {
                if ((Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1) || (Math.Abs(d - f) == 2 && Math.Abs(c - e) == 1))
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} попадает под удар черного коня на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного коня на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый слон на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // р) слон и ладья;
            if (Math.Abs(a - e) == Math.Abs(b - f))
            {
                if (c == e || d == f)
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} попадает под удар черной ладьи на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый слон на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черной ладьи на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый слон на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // с) король и слон;
            if (Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1)
            {
                if (Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} попадает под удар черного слона на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного слона на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый король на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // т) король и ферзь;
            if (Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1)
            {
                if ((Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1) || Math.Abs(c - e) == Math.Abs(d - f))
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} попадает под удар черного ферзя на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного ферзя на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый король на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // у) король и конь;
            if (Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1)
            {
                if ((Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1) || (Math.Abs(d - f) == 2 && Math.Abs(c - e) == 1))
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} попадает под удар черного коня на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черного коня на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый король на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }

            Console.WriteLine();
            // Определить, может ли белая фигура пойти на поле(e, f), не попав при этом под удар черной фигуры.
            // ф) король и ладья.
            if (Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1)
            {
                if (c == e || d == f)
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} попадает под удар черной ладьи на поле {c}, {d}, если пойдёт на поле {e}, {f}.");
                }
                else
                {
                    Console.WriteLine($"Белый король на поле {a}, {b} может пойти на поле {e}, {f}, не попав под удар черной ладьи на поле {c}, {d}.");
                }
            }
            else
            {
                Console.WriteLine($"Белый король на поле {a}, {b} не может пойти на поле {e}, {f}.");
            }
        }
    }
}
