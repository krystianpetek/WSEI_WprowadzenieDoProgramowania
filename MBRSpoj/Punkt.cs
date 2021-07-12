using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRSpoj
{
    public class Punkt : IFigura
    {
        public double X;
        public double Y;
        public Punkt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
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
