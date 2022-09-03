using System;

namespace zadanieKlasaPersonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person pa = new Person(" Krysti aN ",  "p Et ek", 23);
            //Console.WriteLine(pa);

            try
            {
                Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14,
                                    mother: m, father: o);
                d.modifyFirstName("Aneta");
                Console.WriteLine(d);
                d.modifyFirstName("Kolenda");
                Console.WriteLine(d);
                d.modifyAge(18);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
