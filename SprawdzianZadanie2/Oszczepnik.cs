using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian2
{
    class Oszczepnik
    {
        public Oszczepnik(string imie, string nazwisko, string kraj)
        {
            sprawdzImie(imie);
            sprawdzNazwisko(nazwisko);
            sprawdzKraj(kraj);
        }

        private void sprawdzImie(string im)
        {
            if (im == null)
            {
                throw new ArgumentException("Nazwa nie moze byc null!");
            }

            if (im.Length > 2)
            {

                for (int i = 0; i < im.Length; i++)
                {
                    if (!char.IsLetter(im[i]))
                    {
                        throw new ArgumentException("Niepoprawna nazwa!");

                    }
                }
                im = im.Trim();
                var wynik = "";
                for (int i = 0; i < im.Length; i++)
                {
                    if (i == 0)
                    {
                        wynik = im[0].ToString().ToUpper();
                    }
                    wynik += im[i].ToString().ToLower();
                }

                this.imie = im;
            }
            else
            {
                throw new ArgumentException("Niepoprawna nazwa!");
            }
        }
        private void sprawdzNazwisko(string na)
        {
            if (na == null)
            {
                throw new ArgumentException("Nazwa nie moze byc null!");
            }

            if (na.Length > 2)
            {

                for (int i = 0; i < na.Length; i++)
                {
                    if (!char.IsLetter(na[i]))
                    {
                        throw new ArgumentException("Niepoprawna nazwa!");

                    }
                }
                na = na.Trim();
                var wynik = "";
                for (int i = 0; i < na.Length; i++)
                {
                    if (i == 0)
                    {
                        wynik = na[0].ToString().ToUpper();
                    }
                    wynik += na[i].ToString().ToLower();
                }

                this.nazwisko = na;
            }
            else
            {
                throw new ArgumentException("Niepoprawna nazwa!");
            }
        }
        private void sprawdzKraj(string kr)
        {
            kr = kr.Trim();
            if (kr.Length != 3)
                throw new ArgumentException("niepoprawny kod kraju!");
            kraj = kr;
        }


        private string imie;

        public string Imie
        {
            get { return imie; }
            set
            {
                sprawdzImie(value);
            }
        }

        private string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                sprawdzNazwisko(value);
            }

        }

        private string kraj;

        public string Kraj
        {
            get { return kraj; }
            set
            {
                sprawdzKraj(value);  
            }
        }


        public void ZarejestrujWynik(string wynik)
        {
            if(LiczbaProb<6)
            {
                if(wynik == "x" || wynik =="X")
                {

                }
            }

            proba++;
        }

        private int proba = 0;
        public int LiczbaProb
        {
            get
            {
                return proba;
            }
        }

        public double WynikNajlepszy
        {
            get
            {
                if (LiczbaProb == 0)
                    return 0.0;

                return WynikNajlepszy;
            }
        }
        public string WynikOstatni
        {
            get
            {
                if (LiczbaProb > 0)
                    return "";

                return "";
            }
        }

        public double WynikSredni
        {
            get;
            set;
        }

    }
}
