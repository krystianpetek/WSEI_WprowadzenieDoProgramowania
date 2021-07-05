using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Circle : Figure, IMeasurable1D
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
        public double Length => 2 * Math.PI * Promien;
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

    }
}
