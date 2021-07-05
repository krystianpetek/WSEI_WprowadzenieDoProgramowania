using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Wheel : Circle, IMeasurable2D
    {
        public Wheel() : this(new Point(0, 0), 1)
        {
        }
        public Wheel(Point punkt, double r) : base(punkt, r)
        {
            Color = System.Drawing.Color.Magenta;
            this.Promien = r;
            this.Srodek = punkt;
        }
        public double Circumference => Length;

        public double Surface => Math.Round(Math.PI * Math.Pow(Promien,2), FRACTIONAL_DIGITS);

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Circumference = {Circumference}, Surface = {Surface}");
        }
        public override string ToString() => $"Wheel( {Srodek} {Promien} )";
    }
}
