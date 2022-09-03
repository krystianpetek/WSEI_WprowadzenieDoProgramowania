using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRSpoj
{
    public class Kolo : IFigura
    {

        public Punkt SRODEK;
        public int PROMIEN;
        public Kolo(Punkt srodek, int promien)
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
}
