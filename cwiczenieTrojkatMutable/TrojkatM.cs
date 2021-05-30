using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenieTrojkatMutable
{
    class TrojkatM
    {
        private double dlugoscA = 1;

        public double A
        {
            get { return dlugoscA; }
            set { dlugoscA = value; }
        }

        private double dlugoscB = 1;

        public double B
        {
            get { return dlugoscB; }
            set { dlugoscB = value; }
        }

        private double dlugoscC = 1;

        public double C
        {
            get { return dlugoscC; }
            set { dlugoscC = value; }
        }


        public TrojkatM(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public TrojkatM()
        {
            
        }

        public void ParametryTrojkata() // https://pl.numberempire.com/arbitrary_triangle_calculator.php
        {
            double obwod = A + B + C;
            Console.WriteLine($"Obwód: {obwod}");
            double p = (A + B + C) / 2;
            double pole = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine($"Pole: {pole}");

            if (C * C == A * A + B * B) // c2 = a2 + b2  trójkąt jest prostokątny
                Console.WriteLine("Trójkąt jest prostokątny");

            else if (C * C > A * A + B * B) // c2 > a2 + b2  trójkąt jest rozwartokątny
                Console.WriteLine("Trójkąt jest rozwartokątny");

            else if (C * C < A * A + B * B) // c2 < a2 + b2  trójkąt jest ostrokątny
                Console.WriteLine("Trójkąt jest ostrokątny");

            if(A == B && B == C)
                Console.WriteLine("Trójkąt jest równoboczny");
            else if( A == B || B == C || C == A)
                Console.WriteLine("Trójkąt jest równoramienny");
        }
        public void Skala(double skala)
        {
            if(skala > 0)
            {
                A *= skala;
                B *= skala;
                C *= skala;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
