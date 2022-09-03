using System;

namespace Sprawdzian2
{
    class Program
    {
        /// <summary>
        /// Oblicza pole trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
        /// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
        /// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>pole trójkąta obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>

        public static double TriangleArea(int a, int b, int c, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");

            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");

            double p = (a+0.0 + b + c)/2;
            double oblicz = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (double.IsNaN(oblicz))
                throw new ArgumentException("object not exist");

            return Math.Round(oblicz, precision);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(a,b,c,precision));
        }
    }
}
