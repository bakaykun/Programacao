using static System.Console;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using AulaDoze.Entites.Enums;
using AulaDoze.Entites;

namespace AulaDoze 
{
    class Program 
    {
        static void Main()
        {
            List<Shape> list = new List<Shape>();

            Write("Enter the number of shapes: ");
            int n = int.Parse(ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Write($"Shape {i} data: ");
                Write("Rectangle or Circle (r/c): ");
                char op = char.Parse(ReadLine());
                Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(ReadLine());

                if(op == 'r' || op == 'R')
                {
                    Write("Width: ");
                    double tWidth = double.Parse(ReadLine(), InvariantCulture);
                    Write("Heigth: ");
                    double tHeigth = double.Parse(ReadLine(), InvariantCulture);

                    list.Add(new Rectangle(tWidth, tHeigth, color));

                } 
                else if ( op == 'c' || op == 'C')
                {
                    Write("Radius: ");
                    double tRadius = double.Parse(ReadLine(), InvariantCulture);
                    list.Add(new Clircle(tRadius, color));
                }
                else {
                    Write("Invalid Option");
                    Main();
                }
            }

            Write("   ");
            WriteLine("Shape Areas: ");
            foreach (Shape shape in list)
            {
                WriteLine(shape.Area().ToString("F2", InvariantCulture));
            }
        }
    }
}
