using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieKlasaPersonChild
{
    class Child : Person
    {
        private Person mama { get; }
        private Person tata { get; }
        public Child(string firstName, string familyName, int age, Person mother = null, Person father = null) : base(firstName, familyName, age)
        {
            if (age > 15)
                throw new ArgumentException("Child’s age must be less than 15!");
            this.mama = mother;
            this.tata = father;
        }
        public override string ToString()
        {
            string wyjscie = String.Empty;
            wyjscie = $"{FirstName} {FamilyName} ({Age})";

            if (mama == null)
                wyjscie += $"\nmother: No data";
            else
                wyjscie += $"\nmother: { mama }";

            if (tata == null)
                wyjscie += $"\nfather: No data";
            else
                wyjscie += $"\nfather: { tata }";

            return wyjscie;
        }
        public override void modifyAge(int wiek)
        {
            if (wiek > 15 || wiek < 0)
                throw new ArgumentException("Child’s age must be less than 15!");
            else
                base.modifyAge(wiek);
        }
    }
}

