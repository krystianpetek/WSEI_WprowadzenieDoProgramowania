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

        public Prostokat GetBoundingRectangle()
        {
            throw new NotImplementedException();
        }
    }
}
