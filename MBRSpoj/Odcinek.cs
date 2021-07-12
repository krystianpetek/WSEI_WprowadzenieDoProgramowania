using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRSpoj
{
    public class Odcinek : IFigura
    {
        public Punkt P1;
        public Punkt P2;
        public Odcinek(Punkt p1, Punkt p2)
        {
            P1 = p1;
            P2 = p2;
        }
        public override string ToString() => $"Odcinek {P1}, {P2}";
        public Prostokat GetBoundingRectangle()
        {
            double Pro1X = 0, Pro2X = 0, Pro3X = 0, Pro4X = 0;
            double Pro1Y = 0, Pro2Y = 0, Pro3Y = 0, Pro4Y = 0;
            if (P2.X > P1.X)
            {
                Pro1X = P1.X;
                Pro2X = P2.X;
                Pro3X = P1.X;
                Pro4X = P2.X;
            }
            else if (P2.X < P1.X)
            {
                Pro1X = P2.X;
                Pro2X = P1.X;
                Pro3X = P2.X;
                Pro4X = P1.X;
            }
            else
            {
                Pro2X = P1.X;
                Pro3X = P2.X;
            }

            if (P2.Y > P1.Y)
            {
                Pro1Y = P2.Y;
                Pro2Y = P2.Y;
                Pro3Y = P1.Y;
                Pro4Y = P1.Y;
            }
            else if (P2.Y < P1.Y)
            {
                Pro1Y = P1.Y;
                Pro2Y = P1.Y;
                Pro3Y = P2.Y;
                Pro4Y = P2.Y;
            }
            else
            {
                Pro2Y = P1.Y;
                Pro3Y = P2.Y;
            }
            return new Prostokat(new Punkt(Pro1X, Pro1Y), new Punkt(Pro2X, Pro2Y), new Punkt(Pro3X, Pro3Y), new Punkt(Pro4X, Pro4Y));
        }
    }
}
