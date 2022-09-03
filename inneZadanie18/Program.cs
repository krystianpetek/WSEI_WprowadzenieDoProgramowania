using System;

namespace inneZadanie18
{
    class Program
    {
        /// <summary>
        /// Oblicza objetość ostrosłupa prawidłowego trójkąta (piramidy o podstawie trójkata równobocznego)
        /// dla zadanych długości: podstawy oraz krawędzi, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="basis">długość podstawy, liczba całkowita nieujemna</param>
        /// <param name="edge">długość krawędzi, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczbaa cyfr po przecinku od (2 do 8)</param>
        /// <returns>objętość ostrosłupa prawidłowego trójkątnego obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments",
        /// gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy ostrosłpa nie można utworzyć</exception>
        public static double TetrahedronVolume(int basis, int edge, int precision = 2)
        {
            double aPodstawa = basis;
            double aKrawedz = edge;

            if (precision > 8 || precision < 2)
                throw new ArgumentOutOfRangeException("wrong arguments");
            if (basis < 0 || edge < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");
            
            double polePodstawy = ((aPodstawa * aPodstawa) * Math.Sqrt(3)) / 4;
            double wysokoscPolaPodstawy = (aPodstawa * Math.Sqrt(3)) / 2;
            double hJednaTrzecia = wysokoscPolaPodstawy * 1 / 3;
            double H = Math.Sqrt((aKrawedz* aKrawedz) - (hJednaTrzecia * hJednaTrzecia));
            //double Objetosc = (aPodstawa* aPodstawa* H * Math.Sqrt(3)) / 12;
            double Objetosc = polePodstawy * H / 3;
            Objetosc = Math.Round(Objetosc, precision);
            if (double.IsNaN(Objetosc))
                throw new ArgumentException("object not exist");
            return Objetosc;
        }
        static void Main(string[] args)
        {
            int basis = int.Parse(Console.ReadLine());
            int edge = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(TetrahedronVolume(basis, edge, precision));
        }
    }
}
