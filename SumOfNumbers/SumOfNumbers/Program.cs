using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int x;
            Console.WriteLine("Введите количество чисел для суммирования");
            if (int.TryParse(Console.ReadLine(),out N))
            {
                int Sum=0;
                int i= 0;
                do
                {
                    Console.Write("Введите число:");
                    if(int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x;
                        i++;

                    }
                     else
                    {
                        Console.WriteLine("Неверное значение! Введите целове значение!");
                    };
                }
                while(i<N);
                Console.WriteLine("Сумма:" + Sum);


           }
            else
            {
            Console.WriteLine("Неверное значение! Введите целове число!");
            };
            Console.ReadKey();

        }
    }
}