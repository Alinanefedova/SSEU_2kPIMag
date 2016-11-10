using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumTernarOperator
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

                    int Max = (A >= B) ? A : B;

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
        }
    }
}
