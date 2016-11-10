using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSumZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            int.TryParse(Console.ReadLine(), out C);
            int F = C * 9 / 5 + 32;
            Console.WriteLine(C + " * 9 / 5 + 32 = " + F);
            Console.ReadKey();
        }
    }
}
