using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenieTrojkat
{
    class Trojkat
    {
        private double dlugoscA, dlugoscB, dlugoscC;

        public double A
        {
            get { return dlugoscA; }
            private set { dlugoscA = value; }
        }
        public double B
        {
            get { return dlugoscB; }
            private set { dlugoscB = value; }
        }
        public double C
        {
            get { return dlugoscC; }
            private set { dlugoscC = value; }
        }

        public Trojkat(string a, string b, string c)
        {
            int aParse;
            int bParse;
            int cParse;
            try
            {
                if(!int.TryParse(a, out aParse))
                {
                    aParse = 1;
                }
                if (aParse < 0)
                    throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
                A = aParse;
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
                A = 1;
            }
            try
            {
                if (!int.TryParse(b, out bParse))
                {
                    bParse = 1;
                }
                if (bParse < 0)
                    throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
                B = bParse;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
                B = 1;
            }

            try
            {
                if (!int.TryParse(c, out cParse))
                {
                    cParse = 1;
                }
                if (cParse < 0)
                    throw new ArgumentOutOfRangeException("zgłaszam wyjątek");
                C = cParse;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wprowadzono złą wartość, przyjmuje wartość domyślną 1");
                C = 1;
            }

        }

        public void PolePowierzchni()
        {
            double P = (A + B + C) / 2;
            double Oblicz = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            if(double.IsNaN(Oblicz))
                Console.WriteLine($"Nie można obliczyć pola");
            else
            {
                Console.WriteLine($"Pole: {Oblicz}");
            }
        }
        public void Obwod()
        {
            Console.WriteLine($"Obwód: {A + B + C}");
        }
        public void SprawdzTrojkat()
        {
            if ((A * A) + (B * B) == (C * C))
            {
                Console.WriteLine("Trojkąt jest prostokątny");
            
            }

            if ((C * C) > (A * A) + (B * B))

            {
                Console.WriteLine("Trójkąt jest rozwartokątny");
            }
            if ((C * C) < (A * A) + (B * B))
            {
                Console.WriteLine("Trójkąt jest ostrokątny");
            }


            if (A == B && B == C && A == C)
            {
                Console.WriteLine("Trójkąt jest równoboczny");
                return;
            }

            if (A == B || B == C || C == A)
            {
                Console.WriteLine("Trójkąt jest równoramienny");
                return;
            }
        }
    }
}
