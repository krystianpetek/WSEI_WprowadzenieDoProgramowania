using System;

namespace inneZadanie3
{
    class Program
    {
        public static double TrapesoidIsoscelasArea(int base1, int base2, int leg, int precision = 2)
        {
            if (precision < 2 || precision > 8)
                throw new ArgumentOutOfRangeException("wrong arguments");

            if (base1 < 0 || base2 < 0 || leg < 0)
                throw new ArgumentOutOfRangeException("wrong arguments");
            double base11 = base1;
            double base22 = base2;
            double leg1 = leg;

            double a = (base22 - base11) / 2;
            double h = Math.Sqrt(leg1 * leg1 - a * a);
            double p = ((base11 + base22) / 2) * h;
            if (double.IsNaN(p))
                throw new ArgumentException("object not exist");

            return Math.Round(p, precision);
        }
        static void Main()
        {
            int base1 = int.Parse(Console.ReadLine());
            int base2 = int.Parse(Console.ReadLine());
            int leg = int.Parse(Console.ReadLine());
            int precision = int.Parse(Console.ReadLine());
            Console.WriteLine(TrapesoidIsoscelasArea(base1, base2, leg, precision));
        }
    }
}
