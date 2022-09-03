using System;

namespace inneZadanie17
{
    class Program
    {
        /// <summary>
        /// Oblicza obwód trapezu równoramiennego dla zadanych długości: obu podstaw oraz ramienia, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="base1">długość pierwszej podstawy, liczba całkowita nieujemna</param>
        /// <param name="base2">długość drugiej podstawy, liczba całkowita nieujemna</param>
        /// <param name="leg">długość ramienia, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>obwód trapezu obliczony z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments",
        /// gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trapezu nie można utworzyć</exception>
        public static double TrapesoidIsoscelesPerimeter(int base1, int base2, int leg, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");
            if (base1 < 0 || base2 < 0 || leg < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");



            double base11 = base1;
            double base22 = base2;
            double leg1 = leg;
            double obwod = base1 + base2 + leg + leg;
            obwod = Math.Round(obwod, precision);
            if (double.IsNaN(obwod) || base11 > base22)
                throw new ArgumentException("object not exist");
            return obwod;
        }
        static void Main(string[] args)
        {
            int base1 = int.Parse(Console.ReadLine());
            int base2 = int.Parse(Console.ReadLine());
            int leg = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(  TrapesoidIsoscelesPerimeter(base1, base2, leg, precision));
        }
    }
}
