using System;

namespace KM003Z01___Czas24h
{
    public class Czas24h
    {
        private int[] TablicaSek
        {
            get
            {
                int[] tablica = new int[60];
                for (int i = 0; i < 60; i++)
                {
                    tablica[i] = i;
                }
                return tablica;
            }
        }
        private int[] TablicaMin
        {
            get
            {
                int[] tablica = new int[60];
                for (int i = 0; i < 60; i++)
                {
                    tablica[i] = i;
                }
                return tablica;
            }
        }

        private int[] TablicaGodz
        {
            get
            {
                int[] tablica = new int[24];
                for (int i = 0; i < 24; i++)
                {
                    tablica[i] = i;
                }
                return tablica;
            }
        }

        private void checkG(int godzinka)
        {
            bool check = false;
            for (int i = 0; i < TablicaGodz.Length; i++)
            {
                if (godzinka == TablicaGodz[i])
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
                throw new ArgumentException();
        }

        private void checkM(int minutka)
        {
            bool check = false;
            for (int i = 0; i < TablicaMin.Length; i++)
            {
                if (minutka == TablicaMin[i])
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
                throw new ArgumentException();
        }

        private void checkS(int sekundka)
        {
            bool check = false;
            for (int i = 0; i < TablicaSek.Length; i++)
            {
                if (sekundka == TablicaSek[i])
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
                throw new ArgumentException();
        }

        private int liczbaSekund;

        public int Sekunda
        {
            get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
            set
            {
                checkS(value);
                liczbaSekund = value + 60 * Minuta + 3600 * Godzina;
            }
        }

        public int Minuta
        {
            get => (liczbaSekund / 60) % 60;
            set
            {
                checkM(value);
                liczbaSekund = Sekunda + 60 * value + 3600 * Godzina;
            }
        }

        public int Godzina
        {
            get => liczbaSekund / 3600;
            set
            {
                checkG(value);
                liczbaSekund = Sekunda + 60 * Minuta + 3600 * value;
            }
        }

        public Czas24h(int godzina, int minuta, int sekunda)
        {
            checkG(godzina);
            checkM(minuta);
            checkS(sekunda);
            liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
        }

        public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
    }
    public class Program
    {
        public static void Main()
        {
            string[] napis = null;
            Czas24h t = null;

            // wczytanie i parsowanie napisu oznaczającego godzinę, np. 2:15:27
            napis = Console.ReadLine().Split(':');
            int[] czas = Array.ConvertAll(napis, int.Parse);
            try
            {
                t = new Czas24h(czas[0], czas[1], czas[2]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
                return;
            }

            // wczytanie liczby poleceń
            int liczbaPolecen = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczbaPolecen; i++)
            {
                // wczytanie polecenia
                napis = Console.ReadLine().Split(' ');
                string typPolecenia = napis[0];
                int liczba = int.Parse(napis[1]);

                // wykonanie polecenia na obiekcie t typu Czas24h
                try
                {
                    switch (typPolecenia)
                    {
                        case "g":
                            t.Godzina = liczba;
                            break;
                        case "m":
                            t.Minuta = liczba;
                            break;
                        case "s":
                            t.Sekunda = liczba;
                            break;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            Console.WriteLine(t);
        }
    }


}
