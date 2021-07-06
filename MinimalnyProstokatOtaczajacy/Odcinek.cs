using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalnyProstokatOtaczajacy
{
    public class Odcinek
    {
        private Punkt A;

        public Punkt P1
        {
            get { return A; }
            set { A = value; }
        }

        private Punkt B;

        public Punkt P2
        {
            get { return B; }
            set { B = value; }
        }

        public Odcinek(Punkt p1, Punkt p2)
        {
            P1 = p1;
            P2 = p2;
        }
        public Odcinek() : this(new Punkt(0, 0), new Punkt(0, 0))
        {

        }
    }
}
