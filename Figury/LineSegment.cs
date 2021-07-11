using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class LineSegment : Figure, IEquatable<LineSegment>, IMeasurable1D, IMoveable
    {
        public Point StartPoint;
        public Point EndPoint;
        public LineSegment() : this(new Point(0,0), new Point(0,0)) { }

        public LineSegment(Point p1, Point p2) {
            this.StartPoint = p1;
            this.EndPoint = p2;
            Color = System.Drawing.Color.Green;
        }
        public double Length => Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));

        public override string ToString() => $"LineSegment({StartPoint}, {EndPoint})";

        public override void Draw()
        {
            Console.WriteLine($"drawing: {this.Label}, {Color}, Length = {Length}");
        }

        #region implementation of IEquatable<LineSegment>
        public bool Equals(LineSegment other)
        {
            if (other is null) return false;

            return (this.StartPoint == other.StartPoint && this.EndPoint == other.EndPoint) ||
                (this.StartPoint == other.EndPoint && this.EndPoint == other.StartPoint);
        }
        public static bool operator ==(LineSegment s1, LineSegment s2)
        {
            if (s1 is null && s2 is null) return true;
            if (s1 is null && !(s2 is null)) return false;

            return s1.Equals(s2);
        }
        public static bool operator !=(LineSegment s1, LineSegment s2) => !(s1 == s2);
        #endregion

        public void Move(Vector v)
        {
            throw new NotImplementedException();
        }
    }
}
