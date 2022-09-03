using System;

namespace ConsoleApp8_ledNumbers
{
    class Program
    {
        // LED Numbers
        static void Main(string[] args)
        {
            // JEDEN
            string[] goraJeden = { " ", " ", " " };
            string[] srodekJeden = { " ", " ", "|" };
            string[] dolJeden = { " ", " ", "|" };

            // DWA
            string[] goraDwa = { " ", "_", " " };
            string[] srodekDwa = { " ", "_", "|" };
            string[] dolDwa = { "|", "_", " " };

            // TRZY
            string[] goraTrzy = { " ", "_", " " };
            string[] srodekTrzy = { " ", "_", "|" };
            string[] dolTrzy = { " ", "_", "|" };

            // CZTERY
            string[] goraCztery = { " ", " ", " " };
            string[] srodekCztery = { "|", "_", "|" };
            string[] dolCztery = { " ", " ", "|" };

            // PIĘĆ
            string[] goraPiec = { " ", "_", " " };
            string[] srodekPiec = { "|", "_", " " };
            string[] dolPiec = { " ", "_", "|" };

            // SZEŚĆ
            string[] goraSzesc = { " ", "_", " " };
            string[] srodekSzesc = { "|", "_", " " };
            string[] dolSzesc = { "|", "_", "|" };

            // SIEDEM
            string[] goraSiedem = { " ", "_", " " };
            string[] srodekSiedem = { " ", " ", "|" };
            string[] dolSiedem = { " ", " ", "|" };

            // OSIEM
            string[] goraOsiem = { " ", "_", " " };
            string[] srodekOsiem = { "|", "_", "|" };
            string[] dolOsiem = { "|", "_", "|" };

            // DZIEWIEC
            string[] goraDziewiec = { " ", "_", " " };
            string[] srodekDziewiec = { "|", "_", "|" };
            string[] dolDziewiec = { " ", " ", "|" };

            // ZERO
            string[] goraZero = { " ", "_", " " };
            string[] srodekZero = { "|", " ", "|" };
            string[] dolZero = { "|", "_", "|" };

            string wejscie = Console.ReadLine();
            int[] liczby = new int[wejscie.Length];
            for (int a = 0; a < wejscie.Length; a++)
                liczby[a] = int.Parse(wejscie[a].ToString());
            int licznikG = 0;
            int licznikS = 0;
            int licznikD = 0;


            // GÓRA
            while (licznikG != liczby.Length)
            {
                switch (liczby[licznikG])
                {
                    case 1:
                        {
                            licznikG++;
                            Console.Write(goraJeden[0] + goraJeden[1] + goraJeden[2]);
                            break;
                        }
                    case 2:
                        {
                            licznikG++;
                            Console.Write(goraDwa[0] + goraDwa[1] + goraDwa[2]);
                            break;
                        }
                    case 3:
                        {
                            licznikG++;
                            Console.Write(goraTrzy[0] + goraTrzy[1] + goraTrzy[2]);
                            break;
                        }
                    case 4:
                        {
                            licznikG++;
                            Console.Write(goraCztery[0] + goraCztery[1] + goraCztery[2]);
                            break;
                        }
                    case 5:
                        {
                            licznikG++;
                            Console.Write(goraPiec[0] + goraPiec[1] + goraPiec[2]);
                            break;
                        }
                    case 6:
                        {
                            licznikG++;
                            Console.Write(goraSzesc[0] + goraSzesc[1] + goraSzesc[2]);
                            break;
                        }
                    case 7:
                        {
                            licznikG++;
                            Console.Write(goraSiedem[0] + goraSiedem[1] + goraSiedem[2]);
                            break;
                        }
                    case 8:
                        {
                            licznikG++;
                            Console.Write(goraOsiem[0] + goraOsiem[1] + goraOsiem[2]);
                            break;
                        }
                    case 9:
                        {
                            licznikG++;
                            Console.Write(goraDziewiec[0] + goraDziewiec[1] + goraDziewiec[2]);
                            break;
                        }
                    case 0:
                        {
                            licznikG++;
                            Console.Write(goraZero[0] + goraZero[1] + goraZero[2]);
                            break;
                        }
                }
                if (licznikG == liczby.Length)
                    Console.WriteLine();
            }

            // SRODEK
            while (licznikS != liczby.Length)
            {
                switch (liczby[licznikS])
                {
                    case 1:
                        {
                            licznikS++;
                            Console.Write(srodekJeden[0] + srodekJeden[1] + srodekJeden[2]);
                            break;
                        }
                    case 2:
                        {
                            licznikS++;
                            Console.Write(srodekDwa[0] + srodekDwa[1] + srodekDwa[2]);
                            break;
                        }
                    case 3:
                        {
                            licznikS++;
                            Console.Write(srodekTrzy[0] + srodekTrzy[1] + srodekTrzy[2]);
                            break;
                        }
                    case 4:
                        {
                            licznikS++;
                            Console.Write(srodekCztery[0] + srodekCztery[1] + srodekCztery[2]);
                            break;
                        }
                    case 5:
                        {
                            licznikS++;
                            Console.Write(srodekPiec[0] + srodekPiec[1] + srodekPiec[2]);
                            break;
                        }
                    case 6:
                        {
                            licznikS++;
                            Console.Write(srodekSzesc[0] + srodekSzesc[1] + srodekSzesc[2]);
                            break;
                        }
                    case 7:
                        {
                            licznikS++;
                            Console.Write(srodekSiedem[0] + srodekSiedem[1] + srodekSiedem[2]);
                            break;
                        }
                    case 8:
                        {
                            licznikS++;
                            Console.Write(srodekOsiem[0] + srodekOsiem[1] + srodekOsiem[2]);
                            break;
                        }
                    case 9:
                        {
                            licznikS++;
                            Console.Write(srodekDziewiec[0] + srodekDziewiec[1] + srodekDziewiec[2]);
                            break;
                        }
                    case 0:
                        {
                            licznikS++;
                            Console.Write(srodekZero[0] + srodekZero[1] + srodekZero[2]);
                            break;
                        }
                }
                if (licznikS == liczby.Length)
                    Console.WriteLine();
            }

            // DOL
            while (licznikD != liczby.Length)
            {
                switch (liczby[licznikD])
                {
                    case 1:
                        {
                            licznikD++;
                            Console.Write(dolJeden[0] + dolJeden[1] + dolJeden[2]);
                            break;
                        }
                    case 2:
                        {
                            licznikD++;
                            Console.Write(dolDwa[0] + dolDwa[1] + dolDwa[2]);
                            break;
                        }
                    case 3:
                        {
                            licznikD++;
                            Console.Write(dolTrzy[0] + dolTrzy[1] + dolTrzy[2]);
                            break;
                        }
                    case 4:
                        {
                            licznikD++;
                            Console.Write(dolCztery[0] + dolCztery[1] + dolCztery[2]);
                            break;
                        }
                    case 5:
                        {
                            licznikD++;
                            Console.Write(dolPiec[0] + dolPiec[1] + dolPiec[2]);
                            break;
                        }
                    case 6:
                        {
                            licznikD++;
                            Console.Write(dolSzesc[0] + dolSzesc[1] + dolSzesc[2]);
                            break;
                        }
                    case 7:
                        {
                            licznikD++;
                            Console.Write(dolSiedem[0] + dolSiedem[1] + dolSiedem[2]);
                            break;
                        }
                    case 8:
                        {
                            licznikD++;
                            Console.Write(dolOsiem[0] + dolOsiem[1] + dolOsiem[2]);
                            break;
                        }
                    case 9:
                        {
                            licznikD++;
                            Console.Write(dolDziewiec[0] + dolDziewiec[1] + dolDziewiec[2]);
                            break;
                        }
                    case 0:
                        {
                            licznikD++;
                            Console.Write(dolZero[0] + dolZero[1] + dolZero[2]);
                            break;
                        }
                }
                if (licznikD == liczby.Length)
                    Console.WriteLine();
            }
        }
    }
}