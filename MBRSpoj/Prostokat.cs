using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRSpoj
{
    public class Prostokat : IFigura
    {
        public Punkt P1, P2, P3, P4;
        public Prostokat(Punkt p1, Punkt p2, Punkt p3, Punkt p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }

        public override string ToString() => $"{P1} {P3} {P2} {P4}";
        public Prostokat GetBoundingRectangle()
        {
            return new Prostokat(P1, P2, P3, P4);
        }
    }
}
