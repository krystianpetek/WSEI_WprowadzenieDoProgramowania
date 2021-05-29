using System;

namespace inneZadanie9
{
    class Program
    {
        /// <summary>
        /// Oblicza pole trójkąta równoramiennego dla zadanych długości: podstawy oraz ramienia, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="basis">długość podstawy, liczba całkowita nieujemna</param>
        /// <param name="leg">długość ramienia, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>pole trójkąta obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>

        public static double TriangleIsoscalesArea(int basis, int leg, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");

            if (basis < 0 || leg < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");

            double basis1 = basis;
            double leg1 = leg;
            double h = Math.Sqrt((leg1 * leg1) - (basis1 / 2 * basis1 / 2));
            double wynik = (double)(h * basis1) / 2;

            if (double.IsNaN(wynik))
                throw new ArgumentException("object not exist");

            return Math.Round(wynik, precision);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(TriangleIsoscalesArea(a, b, precision));
        }
    }
}
