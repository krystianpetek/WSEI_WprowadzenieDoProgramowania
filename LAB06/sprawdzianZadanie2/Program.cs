using System;

namespace sprawdzianZadanie2
{
    class Program
    {
        public static double TetrahedronTotalSurfaceArea(int basis, int edge, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");

            if (basis < 0 || edge < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");

            double basis1 = basis;
            double edge1 = edge;
            double polePodstawy = (basis1 * basis1) * Math.Sqrt(3) / 4;
            double h = Math.Sqrt(Math.Pow(edge1, 2) - Math.Pow(basis1 / 2, 2));
            double sumaPolaSciany = (basis1 * h) / 2;

            double wynik = polePodstawy + 3 * sumaPolaSciany;
            if (double.IsNaN(wynik))
                throw new ArgumentException("object not exist");

            return Math.Round(wynik, precision);
        }
        static void Main(string[] args)
        {
            int basis = int.Parse(Console.ReadLine());
            int edge = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            double wynik = TetrahedronTotalSurfaceArea(basis, edge, precision);
            Console.WriteLine(wynik);
        }
    }
}
