using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Wheel : Circle
    {
        public Wheel() : this(new Point(), 1)
        {
        }
        public Wheel(Point punkt, double r) : base(punkt, r)
        {
            Color = System.Drawing.Color.Magenta;
            this.Promien = r;
            this.Srodek = punkt;
        }
        public double Circumference => Math.Round(Length, 2);

        public double Surface => Math.Round(Math.PI * Math.Pow(Promien,2),2);

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this}, {Color}, Circumference = {Circumference}, Surface = {Surface}");
        }
        public override string ToString() => $"Wheel( {Srodek} {Promien} )";
    

    }
}
