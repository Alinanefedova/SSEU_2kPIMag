using System;
using System.Collections.Generic;
using System.Text;
 
 namespace Lab_3_dop2
 {
     class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("������� �����");
             int N;
             int sum=0;
             int kol=0;
             if(int.TryParse(Console.ReadLine(),out N)){
 
                 while(N>0){
                     sum = sum + N % 10;
                     N=N/10;
                     kol++;
                 }
                Console.WriteLine("���������� ���� � ����� = "+kol);
                 Console.WriteLine("����� ���� = "+sum);
             }
             else{
                 Console.WriteLine("����� ������� �����������! ������� ����� �����!");
             };
             Console.ReadKey();
         }
     }
 }