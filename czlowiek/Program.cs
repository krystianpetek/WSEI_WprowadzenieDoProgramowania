using System;

namespace czlowiek
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek krystian = new Czlowiek("Krystian", "Petek");
            krystian.PrzedstawSie();
            Console.WriteLine(Czlowiek.liczbaLudnosci);

            czlowiekStatic.PokazIle();
            Console.WriteLine(czlowiekStatic.l);

            Czlowiek adi = new Czlowiek();
            adi.im = "Adrian";
            adi.Wiek = 20;
            adi.Wiek = -20;
            Console.WriteLine($"Jestem {adi.im} lat {adi.Wiek}.");
        }
    }
}
