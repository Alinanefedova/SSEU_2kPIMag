using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumC
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            int Max;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B)
                && int.TryParse(Console.ReadLine(), out C))
            {
                if (A >= B)
                {
                    if (A >= C)
                    {
                        Max = A;
                    }
                    else
                    {
                        Max = C;
                    };
                }
                else
                {
                    if (B >= C)
                    {
                        Max = B;
                    }
                    else
                    {
                        Max = C;
                    };
                };
                Console.WriteLine("Максимальное=" + Max);
            }
            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести целое число.");
            };
            Console.ReadKey();
        }
    }
}
