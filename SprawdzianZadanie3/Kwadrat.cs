using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianZadanie3
{
    public class Kwadrat : Figura, IMierzalna2D
    {
        public Punkt LewyDolny;

        private int bok;

        public int Bok
        {
            get
            {
                return bok;
            }
            set
            {
                if (value < 0)
                    bok = 0;
                else
                {
                    bok = value;
                }
            }
        }

        public double Pole => Bok * Bok;

        public double Obwod => Bok * 4;

        public double Dlugosc => Bok * 4;

        public Kwadrat( Punkt DOLNY, int BOK)
        {
            if (DOLNY == null)
            {
                throw new ArgumentException("Punkt nie może być null");
            }
            else
            {
                LewyDolny = DOLNY;
            }
            if (BOK < 0)
                bok = 0;
            else
            {
                bok = BOK;
            }
            DefaultColor = ConsoleColor.Green;
            

        }

        public override string ToString() => $"K({LewyDolny}, {Bok})";
        public new void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine($"K({LewyDolny}, {Bok}) obwod={Obwod:F2}, pole={Pole:F2}");
            Console.ResetColor();
        }
        public Kwadrat() : this(new Punkt(0, 0),1)
        {

        }


    }
}
