using System;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            string imie = args[0];
            string nazwisko = args[1];

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

            int wiek = Convert.ToInt32(args[2]); // tutaj może wystąpić wyjatek

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