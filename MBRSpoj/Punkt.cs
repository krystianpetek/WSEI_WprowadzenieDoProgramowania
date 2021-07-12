using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRSpoj
{
    public class Punkt : IFigura
    {
        public int X;
        public int Y;
        public Punkt(int x, int y)
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
