using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            onsole.WriteLine("������� ����� ��� �����");
 +            string str = Console.ReadLine();
 +            str = str.ToLower();
 +            string[] array = str.Split(' ');
 +            string str2 = array[0];
 +            for (int i = 1; i < array.Length; ++i)
 +            {
 +                str2 = str2 + array[i];
 +            }
 +        
 +            int end = str2.Length;// ��������� ������ � ������
 +            int buf = str2.Length-1;//��������� ����� �������
 +            int col = str2.Length % 2;//��� ����������� ���/�����
 +            switch (col)
 +            {
 +                case 0://���� ������ ���-�� ��������
 +                    for (int i = 0; i < buf; ++i)
 +                    {
 +                        if (str2[i] == str2[buf])
 +                        {
 +                            buf--;
 +                            if(i+1 > buf)
 +                                Console.WriteLine("��� ���������!");
 +                        }
 +                        else
 +                        {
 +                            Console.WriteLine("�� �������� ����������� ");
 +                            
 +                        }
 +                    }
 +                    break;
 +                default:// ���� ��������
 +                    for (int i = 0; i != buf; ++i)
 +                    {
 +                        if (str2[i] == str2[buf])
 +                        {
 +                            buf--;
 +                            if ((i + 1) == buf)
 +                                Console.WriteLine("��� ���������!");
 +                        }
 +                        else
 +                        {
 +                            Console.WriteLine("�� �������� ����������� ");
 +                        }
 +                    }
 +                    break;
 +            }
 +            Console.ReadKey();
        }
    }
}
