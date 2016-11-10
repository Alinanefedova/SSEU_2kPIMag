using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumAndNevernoeChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {

                    int Max;

                    if (A >= B)
                    {
                        Max = A;
                    }
                    else
                    {
                        Max = B;
                    };
                    Console.WriteLine("Максимальное=" + Max);
                }
                else
                {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число!");

                };
            }

            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести целое число.");
            };
            Console.ReadKey();
        }
    }
}
