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
        //readonly double A;
        //readonly double B;
        //readonly double C;

        public Trojkat() : this(1, 1, 1) { }

        public Trojkat(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("ujemne dane");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("obiekt nie istnieje");
            this.a = a;
            this.b = b;
            this.c = c;
        }
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



        public double Obwod => a + b + c;
        //public void Obwod()
        //{
        //    Console.WriteLine($"Obwód: {a+b+c}");
        //}

        public double Pole
        {
            get
            {
                double p = Obwod / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
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

        public bool IsProstokatny => (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a);

        public override string ToString() => $"Trójkąt({a:F2}, {b:F2}, {c:F2}) Pole: {Pole:F2}, Obwód: {Obwod:f2}";
        
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
