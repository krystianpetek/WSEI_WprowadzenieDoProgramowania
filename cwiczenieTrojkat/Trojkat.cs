using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenieTrojkat
{
    class Trojkat
    {
        readonly double a;
        readonly double b;
        readonly double c;

        public Trojkat() : this(1, 1, 1) { }

        public Trojkat(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("ujemne dane");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("obiekt nie istnieje");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Obwod => a + b + c;

        public double Pole
        {
            get
            {
                double p = Obwod / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public bool IsProstokatny => (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a);

        public bool IsRozwartokatny => (c * c > c * c + b * b || c * a > c * c + b * b || b * b > a * a + c * c);

        public bool IsOstrokatny => (c * c < a * a + b * b || b * b < a * a + c * c || a * a < b * b + c * c);

        public bool IsRownoboczny => (a == b && b == c && a == c);

        public bool IsRownoramienny => (a == b || b == c || c == a);

        public string wypisz()
        {
            string wynik = "";
            if (IsProstokatny == true)
                wynik += "\nTrójkąt jest prostokątny";
            else if (IsRozwartokatny == true)
                wynik += "\nTrójkąt jest rozwartokątny";
            else if (IsOstrokatny == true)
                wynik += "\nTrójkąt jest ostrokątny";

            if (IsRownoboczny == true)
                wynik += "\nTrójkąt jest równoboczny";
            else if (IsRownoramienny == true)
                wynik += "\nTrójkąt jest równoramienny";

            return wynik;
        }
        public override string ToString() => $"Trójkąt(A = {a:F2}, B = {b:F2}, C = {c:F2}) \nPole: {Pole:F2} \nObwód: {Obwod:f2} {wypisz()}";

        //readonly double A;
        //readonly double B;
        //readonly double C;
        //public Trojkat(string a, string b, string c)
        //{
        //    double aParse;
        //    double bParse;
        //    double cParse;
        //    try
        //    {
        //        if(!double.TryParse(a, out aParse))
        //        {
        //            aParse = 1;
        //        }
        //        if (aParse < 0)
        //            throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
        //        A = aParse;
        //    }
        //    catch(ArgumentException)
        //    {
        //        Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
        //        A = 1;
        //    }
        //    try
        //    {
        //        if (!double.TryParse(b, out bParse))
        //        {
        //            bParse = 1;
        //        }
        //        if (bParse < 0)
        //            throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
        //        B = bParse;
        //    }
        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
        //        B = 1;
        //    }

        //    try
        //    {
        //        if (!double.TryParse(c, out cParse))
        //        {
        //            cParse = 1;
        //        }
        //        if (cParse < 0)
        //            throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
        //        C = cParse;
        //    }
        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
        //        C = 1;
        //    }

        //}
        //public void Obwod()
        //{
        //    Console.WriteLine($"Obwód: {a+b+c}");
        //}
        //public void PolePowierzchni()
        //{
        //    double P = (A + B + C) / 2;
        //    double Oblicz = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        //    if(double.IsNaN(Oblicz))
        //        Console.WriteLine($"Nie można obliczyć pola");
        //    else
        //    {
        //        Console.WriteLine($"Pole: {Oblicz}");
        //    }
        //}
        //public void SprawdzTrojkat()
        //{
        //    if ((A * A) + (B * B) == (C * C))
        //    {
        //        Console.WriteLine("Trojkąt jest prostokątny");
        //    }
        //    if ((C * C) > (A * A) + (B * B))
        //    {
        //        Console.WriteLine("Trójkąt jest rozwartokątny");
        //    }
        //    if ((C * C) < (A * A) + (B * B))
        //    {
        //        Console.WriteLine("Trójkąt jest ostrokątny");
        //    }
        //    if (A == B && B == C && A == C)
        //    {
        //        Console.WriteLine("Trójkąt jest równoboczny");
        //        return;
        //    }
        //    if (A == B || B == C || C == A)
        //    {
        //        Console.WriteLine("Trójkąt jest równoramienny");
        //        return;
        //    }
        //}
    }
}
