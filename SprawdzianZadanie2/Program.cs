using System;

namespace SprawdzianZadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test: poprawne tworzenie obiektu Oszczepnik, dane poprawne
            //       typowe czynności poprawne
            Oszczepnik p = new Oszczepnik(imie: "krzysztof", nazwisko: "molenda", kraj: "pol");
            Console.WriteLine(p);
            p.ZarejestrujWynik("67");
            p.ZarejestrujWynik("71,12");
            Console.WriteLine(p);
            Console.WriteLine(p.ProbujZarejestrowacWynik("x"));
            p.ZarejestrujWynik("70,5");
            Console.WriteLine(p);
        }
    }
}
