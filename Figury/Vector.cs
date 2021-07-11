using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public struct Vector
    {
        const int FRACTIONAL_DIGITS = 4;
        public readonly double X;
        public readonly double Y;
        public Vector(double x, double y)
        {
            this.X = Math.Round(x,FRACTIONAL_DIGITS);
            this.Y = Math.Round(y, FRACTIONAL_DIGITS);
        }

    }
}
