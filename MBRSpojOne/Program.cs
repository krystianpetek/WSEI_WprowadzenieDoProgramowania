using System;
using System.Collections.Generic;

namespace MBRSpojOne
{
    public interface IFigura
    {
        Prostokat GetBoundingRectangle();
    }

    public class Kolo : IFigura
    {
        public Punkt SRODEK;
        public double PROMIEN;
        public Kolo(Punkt srodek, double promien)
        {
            SRODEK = srodek;
            PROMIEN = promien;
        }

        public override string ToString() => $"Koło S:{SRODEK.X},{SRODEK.Y} R:{PROMIEN}";
        public Prostokat GetBoundingRectangle()
        {
            var koloX = SRODEK.X;
            var koloY = SRODEK.Y;
            Punkt LG = new Punkt(koloX - PROMIEN, koloY + PROMIEN);
            Punkt PG = new Punkt(koloX + PROMIEN, koloY + PROMIEN);
            Punkt LD = new Punkt(koloX - PROMIEN, koloY - PROMIEN);
            Punkt PD = new Punkt(koloX + PROMIEN, koloY - PROMIEN);
            return new Prostokat(LG, PG, LD, PD);
        }
    }

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

    public class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // LICZBA TESTOW
            for (int i = 0; i < t; i++)
            {
                var lista = new List<IFigura>();
                int n = int.Parse(Console.ReadLine()); // LICZBA OBIEKTÓW W TEŚCIE
                for (int j = 0; j < n; j++)
                {
                    var liniaPrzypadek = Console.ReadLine().Split(" ");
                    switch (liniaPrzypadek[0])
                    {
                        case "p":
                            var pS = new Punkt(
                                double.Parse(liniaPrzypadek[1]),
                                double.Parse(liniaPrzypadek[2]));

                            lista.Add(pS.GetBoundingRectangle());
                            break;

                        case "c":
                            var cS = new Kolo(
                                new Punkt(
                                    double.Parse(liniaPrzypadek[1]),
                                    double.Parse(liniaPrzypadek[2])),
                                double.Parse(liniaPrzypadek[3]));
                        
                            lista.Add(cS.GetBoundingRectangle());
                            break;
                
                        case "l":
                            var lS = new Odcinek(
                                new Punkt(double.Parse(liniaPrzypadek[1]),
                                double.Parse(liniaPrzypadek[2])),
                                new Punkt(double.Parse(liniaPrzypadek[3]),
                                double.Parse(liniaPrzypadek[4])));
                            
                            lista.Add(lS.GetBoundingRectangle());
                            break;
                    }
                }
                MinimumBoundingRectangle(lista);
                Console.ReadLine();
            }
        }
        public static void MinimumBoundingRectangle(IList<IFigura> listaFigur)
        {
            int lewyDolX = 0, lewyDolY = 0;
            int prawaGoraX = 0, prawaGoraY = 0;
            int nowyLewyDolX, nowyLewyDolY;
            int nowaPrawaGoraX, nowaPrawaGoraY;
            for (int i = 0; i < listaFigur.Count; i++)
            {
                var x = listaFigur[i];
                nowyLewyDolX = int.Parse(x.ToString().Split(" ")[1].Split(",")[0]);
                nowyLewyDolY = int.Parse(x.ToString().Split(" ")[1].Split(",")[1]);
                nowaPrawaGoraX = int.Parse(x.ToString().Split(" ")[2].Split(",")[0]);
                nowaPrawaGoraY = int.Parse(x.ToString().Split(" ")[2].Split(",")[1]);

                if (i == 0)
                {
                    lewyDolX = nowyLewyDolX;
                    lewyDolY = nowyLewyDolY;
                    prawaGoraX = nowaPrawaGoraX;
                    prawaGoraY = nowaPrawaGoraY;
                }

                if (nowyLewyDolX < lewyDolX)
                    lewyDolX = nowyLewyDolX;

                if (nowyLewyDolY < lewyDolY)
                    lewyDolY = nowyLewyDolY;

                if (nowaPrawaGoraX > prawaGoraX)
                    prawaGoraX = nowaPrawaGoraX;

                if (nowaPrawaGoraY > prawaGoraY)
                    prawaGoraY = nowaPrawaGoraY;
            }
            Console.WriteLine($"{lewyDolX} {lewyDolY} {prawaGoraX} {prawaGoraY}");
        
        }
    }
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
