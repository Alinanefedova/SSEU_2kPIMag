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
            Console.WriteLine("������� ���������� ����� ��� ������������");
            if (int.TryParse(Console.ReadLine(),out N))
            {
                int Sum=0;
                int i= 0;
                do
                {
                    Console.Write("������� �����:");
                    if(int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x;
                        i++;

                    }
                     else
                    {
                        Console.WriteLine("�������� ��������! ������� ������ ��������!");
                    };
                }
                while(i<N);
                Console.WriteLine("�����:" + Sum);


           }
            else
            {
            Console.WriteLine("�������� ��������! ������� ������ �����!");
            };
            Console.ReadKey();

        }
    }
}