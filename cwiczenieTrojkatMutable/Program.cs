using System;

namespace cwiczenieTrojkatMutable
{
    class Program
    {
        //static double SprawdzA()
        //{
        //    double a;
        //    Console.Write("Podaj dlugosc A: ");
        //    if (double.TryParse(Console.ReadLine(), out a) == false)
        //    {
        //        throw new ArgumentOutOfRangeException("błąd");
        //    }
        //    else if (a < 0)
        //        throw new ArgumentOutOfRangeException("błąd");
        //    return a;
        //}
        //static double SprawdzB()
        //{
        //    double b;
        //    Console.Write("Podaj dlugosc B: ");
        //    if (double.TryParse(Console.ReadLine(), out b) == false)
        //    {
        //        throw new ArgumentOutOfRangeException("błąd");
        //    }
        //    else if (b < 0)
        //        throw new ArgumentOutOfRangeException("błąd");
        //    return b;
        //}
        //static double SprawdzC()
        //{
        //    double c;
        //    Console.Write("Podaj dlugosc C: ");
        //    if (double.TryParse(Console.ReadLine(), out c) == false)
        //    {
        //        throw new ArgumentOutOfRangeException("błąd");
        //    }
        //    else if (c < 0)
        //        throw new ArgumentOutOfRangeException("błąd");
        //    return c;
        //}


        static void Main(string[] args)
        {
            double A, B, C;

            Console.Write("Podaj długość A: ");
            try
            {
                A = double.Parse(Console.ReadLine());
            }catch(FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
                throw new ArgumentException();
            }
            Console.Write("Podaj długość B: ");
            try
            {
                B = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
                throw new ArgumentException(); ;
            }
            Console.Write("Podaj długość C: ");
            try
            {
                C = double.Parse(Console.ReadLine());
            
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
                throw new ArgumentException(); ;
            }

            TrojkatM T = new TrojkatM(A,B,C);
            Console.WriteLine(T.ToString());

            Console.Write("Podaj długość A: ");
            try
            {
                T.A = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
            }
            Console.Write("Podaj długość B: ");
            try
            {
                T.B = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
                throw new ArgumentException();
            }
            Console.Write("Podaj długość C: ");
            try
            {
                T.C = double.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono wartość nie liczbową");
                throw new ArgumentException(); ;
            }

            Console.WriteLine(T.ToString());

            T.Skala(10);

            Console.WriteLine(T.ToString());

            //a = SprawdzA();
            //b = SprawdzB();
            //c = SprawdzC();

            ////Warunek trójkąta
            //double[] tab = { a, b, c };
            //Array.Sort(tab);
            //a = tab[0];
            //b = tab[1];
            //c = tab[2];

            //if (c < a + b)
            //{
            //    TrojkatM trojkat = new TrojkatM(a, b, c);

            //    trojkat.ParametryTrojkata();

            //    a = SprawdzA();
            //    b = SprawdzB();
            //    c = SprawdzC();
            //    tab = new double[] { a, b, c };
            //    Array.Sort(tab);
            //    a = tab[0];
            //    b = tab[1];
            //    c = tab[2];

            //    if (c < a + b)
            //    {
            //        trojkat.ParametryTrojkata();

            //        Console.WriteLine("Podaj współczynnik skali: ");
            //        int skala = int.Parse(Console.ReadLine());
            //        try
            //        {
            //            trojkat.Skala(skala);
            //            trojkat.ParametryTrojkata();

            //        }catch(ArgumentException)
            //        {
            //            Console.WriteLine("błąd w przeskalowaniu");
            //        }
            //    }
            //    else
            //    {
            //        throw new ArgumentException("błąd");
            //    }

            //}
            //else
            //{
            //    throw new ArgumentException("błąd");
            //}


        }
    }
}
