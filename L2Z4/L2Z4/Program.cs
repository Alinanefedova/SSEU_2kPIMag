using System;
using System.Collections.Generic;
using System.Text;

namespace L2Z4
{
    class Program
    {
        static void Main(string[] args)
        {
                        double a;
            double a;
              double b;
              double c;
              Console.WriteLine("Ââĺäčňĺ ńňîđîíó a");
              static void Main(string[] args)
              if ((a < b + c) && (b < a + c) && (c < a + b))
              {
                  Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ íĺâűđîćäĺííűě");
 -                Console.ReadKey();
                 
              }
 
             else
             {
                 Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ âűđîćäĺííűě");
                 Environment.Exit(0);
             };
             if (a == b && b == c && a == c)
             {
                 Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ đŕâíîńňîđîííčě");
             }
             else if (a == b)   
             {
                 Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ đŕâíîáĺäđĺííűě");
             }
             else if (a == c)
             {
                 Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ đŕâíîáĺäđĺííűě");
             }
             else if (b == c)
             {
                 Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ đŕâíîáĺäđĺííűě");
             };

             double tCos;
             if ((a >= b) && (a >= c))
             {

                 tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (b * c));
                 if (tCos > 0)
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ îńňđîóăîëüíűě");
                 }
                 else if (tCos == 0)
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ďđ˙ěîóăîëüíűě");
                 }
                 else
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ňóďîóăîëüíűě");
                 };
 
            }
             else if ((b >= a) && (b >= c))
            {
                 tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                if (tCos > 0)
             {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ îńňđîóăîëüíűě");
                 }
                else if (tCos == 0)
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ďđ˙ěîóăîëüíűě");
                 }
                 else
                 {
                    Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ňóďîóăîëüíűě");
                 };
             }
             else
             {
                 tCos = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * (a * c));
                 if (tCos > 0)
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ îńňđîóăîëüíűě");
                 }
                 else if (tCos == 0)
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ďđ˙ěîóăîëüíűě");
                 }
                 else
                 {
                     Console.WriteLine("Ňđĺóăîëüíčę ˙âë˙ĺňń˙ ňóďîóăîëüíűě");
                 };
 
             }
             double s;
             double p;
             p = a + b + c;
             s = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
             if ((p > 100) && (s > 200))
             {
                 Console.WriteLine("Áîëüřîé ňđĺóăîëüíčę");
             }
             else if ((p < 3) && (s < 1))
             {
                 Console.WriteLine("Áîëüřîé ňđĺóăîëüíčę");
             }
             else 
            {
                Console.WriteLine("Îáű÷íűé ňđĺóăîëüíčę");
            };

             Console.ReadKey();
        }
    }
}
