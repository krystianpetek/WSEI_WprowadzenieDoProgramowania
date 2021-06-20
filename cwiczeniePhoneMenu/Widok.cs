using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczeniePhoneMenu
{
    class Widok : Phone
    {
        public Widok(string nazwa, string tel, int phoneCAP = 100, int histCAP = 100) : base(nazwa, tel, phoneCAP, histCAP)
        {
            base.Owner = nazwa;
            base.PhoneNumber = tel;
            base.PhoneBookCapacity = phoneCAP;
            base.HistoriaPolaczenCapacity = histCAP;

        }

        public static void UruchomTelefon()
        {
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.Write("Witaj ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(imie);
            Console.ResetColor();
            Console.WriteLine("Podaj numer telefonu");
            string nrTel = Console.ReadLine();
            Widok uzytkownik = new Widok(imie, nrTel);

            List<string> lista = new List<string> { "Zmień wielkość książki telefonicznej", "Zmień wielkość rejestru połączeń", "Przejdź dalej" };

            bool warunek = true;
            while(warunek)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {lista[i]}");
                }
                
                if (uzytkownik.PhoneBookCapacity == 100)
                {

                }
                if(uzytkownik.HistoriaPolaczenCapacity == 100)
                    {

                    }
                var znak = Console.ReadKey();

                switch(znak.Key)
                {
                    case ConsoleKey.Escape:
                        {
                            continue;
                        }
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        {

                            break;
                        }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            break;
                        }
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                            warunek = false;   
                            break;
                        }
                }
            }
            
        }
    }
}
