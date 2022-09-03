using System;

namespace cwiczenieTrojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Podaj długość A: ");
            //string A = Console.ReadLine();
            //Console.Write("Podaj długość B: ");
            //string B = Console.ReadLine();
            //Console.Write("Podaj długość C: ");
            //string C = Console.ReadLine();

            //Trojkat nowy = new Trojkat(A,B,C);
            //Console.WriteLine(nowy.A);
            //Console.WriteLine(nowy.B);
            //Console.WriteLine(nowy.C);

            //nowy.PolePowierzchni();
            //nowy.Obwod();
            //nowy.SprawdzTrojkat();

            Console.Write("Podaj długość A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Podaj długość B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Podaj długość C: ");
            double C = double.Parse(Console.ReadLine());

            Trojkat t = new Trojkat(A, B, C);
            Console.WriteLine(t);            
        }
    }
}
