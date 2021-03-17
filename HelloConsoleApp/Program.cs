using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie."); // przechodzi do nowego wiersza
            Console.Write("Kolejne powitanie!"); // nie przechodzi do nowego wiersza
            Console.WriteLine("");

            Console.Write("Podaj imie: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

            Console.Write("Podaj swój wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek <= 0)
            {
                Console.WriteLine("BŁĘDNE DANE");
            }
            else if (wiek < 67)
            {
                Console.WriteLine("Mając {0} lat do emerytury zostało Ci jeszcze {1} lat", wiek, 67 - wiek);
            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }
        }
    }
}
