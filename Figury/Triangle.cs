using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Triangle : Figure, IMeasurable2D
    {
        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }

        double Aa, Bb, Cc;

        public Triangle(Point a, Point b, Point c)
        {
            Aa = (Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2)));
            Bb = (Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2)));
            Cc = (Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));

            if (Cc < Aa + Bb)
                C = c;
            if (Bb < Aa + Cc)
                B = b;
            if (Aa < Bb + Cc)
                A = a;

            /*
            if (  (Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)))< //C 
                (Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2)))+ //A
                (Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2)))) //B 
            C = c;

            if ((Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2)))< //B 
                 (Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2)))+ //A
                (Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)))) //C
            B = b;

            if ((Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2)))< //A
                (Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2)))+ //B
                (Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)))) //C
            A = a;
            */

            if (A == null || B == null || C == null)
            {
                throw new ArgumentException("Błędne dane");
            }
        }

        public double Circumference => Length;

        public double Surface => Math.Round(Math.Sqrt((Length / 2) * (Length / 2 - Aa) * (Length / 2 - Bb) * (Length / 2 - Cc)), 2);

        public double Length
        {
            get
            {
                double dlugosc = 0;
                dlugosc = Aa + Bb + Cc;

                /*dlugosc += Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2));
                dlugosc += Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));*/

                return dlugosc;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Circumference = {Math.Round(Circumference,2):F2} Surface = {Math.Round(Surface,2):F2}");
        }
    }
}
