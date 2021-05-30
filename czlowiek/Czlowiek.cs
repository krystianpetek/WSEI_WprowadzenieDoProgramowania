using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czlowiek
{
    class Czlowiek
    {
        public static int liczbaLudnosci = 20000;
        string imie = string.Empty;
        string nazwisko = string.Empty;
        public Czlowiek(string imieK, string nazwiskoK)
        {
            imie = imieK;
            nazwisko = nazwiskoK;
        }
        public void PrzedstawSie()
        {
            Console.WriteLine($"Mam na imię {imie} {nazwisko}");
        }

        public string im;
        private int wiek;
        public int Wiek
        {
            get { return wiek; }
            
            set {
                if (value >= 0 && value <= 200)
                    wiek = value; 
            }
        }


        public Czlowiek()
        {

        }
    }
}
