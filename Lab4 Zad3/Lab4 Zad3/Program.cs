using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
             string str = Console.ReadLine();
             str = str.Trim();
             int col_slov = 1;
             for (int i = 0; i < str.Length; ++i)
             {
                 if (str[i] != ' ' && str[i] != '.' && str[i] != ',' && str[i] != '-' && str[i] != '?' && str[i] != '!' && str[i] != ';' && str[i] != ':')
                 {
                }
                 else
                 {
                     col_slov = col_slov + 1;
                 };
             }
 
             string[] Array = new string[col_slov];
           char buffer = ' ';
            string buf = str[0].ToString();
             int p = 0;
             for (int j = 0; p < str.Length;)
             {
                 if (str[p] != ' ' && str[p] != '.' && str[p] != ',' && str[p] != '-' && str[p] != '?' && str[p] != '!' && str[p] != ';' && str[p] != ':')
                 {
                     switch (p)
                     {
                         case 0:
                             Array[j] = buf;
                             ++p;
                             break;
                         default:
                             buf = buf + str[p].ToString();
                             Array[j] = buf;
                             ++p;
                             break;
                     }
                 }
                 else
                 {
                     buf = buffer.ToString();
                     ++p;
                     ++j;
                 };
             }
             int max = Convert.ToInt32(Array[0].Length);
             string buf_str = Array[0];

             for (int i = 0; i < col_slov; ++i)
             {
                 if (Array[i].Length > max)
                 {
                     max = Convert.ToInt32(Array[i].Length);
                     buf_str = Array[i];
                 }
             }
             Console.WriteLine("Самое длинное слово состоит из " + (max - 1)+ " букв");
             Console.WriteLine("Это слово: " + buf_str); 
             Console.ReadKey();
        }
    }
}
