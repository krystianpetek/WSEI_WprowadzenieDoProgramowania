using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianZadanie2
{
    public class Oszczepnik
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
                wynik = im[0].ToString().ToUpper();

                for (int i = 1; i < im.Length; i++)
                {
                    wynik += im[i].ToString().ToLower();
                }
                this.imie = wynik;
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
                wynik = na[0].ToString().ToUpper();

                for (int i = 1; i < na.Length; i++)
                {
                    wynik += na[i].ToString().ToLower();
                }
                this.nazwisko = wynik;
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
            kr = kr.ToUpper();
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

        List<string> tabela = new List<string>();
        public void ZarejestrujWynik(string wynik)
        {
            if (LiczbaProb < 6)
            {
                if (wynik == "x" || wynik == "X")
                {
                    tabela.Add("X");
                    proba++;
                }
                else if(double.Parse(wynik) > 0)
                {                    
                    tabela.Add($"{double.Parse(wynik):F2}");
                    if (najlepszy < double.Parse(wynik))
                        najlepszy = Math.Round(double.Parse(wynik),2);
                    proba++;
                }
                else
                {
                    throw new ArgumentException("niepoprawny format");
                }
            }
            else
            {
                throw new ArgumentException("limit wykorzystany");
            }
        }

        public bool ProbujZarejestrowacWynik(string wynik)
        {
            if (LiczbaProb < 6)
            {
                if (wynik == "x" || wynik == "X")
                {
                    tabela.Add(0.ToString());
                    proba++;
                    return true;
                }
                else if (double.Parse(wynik) > 0)
                {
                    tabela.Add(wynik);
                    if (najlepszy < double.Parse(wynik))
                        najlepszy = double.Parse(wynik);
                    proba++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private int proba = 0;
        public int LiczbaProb
        {
            get
            {
                return proba;
            }
        }

        private double najlepszy = 0;
        public double WynikNajlepszy
        {
            get
            {
                if (tabela.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Math.Round(najlepszy,2);
                }

            }
        }
        public string WynikOstatni
        {
            get
            {
                if (tabela.Count == 0)
                {
                    return "X";
                }
                else if (double.Parse(tabela[tabela.Count - 1]) > 0)
                    return tabela[tabela.Count - 1];
                else
                {
                    return "X";
                }
            }
        }

        public double WynikSredni
        {
            get
            {
                if (tabela.Count == 0)
                    return 0;
                else
                {
                    double wynik = 0;
                    int licznikLiczb=0;
                    for (int i = 0; i < tabela.Count; i++)
                    {
                        wynik += double.Parse(tabela[i]);
                        if (double.Parse(tabela[i]) != 0 )
                            licznikLiczb++;
                    }
                    wynik = wynik/licznikLiczb;
                    return Math.Round(wynik,2);
                }
            }
        }

        public override string ToString()
        {
            string wyjscie = $"{Imie} {Nazwisko} ({Kraj})\nwyniki: ";
            if (tabela.Count == 0)
                wyjscie += "-";
            else
            {
                for (int i = 0; i < tabela.Count; i++)
                {
                    if (double.Parse(tabela[i]) == 0)
                        wyjscie += "X, ";
                    else
                    wyjscie += $"{tabela[i]}, ";
                }
                wyjscie = wyjscie.Substring(1, wyjscie.Length - 3);
            }
            wyjscie += $"\nliczba prob: {LiczbaProb}, wynik najlepszy: {WynikNajlepszy:F2}, wynik sredni: {WynikSredni:F2}";

            return wyjscie;
        }
    }
}
