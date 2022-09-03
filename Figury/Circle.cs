using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Circle : Figure, IMeasurable1D, IMoveable
    {
        public Point Srodek;
        private double promien;
        public double Promien
        {
            get => promien;
            set
            {
                if (value < 0)
                    throw new ArgumentException("liczba ujemna");
                promien = Math.Round(value, Figure.FRACTIONAL_DIGITS);
            }
        }
        public double Length => Math.Round(2 * Math.PI * Promien,2);
        public Circle(Point punkt, double r)
        {
            this.Srodek = punkt;
            this.Promien = r;
            Color = System.Drawing.Color.Cyan;
        }
        public Circle() : this(new Point(0,0),1)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("drawing: "+$"{this} {Color} Length: {Length}");
        }
        public bool Equals(Circle other)
        {
            if (other is null) return false;
            return (this.Promien == other.Promien && this.Srodek == other.Srodek);
        }
        static public bool operator ==(Circle c1, Circle c2)
        {
            if (c1 is null && c2 is null) return true;
            if (c1 is null && !(c2 is null)) return false;

            return c1.Equals(c2);
        }
        static public bool operator !=(Circle c1, Circle c2) => !(c1 == c2);
        public override string ToString() => $"Circle({Srodek}, {Promien})";

        public void Move(Vector v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Przesuwam {this.Label} o wektor [{v.X},{v.Y}]");
            Console.ResetColor();
            Srodek = new Point(Srodek.X + v.X,Srodek.Y+ v.Y);
        }
    }
}
