using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalnyProstokatOtaczajacy
{

    public class Kolo : IFigura
    {
        private Punkt srodek;
        public Punkt SRODEK
        {
            get { return srodek; }
            set { srodek = value; }
        }

        private double promien;
        public double PROMIEN
        {
            get { return promien; }
            set { promien = value; }
        }

        public Kolo(Punkt srodek, double promien)
        {
            SRODEK = srodek;
            PROMIEN = promien;
        }
        public Kolo() :this(new Punkt(0,0),1)
        {

        }

        public Prostokat GetBoundingRectangle()
        {
            throw new NotImplementedException();
        }
    }
}
