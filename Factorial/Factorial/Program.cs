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
            Console.WriteLine("Введите колличество чисел для вычисления факториала:");
               if (int.TryParse(Console.ReadLine(), out n))
               while (i < n + 1)
             {
              
               f = f * i;
               Console.WriteLine("{" + f + "}");
                i++;
                };
             
           Console.WriteLine("Факториал: " + f);
             
            Console.ReadKey();
       }
     }
 }
