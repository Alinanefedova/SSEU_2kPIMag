using System.Collections.Generic;
 using System.Text;

 
 namespace factorial
 {
    class Program
    {
        static void Main(string[] args)
         {
             int n; 
            int i = 1;
           int f = 1;
            Console.WriteLine("������� ����������� ����� ��� ���������� ����������:");
               if (int.TryParse(Console.ReadLine(), out n))
               while (i < n + 1)
             {
              
               f = f * i;
               Console.WriteLine("{" + f + "}");
                i++;
                };
             
           Console.WriteLine("���������: " + f);
             
            Console.ReadKey();
       }
     }
 }
