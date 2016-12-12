using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¬ведите им€: ");
            string imya = Console.ReadLine();
            Console.Write("¬ведите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.Write("¬ведите фамилию: ");
            string familiya = Console.ReadLine();
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine(imya[0].ToString().ToUpper() + ". " 
                                  + otchestvo[0].ToString().ToUpper() + ". " 
                                  + familiya[0].ToString().ToUpper() 
                                  + familiya.Substring(1).ToLower()); 
            }
            else 
            {
                Console.WriteLine(imya[0].ToString().ToUpper() + ". " 
                                  + familiya[0].ToString().ToUpper()  
                                  + familiya.Substring(1).ToLower()); 
            };
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine(familiya[0].ToString().ToUpper()
                                  + familiya.Substring(1).ToLower() + " " 
                                  + imya[0].ToString().ToUpper() + "." 
                                  + otchestvo[0].ToString().ToUpper() + "."); 
            }
            else
            {
                Console.WriteLine(familiya[0].ToString().ToUpper() 
                                  + familiya.Substring(1).ToLower() + " "  
                                  + imya[0].ToString().ToUpper() + ".");   
            };
            if (!string.IsNullOrEmpty(otchestvo)) 
            {
                Console.WriteLine(imya[0].ToString().ToUpper()  
                                  + imya.Substring(1).ToLower() + " "  
                                  + otchestvo[0].ToString().ToUpper() 
                                  + otchestvo.Substring(1).ToLower() + " " 
                                  + familiya.ToUpper());  
            }
            else 
            {
               
                Console.WriteLine(imya[0].ToString().ToUpper()  
                                  + imya.Substring(1).ToLower() + " " 
                                  + familiya.ToUpper());
            };
            if (!string.IsNullOrEmpty(otchestvo)) 
            {
                Console.WriteLine((familiya.Substring(0, 3) + "_" 
                                  + imya.Substring(0, 1) + "_" 
                                  + otchestvo.Substring(0, 1)).ToLower()); 
            }
            else 
            {
                Console.WriteLine((familiya.Substring(0, 3) + "_"
                                  + imya.Substring(0, 1)).ToLower()); 
            };

            Console.ReadKey();
        }
    }
}
