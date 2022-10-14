using System;

namespace ecuation
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double a, b, c, D;
                Console.WriteLine("Введите а");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Введите a != 0");
                    continue;
                }

                else
                    Console.WriteLine("Введите b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите c");
                c = Convert.ToDouble(Console.ReadLine());

                D = (b * b) - 4 * a * c;

                if (D < 0)
                    Console.WriteLine("Нет решений");
                else if (D == 0)
                    Console.WriteLine($"x = {-b / (2 * a)}");
                else if (D > 0)
                {
                    Console.WriteLine($"x1 = {-b + Math.Sqrt(D) / (2 * a)}");
                    Console.WriteLine($"x2 = {-b - Math.Sqrt(D) / (2 * a)}");
                }
            }
        }
    }
}
