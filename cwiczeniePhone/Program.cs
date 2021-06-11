using System;

namespace cwiczeniePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone kontakt = new Phone("Krystian", "884284782",10);
            
            kontakt.AddContact("Gabriel", "889410340");
            kontakt.AddContact("Krystian", "88941034");
            kontakt.AddContact("Krystia", "889410340");

            kontakt.Call("Gabriel");
            Console.WriteLine( kontakt.ToString());
        }
    }
}
