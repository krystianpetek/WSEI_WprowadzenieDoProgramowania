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
            while (warunek)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {lista[i]}");
                }

                var znak = Console.ReadKey();

                switch (znak.Key)
                {
                    case ConsoleKey.Escape:
                        {
                            warunek = false;

                            break;
                        }
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj wielkość książki telefonicznej");
                            uzytkownik.PhoneBookCapacity = int.Parse(Console.ReadLine());
                            break;
                        }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj wielkość rejestru połączeń");
                            uzytkownik.HistoriaPolaczenCapacity = int.Parse(Console.ReadLine());
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
            Console.Clear();
            warunek = true;
            lista = new List<string> { "Zadzwoń", "Dodaj kontakt", "Usuń kontakt", "Zmień numer kontaktu", "Wyświetl wszystkie kontakty", "Wyświetl historie połączeń" };
                
                Console.Clear();
                Console.Write($"Witaj ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{uzytkownik.Owner}");
                Console.ResetColor();
                Console.WriteLine($" w symulatorze telefonu");
                Console.Write($"Twój numer telefonu to: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{uzytkownik.PhoneNumber}");
                Console.ResetColor();
                Console.WriteLine();
            int Menu = 0;
            while (warunek)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {lista[i]}");
                }

                var znak = Console.ReadKey();
                switch(znak)
                {

                }


                //switch (znak.Key)
                //{
                //    case ConsoleKey.Escape:
                //        {
                //            warunek = false;
                //            break;
                //        }
                //    case ConsoleKey.D1:
                //    case ConsoleKey.NumPad1:
                //        {
                //            Console.WriteLine("Do kogo chcesz zadzwonić?");
                //            if(uzytkownik.phoneBook.Count == 0)
                //                Console.WriteLine("\nNie masz żadnego kontaktu");
                //            Console.ReadKey();
                //            Console.Clear();
                //            break;
                //        }
                //    case ConsoleKey.D2:
                //    case ConsoleKey.NumPad2:
                //        {

                //            uzytkownik.HistoriaPolaczenCapacity = int.Parse(Console.ReadLine());
                //            break;
                //        }
                //    case ConsoleKey.D3:
                //    case ConsoleKey.NumPad3:
                //        {
                //            warunek = false;
                //            break;
                //        }
                //}
            }

        }
    }
}
