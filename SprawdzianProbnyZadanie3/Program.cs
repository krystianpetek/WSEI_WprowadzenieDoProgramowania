using System;
using System.Collections.Generic;

namespace FiguryLib
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

        public double Dlugosc =>  Math.Round(Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y)), 2);

        public override string ToString() => $"L({P1}, {P2})";

        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine(this + $" dlugosc={Math.Round(Dlugosc, 2):F2}");
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
        private double promien;
        public double Promien
        {
            get
            {
                return promien;
            }
            set
            {
                if (value < 0)
                    promien = 0;
                else
                {
                    promien = value;
                }
            }
        }
        public Okrag(Punkt p1, int p2 = 1)
        {
            if (p1 == null)
                throw new ArgumentException("Punkt nie może być null");

            if (p2 < 0)
                Promien = 0;
            else
            {
                Promien = p2;
                DefaultColor = ConsoleColor.Cyan;
            }
            Srodek = p1;
        }
        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine(this + $" dlugosc={Math.Round(Dlugosc, 2):F2}");
            Console.ResetColor();

        }
        public override string ToString() => $"O({this.Srodek}, {Promien})";

        public double Dlugosc => Math.Round(2 * Math.PI * Promien, 2);
    }



    public class Kolo : Okrag, IMierzalna2D
    {
        public Kolo() : base(new Punkt(), 2)
        {
        }

        public Kolo(Punkt p1, int p2) : base(p1, p2)
        {
            DefaultColor = ConsoleColor.Red;
        }
        public override string ToString() => $"K({Srodek}, {Promien})";

        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = DefaultColor;
            Console.WriteLine($"K({ Srodek}, { Promien}) obwod={Math.Round(Obwod, 2):F2}, pole={Math.Round(Pole, 2):f2}");
            Console.ResetColor();
        }


        public double Pole => Math.PI * Promien * Promien;

        public double Obwod => 2 * Math.PI * Promien;
    }




    public class Ekran
    {
        private List<Figura> figury = new List<Figura>();
        public void Dodaj(Figura f) => figury.Add(f);
        public void Usun(Figura f) => figury.Remove(f);
        public void Rysuj() => figury.ForEach(f => f.Rysuj());

        public double SumarycznaDlugosc()
        {
            double wynik = 0.0;
            for (int i = 0; i < figury.Count; i++)
            {
                if (figury[i] is Odcinek)
                {
                    var odcinek = figury[i].ToString().Split("(");
                    var punkt1 = odcinek[2].Split(")");
                    var punkt2 = odcinek[3].Split(")");
                    var wyciagnijp1= punkt1[0].ToString().Split(",");
                    var p1x = double.Parse(wyciagnijp1[0]);
                    var p1y = double.Parse(wyciagnijp1[1].Trim());
                    var wyciagnijp2 = punkt2[0].ToString().Split(",");
                    var p2x = double.Parse(wyciagnijp2[0]);
                    var p2y = double.Parse(wyciagnijp2[1].Trim());
                    wynik = Math.Round(Math.Sqrt((p2x - p1x) * (p2x - p1x) + (p2y - p1y) * (p2y - p1y)), 2);

                }
                else if (figury[i] is Kolo)
                {
                    var kolo = figury[i].ToString().Split("(");
                    var punkt1 = kolo[2].Split(")");
                    var promien= double.Parse(punkt1[1].Split(",")[1].Trim());
                    //var p1x = double.Parse(punkt1[0].Split(",")[0].Trim());
                    //var p2y = double.Parse(punkt1[0].Split(",")[1].Trim());
                    wynik += Math.Round((2 * Math.PI * promien),2);
                }

                else if (figury[i] is Okrag)
                {
                    var okrag = figury[i].ToString().Split("(");
                    var punkt1 = okrag[2].Split(")");
                    var promien = double.Parse(punkt1[1].Split(",")[1].Trim());
                    wynik += Math.Round(2 * Math.PI * promien, 2);
                }
            }
            return wynik;
        }
        public double SumarycznePole()
        {
            double wynik = 0.0;
            for (int i = 0; i < figury.Count; i++)
            {
                
                if (figury[i] is Kolo)
                {
                    var kolo = figury[i].ToString().Split("(");
                    var punkt1 = kolo[2].Split(")");
                    var promien = double.Parse(punkt1[1].Split(",")[1].Trim());
                    wynik += Math.Round(Math.PI * promien* promien,2);
                }

            }
            return wynik;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            // Ekran, sumaryczna długość
            Ekran ekran = new Ekran();
            ekran.Dodaj(new Punkt(1, 2));
            ekran.Dodaj(new Odcinek(new Punkt(), new Punkt(1, 1)));
            ekran.Dodaj(new Okrag(new Punkt(1, 1), 2));
            ekran.Dodaj(new Kolo(new Punkt(-1, -1), 3));
            Console.WriteLine("sumaryczna dlugosc = " + ekran.SumarycznaDlugosc());
        }
    }
}
