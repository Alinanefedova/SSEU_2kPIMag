using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRectangle
{
    class Program
    {
           class Rectangle
    {
        public double x1, y1; 
        public double x2, y2; 

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }
       
        public double Width()
        {
            return Math.Abs(x2 - x1);
        }
       
        public double Height()
        {
            return Math.Abs(y2 - y1);
        }
       
        public double P()
        {
            
            return 2 * (Width() + Height());
        }
       
        public double S()
        {
           
            return Width() * Height();
        }
        
        public bool IsSquare()
        {
          
            return Width() == Height();
        }
        
        public void Move(double x, double y)
        {
            x1 += x; x2 += x;
            y1 += y; y2 += y;
        }
        
        public void SetWidth(double newWidth)
        {
            x2 = x1 + newWidth;
        }
      
        public void SetHeight(double newHeight)
        {
            y2 = y1 + newHeight;
        }
    }

    class Rect
    {

        static double ReadCoord(string message)
        {
            double coord;
            Console.Write("Введите координату " + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите число: ");
            };
            return coord;
        }

        static void Main(string[] args)
        {
            Rectangle r; 
            Console.WriteLine("Создание прямоугольника.");
 
            r = new Rectangle(ReadCoord("х верхнего левого угла: "),
                              ReadCoord("y верхнего левого угла: "),
                              ReadCoord("х нижнего правого угла: "),
                              ReadCoord("y нижнего правого угла: "));
            char key; 
            do
            {
                Console.Clear(); 
               
                Console.WriteLine("Верхний левый угол: х = " + r.x1 + ", y = " + r.y1);
                Console.WriteLine("Нижний правый угол: х = " + r.x2 + ", y = " + r.y2);
                Console.WriteLine("Ширина прямоугольника = " + r.Width());
                Console.WriteLine("Высота прямоугольника = " + r.Height());
                Console.WriteLine("Периметр прямоугольника = " + r.P());
                Console.WriteLine("Площадь прямоугольника = " + r.S());
              
                Console.WriteLine("\t\t\t╔═════════════════════════════╗");
                Console.WriteLine("\t\t\t║             МЕНЮ            ║");
                Console.WriteLine("\t\t\t║ a - является ли квадратом?  ║");
                Console.WriteLine("\t\t\t║ b - переместить             ║");
                Console.WriteLine("\t\t\t║ c - изменить ширину         ║");
                Console.WriteLine("\t\t\t║ d - изменить высоту         ║");
                Console.WriteLine("\t\t\t║ ESC - выход                 ║");
                Console.WriteLine("\t\t\t╚═════════════════════════════╝");

               
                key = Console.ReadKey().KeyChar;
            
                switch (key)
                {
                    case 'a':
                        Console.Clear();
                        if (r.IsSquare())
                            Console.WriteLine("Квадрат (" + r.Width() + " = " + r.Height() + ")");
                        else
                            Console.WriteLine("Не квадрат (" + r.Width() + " != " + r.Height() + ")");
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'b': 
                        Console.Clear();
                        r.Move(ReadCoord(" по х: "), ReadCoord(" по y: "));
                        Console.ReadKey();
                        break;
                    case 'c':
                        Console.Clear();
                        Console.WriteLine("Какую установить ширину?");
                        r.SetWidth(ReadCoord(""));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'd': 
                        Console.Clear();
                        Console.WriteLine("Какую установить высоту?");
                        r.SetHeight(ReadCoord(""));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                };
            }
            while (key != (char)27);
        }
   
    }
    }
}


