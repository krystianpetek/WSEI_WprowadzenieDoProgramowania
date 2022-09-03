using System;

namespace KontoWBanku
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Konto x = new Konto("krystian");
            Console.WriteLine(x.BilansKonta);
            x.Wplata(15555555555555555m);
            Console.WriteLine(x.BilansKonta);


        }
    }
}
