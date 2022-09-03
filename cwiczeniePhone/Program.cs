using System;

namespace cwiczeniePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phone kontakt = new Phone("Krystian", "884284782", 10);

            //Console.WriteLine(kontakt.AddContact("Gabriel", "889410340"));
            //Console.WriteLine(kontakt.AddContact("Krystian", "88941034"));
            //kontakt.Call("Gabriel");
            //Console.WriteLine(kontakt.ToString());

            //Console.WriteLine(kontakt.RemoveContact("Krystian"));
            //Console.WriteLine(kontakt.RemoveContact("Krystian"));

            //Console.WriteLine(kontakt.AddContact("Krystian", "889410340"));
            //Console.WriteLine(kontakt.FindPhoneNumber("Gabriel"));

            //var z = kontakt.FindOwners("889410340");
            //Console.WriteLine("\nLista właścicieli numeru 889410340");
            //foreach (var c in z)
            //    Console.WriteLine(c);

            //Console.WriteLine(kontakt.ChangePhoneNumber("Krystian","123456789"));
            //Console.WriteLine(kontakt.ChangePhoneNumber("Gabriel","12345678"));
            //Console.WriteLine(kontakt.AddContact("G","123456789"));

            //foreach(var c in kontakt.phoneBook)
            //    Console.WriteLine(c);

            //kontakt.PrintPhoneBook();

            //Phone tel = new Phone("Krystian", "123456789",2);

            Phone tel = new Phone("Krystian", "884284782", 4,4);
            tel.AddContact("Mama", "608108949");
            
            Console.WriteLine(  tel.ToString() ); // Zadanie 1
            
            tel.Call("Mama");
            
            tel.RemoveContact("Mama"); // Zadanie 2
            
            tel.AddContact("Zona", "987654321");
            tel.AddContact("Tata", "602274385");

            Console.WriteLine( tel.FindPhoneNumber("Zona")); // Zadanie 3

            var z = tel.FindOwners("987654321"); // Zadanie 4
            Console.WriteLine("lista właścicieli");
            foreach (var c in z)
                Console.WriteLine(c);

            tel.AddContact("dziecko", "555555555");

            Console.WriteLine(tel.ChangePhoneNumber("dziecko","123456789")); // Zadanie 5

            tel.PrintPhoneBook(); // Zadanie 6

            tel.Call("dziecko");
            tel.Call("dziecko");
            tel.Call("dziecko");
            tel.Call("Tata");
            tel.Call("dziecko");

            tel.WyswietlHistorie();

            tel.ResetujTelefon();

            Console.WriteLine(tel.ToString());
        }
    }
}
