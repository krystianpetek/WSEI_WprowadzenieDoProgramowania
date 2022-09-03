using System;

namespace inneZadanie14
{
    class Program
    {
        /// <summary>
        /// Oblicza pole powierzchni całkowitej ostrosłupa prawidłowego czworokątnego (piramidy o podstawie kwadratu)
        /// dla zadanych długości: podstawy oraz krawędzi, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="basis">długość podstawy, liczba całkowita nieujemna</param>
        /// <param name="edge">długość krawędzi, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładnośc obliczeń(zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>pole powierzchni całkowitej ostrosłupa prawidłowego czworokątnego obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", gdy <c>precision</c> jest poza przedziałem
        /// od 2 do 8 lub którakolwiek z długości jest ujemna</exception>
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy ostrosłupa nie można utworzyć</exception>
        public static double RegularSquarePyramidTotalSurfaceArea(int basis, int edge, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");

            if (basis < 0 || edge < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");

            double basis1 = basis;
            double edge1 = edge;
            double a2 = basis1 * basis1;
            double h = Math.Sqrt((edge1 * edge1) - (basis1/2*basis1/2));

            double oblicz = a2+2 *basis1 * h;
            oblicz = Math.Round(oblicz, precision);

            if(double.IsNaN(oblicz))
                throw new ArgumentException("object not exist");

            return oblicz;
        }

        static void Main(string[] args)
        {
            int basis = int.Parse(Console.ReadLine());
            int edge = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(RegularSquarePyramidTotalSurfaceArea(basis, edge, precision));
        }
    }
}
