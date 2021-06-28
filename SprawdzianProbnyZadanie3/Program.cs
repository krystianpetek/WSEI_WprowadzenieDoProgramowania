using System;

namespace FiguryLab
{
    public interface IMierzalna1D
    {
        double Dlugosc { get; }
    }

    public interface IMierzalna2D : IMierzalna1D
    {
        double Pole { get; }
        double Obwod { get; }
    }

    abstract public class Figura
    {
        public ConsoleColor DefaultColor { get; protected set; } = ConsoleColor.Black;
        // wypisuje na konsolę figurę
        public virtual void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine(this);
            Console.ResetColor();
        }
    }

    // immutable
    public class Punkt : Figura, IEquatable<Punkt>
    {
        public readonly int X, Y;
        public Punkt(int x = 0, int y = 0) { X = x; Y = y; }
        public override string ToString() => $"P({X}, {Y})";
        public bool Equals(Punkt other) =>
            other != null && X == other.X && Y == other.Y;
    }

    public class Odcinek : Figura, IMierzalna1D, IEquatable<Odcinek>
    {
        public Punkt P1 { get; private set; }
        public Punkt P2 { get; private set; }

        public Odcinek() : this(new Punkt(), new Punkt())
        { }

        public Odcinek(Punkt p1, Punkt p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Punkt nie może być null");
            P1 = p1; P2 = p2;
            DefaultColor = ConsoleColor.Blue;
        }

        public double Dlugosc =>
            Math.Round(Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y)), 2);

        public override string ToString() => $"L({P1}, {P2})";

        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine(this + $" dlugosc={Dlugosc:F2}");
            Console.ResetColor();
        }

        public bool Equals(Odcinek other) =>
            other != null && P1 == other.P1 && P2 == other.P2;
    }

    public class Okrag : Figura, IMierzalna1D
    {
        public Okrag() : this(new Punkt(), 1)
        {
        }

        public Punkt Srodek { get; set; }
        public double Promien;
        public Okrag(Punkt p1, int p2 = 1)
        {
            if (p1 is null)
                throw new ArgumentException("Punkt nie może być null");
            else
                Srodek = p1;
            if (p2 < 0)
                Promien = 0;
            else
            {
                Promien = p2;
                DefaultColor = ConsoleColor.Cyan;
            }
        }
        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine(this + $" dlugosc={Dlugosc:F2}");
            Console.ResetColor();




        }
        public override string ToString() => $"O({Srodek}, {Promien})";

        public double Dlugosc => throw new NotImplementedException();
    }


    class Program
    {
        static void Main(string[] args)
        {
            // klasa Okrag, modyfikacje
            Okrag o;
            try
            {
                o = new Okrag(null, -1);
                Console.WriteLine(o);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            o = new Okrag(new Punkt(1, 1), 1);
            Console.WriteLine(o);
            o.Srodek = new Punkt(0, 0);
            o.Promien = 5;
            o.Rysuj();
            o.Promien = -1;
            o.Rysuj();
        }
    }
}
