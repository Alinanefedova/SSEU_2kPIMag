using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;  
            string txt = "";   
            do
            {
                Console.Clear();
                Console.WriteLine("Строка: " + txt);
                Console.WriteLine("Длина: " + txt.Length);
                Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                Console.WriteLine("\t\t\t╔══════════════════════════╗");
                Console.WriteLine("\t\t\t║           Меню           ║");
                Console.WriteLine("\t\t\t║ 1 - Ввести новую строку  ║");
                Console.WriteLine("\t\t\t║ 2 - Поиск                ║");
                Console.WriteLine("\t\t\t║ 3 - Замена               ║");
                Console.WriteLine("\t\t\t║ 4 - Удаление             ║");
                Console.WriteLine("\t\t\t║ 5 - Вставка              ║");
                Console.WriteLine("\t\t\t║ 6 - Обрезка              ║");
                Console.WriteLine("\t\t\t║ esc - Выход              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════╝");
                key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1': 
                        Console.Clear();
                        Console.WriteLine("Введите новую строку:");
                        txt = Console.ReadLine();
                        break;
                    case '2': 
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для поиска:");
                        string substr = Console.ReadLine();
                        int pos = txt.IndexOf(substr);
                        if (pos >= 0)
                        {
                            Console.WriteLine("Подстрока найдена на символе: " + pos); 
                            Console.Write(txt.Substring(0, pos));  
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(txt.Substring(pos, substr.Length)); 
                            Console.ResetColor();
                            Console.WriteLine(txt.Substring(pos + substr.Length)); 
                        }
                        else
                        {
                            Console.WriteLine("Подстрока не найдена!");
                        };
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '3': 
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для поиска:");
                        string substrOld = Console.ReadLine();
                        Console.WriteLine("Введите подстроку для замены:");
                        string substrNew = Console.ReadLine();
                        txt = txt.Replace(substrOld, substrNew);
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '4': 
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для удаления:");
                        string substrDel = Console.ReadLine();
                        txt = txt.Replace(substrDel, "");
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '5': 
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("Введите подстроку для вставки:");
                        string substrIns = Console.ReadLine();
                        Console.WriteLine("После какого символа вставить:");
                        if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                        {
                            txt = txt.Insert(pos, substrIns);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Номер символа должен быть числом не более длины строки.");
                        };
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                    case '6':
                        Console.Clear();
                        Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                        Console.WriteLine("После какого символа удалить:");
                        if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                        {
                            int len;
                            Console.WriteLine("Сколько символов удалить:");
                            if (int.TryParse(Console.ReadLine(), out len))
                            {
                                txt = txt.Remove(pos, len);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Длина должна быть целым числом.");
                            };
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Номер символа должен быть числом не более длины строки.");
                        };
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                        break;
                };
            }
            while (key != (char)27);
        }
    }
}
