using System;

namespace inneZadanie20
{
    class Program
    {
        public static double RegularSquarePyramidVolume(int basis, int edge, int precision = 2)
        {
            if (basis < 0 || edge < 0 || precision < 2 || precision > 8)
        {
                throw new ArgumentOutOfRangeException("wrong arguments");
            }
        else if (basis * Math.Sqrt(2) / 2 > edge) // >= ?
            {
                throw new ArgumentException("object not exist");
            }
            else
            {
                // 1/3 Pp * h
                // (a* sqrt(2) /2) ^2 + h^2 = e^2
                double h = Math.Sqrt(Convert.ToDouble(edge) * Convert.ToDouble(edge) - Convert.ToDouble(basis) * Convert.ToDouble(basis) / 2);

                double baseField = Convert.ToDouble(basis) * Convert.ToDouble(basis);

                double volume = baseField * h / 3;
                return Math.Round(volume, precision);
            }
        }

        static void Main(string[] args)
        {
            int basis = int.Parse(Console.ReadLine());
            int edge = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());

            Console.WriteLine(RegularSquarePyramidVolume(basis, edge, precision));
        }
    }
}
