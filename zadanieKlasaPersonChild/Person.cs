using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKlasaPersonChild
{
    class Person
    {
        public string FirstName
        {
            get; protected set;
        }
        public string FamilyName
        {
            get; protected set;
        }
        public int Age
        {
            get; protected set;
        }

        public Person(string firstName, string familyName, int age)
        {
            familyName = UsunSpacje(familyName);
            SprawdzPoprawnosc(familyName);
            familyName = WielkoscLiter(familyName);

            firstName = UsunSpacje(firstName);
            SprawdzPoprawnosc(firstName);
            firstName = WielkoscLiter(firstName);

            SprawdzWiek(age);

            this.FamilyName = familyName;
            this.FirstName= firstName;
            this.Age = age;
        }
        
        private static void SprawdzPoprawnosc(string tekst)
        {
            if (tekst == null || tekst == String.Empty || tekst == "")
                throw new ArgumentException("Wrong name!");

            for (int i = 0; i < tekst.Length; i++)
            {
                if (!char.IsLetter(tekst[i]))
                    throw new ArgumentException("Wrong name!");
            }
        }

        private static string UsunSpacje(string tekst)
        {
            string tekstTemp = String.Empty;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != ' ')
                    tekstTemp += tekst[i];
            }
            return tekstTemp;
        }

        private static string WielkoscLiter(string tekst)
        {
            string tekstTemp = String.Empty;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (i == 0)
                    tekstTemp += tekst[i].ToString().ToUpper();
                else
                {
                    tekstTemp += tekst[i].ToString().ToLower();
                }
            }
            return tekstTemp;
        }

        private static void SprawdzWiek(int wiek)
        {
            if (wiek < 0)
                throw new ArgumentException("Age must be positive!");
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Age})";
        }
    
        public void modifyFirstName(string imie)
        {
            imie = UsunSpacje(imie);
            SprawdzPoprawnosc(imie);
            imie = WielkoscLiter(imie);

            this.FirstName = imie;
        }
        
        public void modifyFamilyName(string nazwisko)
        {
            nazwisko = UsunSpacje(nazwisko);
            SprawdzPoprawnosc(nazwisko);
            nazwisko = WielkoscLiter(nazwisko);

            this.FamilyName = nazwisko;
        }
        
        public void modifyAge(int wiek)
        {
            SprawdzWiek(wiek);
            this.Age = wiek;
        }
    
    }
}