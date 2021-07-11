using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalnyProstokatOtaczajacy
{
    public class Punkt : IFigura
    {
        public readonly double X;
        public readonly double Y;
        public Punkt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Punkt() : this(0, 0)
        {

        }
        //public override string ToString() => $"Punkt X: {X}, Y: {Y}";
        public override string ToString() => $"{X},{Y}";
        public Prostokat GetBoundingRectangle()
        {
            Punkt LG = new Punkt(X, Y);
            Punkt PG = new Punkt(X, Y);
            Punkt LD = new Punkt(X, Y);
            Punkt PD = new Punkt(X, Y);
            return new Prostokat(LG, PG, LD, PD);
        }
}
}
