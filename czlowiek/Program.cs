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
        }
    }
}
