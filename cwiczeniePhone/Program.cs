using System;

namespace cwiczeniePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone kontakt = new Phone("Krystian", "884284782", 10);

            Console.WriteLine(kontakt.AddContact("Gabriel", "889410340"));
            Console.WriteLine(kontakt.AddContact("Krystian", "88941034"));
            kontakt.Call("Gabriel");
            Console.WriteLine(kontakt.ToString());

            Console.WriteLine(kontakt.RemoveContact("Krystian"));
            Console.WriteLine(kontakt.RemoveContact("Krystian"));

            Console.WriteLine(kontakt.AddContact("Krystian", "889410340"));
            Console.WriteLine(kontakt.FindPhoneNumber("Gabriel"));

            var z = kontakt.FindOwners("889410340");
            Console.WriteLine("\nLista właścicieli numeru 889410340");
            foreach (var c in z)
                Console.WriteLine(c);

            Console.WriteLine(kontakt.ChangePhoneNumber("Krystian","123456789"));
            Console.WriteLine(kontakt.ChangePhoneNumber("Gabriel","12345678"));
            Console.WriteLine(kontakt.AddContact("G","123456789"));
        
            foreach(var c in kontakt.phoneBook)
                Console.WriteLine(c);

            kontakt.PrintPhoneBook();
        }
    }
}
