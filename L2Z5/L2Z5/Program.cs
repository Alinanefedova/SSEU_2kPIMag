using System;
using System.Collections.Generic;
using System.Text;
 
 namespace L2_Z5
 {
     class Program
     {
         static void Main(string[] args)
         {
            
             int money;
             int valuta;
             const int cfunt = 77;
            const int cevro = 65;
            const int cdollar = 63;

             Console.WriteLine("Ââåäèòå ðóáëè äëÿ ïåðåâîäà â äðóãóþ âàëþòó");
             if (int.TryParse(Console.ReadLine(), out money)) 
            {
                 Console.WriteLine("Íàïèøèòå íîìåð âàëþòû:");
                Console.WriteLine("1 äëÿ äîëëàðà");
                 Console.WriteLine("2 äëÿ ôóíòîâ;");
                 Console.WriteLine("3 äëÿ åâðî;");
                 Console.WriteLine("4 äëÿ éåíû.");
                 int.TryParse(Console.ReadLine(), out valuta);
                 //âûáîð âàëþòû
                 switch (valuta)
                 {
                     case 1 :
                         double dollar = money / cdollar;
                         Console.WriteLine(dollar + " äîëëàðà/äîëëàð/äîëëàðîâ.");
                        break;
                    case 2:
                        double funt = money / cfunt;
                        Console.WriteLine(funt + " ôóíò.");
                         break;
                     case 3:
                         double evro = money / cevro;
                         Console.WriteLine(evro + " åâðî.");
                         break;
                     case 4:
                         Console.WriteLine(money + " éåíû.");
                         break;
                   default :
                         Console.WriteLine("Íå ââåäåíî ÷èñëî.");
                        break;
                };
             }
             else
             {
                Console.WriteLine("Íåâåðíîå çíà÷åíèå! Ââåäèòå öåëîå ÷èñëî.");
             };
             Console.ReadKey();
}
}
}

