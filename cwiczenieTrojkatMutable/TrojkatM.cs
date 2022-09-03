using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenieTrojkatMutable
{
    class TrojkatM
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get => a;
            set
            {
                Console.WriteLine($"Próbuję wartości A przypisać liczbę {value}");
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                try
                {
                    if (value + b < c || value + c < b || b + c < value)

                        throw new ArgumentException();

                    else
                        a = value;
                }catch(Exception)
                {
                    Console.WriteLine("zaburzenie warunku trójkąta");
                }
            }
        }
        public double B
        {
            get => b;
            set
            {
                Console.WriteLine($"Próbuję wartości B przypisać liczbę {value}");
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                try
                {

                    if (a + value < c || a + c < value || value + c < a)
                        throw new ArgumentException("zaburzenie warunku trójkąta");
                    else
                        b = value;

                }
                catch (Exception)
                {
                    Console.WriteLine("zaburzenie warunku trójkąta");
                }
            }
        }
        public double C
        {
            get => c;
            set
            {
                Console.WriteLine($"Próbuję wartości C przypisać liczbę {value}");
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                try
                {
                    if (a + b < value || a + value < b || b + value < a)
                        throw new ArgumentException("zaburzenie warunku trójkąta");
                    else
                        c = value;

                }
                catch (Exception)
                {
                    Console.WriteLine("zaburzenie warunku trójkąta");
                }
            }
        }
        
        public TrojkatM() : this(1, 1, 1) { }
        public TrojkatM(double a /* lub a=1 */, double b /* lub b=1 */, double c/* lub c=1 */)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("ujemne dane");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("obiekt nie istnieje");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsWarunekTrojkata(double a, double b, double c) => a + b < c || a + c < b || b + c < a;
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

        public override string ToString() => $"\nTrójkąt(A = {a:F2}, B = {b:F2}, C = {c:F2}) \nPole: {Pole:F2} \nObwód: {Obwod:f2} {wypisz()}";

        public void Skala(double skala)
        {
            if (skala > 0)
            {
                a *= skala;
                b *= skala;
                c *= skala;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        //private double dlugoscA = 1;

        //public double A
        //{
        //    get { return dlugoscA; }
        //    set { dlugoscA = value; }
        //}

        //private double dlugoscB = 1;

        //public double B
        //{
        //    get { return dlugoscB; }
        //    set { dlugoscB = value; }
        //}

        //private double dlugoscC = 1;

        //public double C
        //{
        //    get { return dlugoscC; }
        //    set { dlugoscC = value; }
        //}


        //public void ParametryTrojkata() // https://pl.numberempire.com/arbitrary_triangle_calculator.php
        //{
        //    double obwod = A + B + C;
        //    Console.WriteLine($"Obwód: {obwod}");
        //    double p = (A + B + C) / 2;
        //    double pole = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        //    Console.WriteLine($"Pole: {pole}");

        //    if (C * C == A * A + B * B) // c2 = a2 + b2  trójkąt jest prostokątny
        //        Console.WriteLine("Trójkąt jest prostokątny");

        //    else if (C * C > A * A + B * B) // c2 > a2 + b2  trójkąt jest rozwartokątny
        //        Console.WriteLine("Trójkąt jest rozwartokątny");

        //    else if (C * C < A * A + B * B) // c2 < a2 + b2  trójkąt jest ostrokątny
        //        Console.WriteLine("Trójkąt jest ostrokątny");

        //    if (A == B && B == C)
        //        Console.WriteLine("Trójkąt jest równoboczny");
        //    else if (A == B || B == C || C == A)
        //        Console.WriteLine("Trójkąt jest równoramienny");
        //}


    }
}
