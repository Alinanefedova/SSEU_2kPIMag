using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand = 0;//�������� ��������
             Console.Write("������� ����������: ");
             while (!double.TryParse(Console.ReadLine(), out operand))
             {
                 Console.Write("�������� ��������! ������� �����: ");
             };
             return operand;
         }

         static void Main(string[] args)
         {
             Console.Write("������� ��������� ������ ���������? ");
             int kol_vystrel;
             double itog=0;
             int.TryParse(Console.ReadLine(), out kol_vystrel);
             double[] a = new double[kol_vystrel];
             double[] b = new double[kol_vystrel];
             double[] R = new double[kol_vystrel];
             double[] ochki = new double[kol_vystrel];
             
             for (int i=0;i< kol_vystrel; ++i)
             {
                 double buf = 0;
                 double x;
                 x = ReadOperand();
                 double y;
                 y = ReadOperand();
                 a[i] = x;
                 b[i] = y;
                 if (x*x+y*y<=25)
                 {
                     buf = 100;
                     R[i] = x * x + y * y;
                 }
                if((x * x + y * y > 25)&& (x * x + y * y <= 100))
                 {
                    buf = 50;
                     R[i] = x * x + y * y;
                 }
                 if((x * x + y * y > 100) && (x * x + y * y <= 225))
                 {
                     buf = 20;
                     R[i] = x * x + y * y;
                 }
                 if ((x * x + y * y > 225) && (x * x + y * y <= 625))
                 {
                     buf = 10;
                     R[i] = x * x + y * y;
                 }
                 if ((x * x + y * y) == 900)
                 {
                     buf = 5;
                     R[i] = x * x + y * y;
                 }
                 if (x * x + y * y > 625)
                 {
                     Console.WriteLine("�� �� ������ � ������" + "\n");
                     buf = 0;
                     R[i] = x * x + y * y;
                 }
                 Console.WriteLine("���� �� �������: " + buf + "\n");
                 ochki[i] = buf;
                 itog = itog + buf;
             }
             double min = R[2];

            for (int i = 0; i < R.Length; ++i)
            {
                 if (R[i] < min)
                 {
                     min = R[i];
                 }
             }
             Console.WriteLine("����������� ������: " + min + "\n");
             for (int i=0; i< kol_vystrel; ++i)
             {
                 if (min == a[i] * a[i] + b[i] * b[i])
                 {
                     Console.WriteLine("�������� ������� � ������ ������� � ������������: " + a[i]+";" +b[i]+ "\n");
                 }
             }

             for (int i = 0; i < kol_vystrel; ++i)
             {
                 Console.WriteLine("������� �"+(i+1)+" � ������������: " +"("+ a[i] + " ; " + b[i] + ")" + "   ���� �� �������: " + ochki[i]+"\n");
             }
             Console.WriteLine("����� �������: " + itog + " �����");
             Console.ReadKey();
        }
    }
}
