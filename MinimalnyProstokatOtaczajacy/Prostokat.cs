using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalnyProstokatOtaczajacy
{
    public class Prostokat : IFigura
    {
        public Punkt P1, P2, P3, P4;
        public Prostokat(Punkt p1,Punkt p2, Punkt p3, Punkt p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }
        public Prostokat(): this(new Punkt(0, 0), new Punkt(0, 0), new Punkt(0,0),new Punkt(0,0))
        { }

        public void Draw()
        {
            Console.Write($"{GetType().Name}");
            Console.Write($"\nLewa góra: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(P1);
            Console.ResetColor();
            Console.Write($"\nPrawa góra: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(P2);
            Console.ResetColor();
            Console.Write($"\nLewy dół: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(P3);
            Console.ResetColor();
            Console.Write($"\nPrawy dół: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(P4);
            Console.ResetColor();
            Console.WriteLine();
        }
        public override string ToString() => $"Prostokąt {P1}, {P2}, {P3}, {P4}";
        //public override string ToString() => $"{P1} {P3} {P2} {P4}";
        public Prostokat GetBoundingRectangle()
        { 
            return new Prostokat(P1, P2, P3, P4);
        }
    }
}
