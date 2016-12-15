using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            onsole.WriteLine("¬ведите слово или фразу");
 +            string str = Console.ReadLine();
 +            str = str.ToLower();
 +            string[] array = str.Split(' ');
 +            string str2 = array[0];
 +            for (int i = 1; i < array.Length; ++i)
 +            {
 +                str2 = str2 + array[i];
 +            }
 +        
 +            int end = str2.Length;// последний символ в строке
 +            int buf = str2.Length-1;//последний индек массива
 +            int col = str2.Length % 2;//дл€ определени€ чет/нечет
 +            switch (col)
 +            {
 +                case 0://если четное кол-во символов
 +                    for (int i = 0; i < buf; ++i)
 +                    {
 +                        if (str2[i] == str2[buf])
 +                        {
 +                            buf--;
 +                            if(i+1 > buf)
 +                                Console.WriteLine("Ёто палиндром!");
 +                        }
 +                        else
 +                        {
 +                            Console.WriteLine("Ќе €вл€етс€ палиндромом ");
 +                            
 +                        }
 +                    }
 +                    break;
 +                default:// если нечетное
 +                    for (int i = 0; i != buf; ++i)
 +                    {
 +                        if (str2[i] == str2[buf])
 +                        {
 +                            buf--;
 +                            if ((i + 1) == buf)
 +                                Console.WriteLine("Ёто палиндром!");
 +                        }
 +                        else
 +                        {
 +                            Console.WriteLine("Ќе €вл€етс€ палиндромом ");
 +                        }
 +                    }
 +                    break;
 +            }
 +            Console.ReadKey();
        }
    }
}
