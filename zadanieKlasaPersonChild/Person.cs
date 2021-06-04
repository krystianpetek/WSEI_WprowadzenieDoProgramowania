using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKlasaPersonChild
{
    class Person
    {
        private string FirstName;
        private string FamilyName;
        private int Age;

        public Person(string nazwisko, string imie, int wiek)
        {
            if ( (nazwisko.Contains(" ") || imie.Contains(" ") ) == false)
            {
                
                if ((char.IsUpper(imie[0]) || char.IsUpper(nazwisko[0]))== true)
                {
                    bool czyDuze = false;
                    for (int x = 1; x < imie.Length; x++)
                        if (char.IsUpper(imie[x]))
                            czyDuze = true;

                    if (czyDuze == false)
                        FirstName = imie;
                    else
                        Console.WriteLine("skoryguj format, pierwsza duża pozostałe małe");
                }
                else
                {
                    Console.WriteLine("skoryguj format, pierwsza duża pozostałe małe");
                }
            }
            else
            {
                Console.WriteLine("błędne imię lub nazwisko, usuń spacje");
            }
                FamilyName = nazwisko;
            Age = wiek;
        }
    }
}
