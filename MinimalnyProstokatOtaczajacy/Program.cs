using System;
using System.Collections.Generic;

namespace MinimalnyProstokatOtaczajacy
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // LICZBA TESTOW
            /*if (t > 100) throw new ArgumentException("za dużo przypadków testowych");*/
            for (int i = 0; i < t; i++)
            {
                var lista = new List<IFigura>();
                int n = int.Parse(Console.ReadLine()); // LICZBA OBIEKTÓW W TEŚCIE
                /*if (n > 100) throw new ArgumentException("za dużo przypadków testowych");*/
                for (int j = 0; j < n; j++)
                {
                    var liniaPrzypadek = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    switch(liniaPrzypadek[0])
                    {
                        case "p":
                            var pS = new Punkt(
                                double.Parse(liniaPrzypadek[1]),
                                double.Parse(liniaPrzypadek[2]));

                            lista.Add(pS.GetBoundingRectangle());
                            break;

                        case "c":
                            var cS = new Kolo(
                                new Punkt(
                                    double.Parse(liniaPrzypadek[1]),
                                    double.Parse(liniaPrzypadek[2])),
                                double.Parse(liniaPrzypadek[3]));
                            lista.Add(cS.GetBoundingRectangle());
                            break;
                        case "l":
                            var lS = new Odcinek(
                                new Punkt(double.Parse(liniaPrzypadek[1]),
                                double.Parse(liniaPrzypadek[2])),
                                new Punkt(double.Parse(liniaPrzypadek[3]),
                                double.Parse(liniaPrzypadek[4])));
                            lista.Add(lS.GetBoundingRectangle());
                            break;
                    }
                }

                    Console.ReadLine();
                 MinimumBoundingRectangle(lista);

            }

            //var p1 = new Punkt(3, 3);
            //Console.WriteLine(p1);
            //p1.GetBoundingRectangle().Draw();

            //p1 = new Punkt(5, 99);
            //Console.WriteLine();
            //Console.WriteLine(p1);
            //p1.GetBoundingRectangle().Draw();


            //Console.WriteLine();
            //var k1 = new Kolo(new Punkt(5, 5), 5);
            //Console.WriteLine(k1);
            //k1.GetBoundingRectangle().Draw();
            //k1.PROMIEN = 4;
            //k1.SRODEK = new Punkt(0, 1);

            //Console.WriteLine();
            //Console.WriteLine(k1);
            //k1.GetBoundingRectangle().Draw();
            //Console.WriteLine();
            
            //Prostokat PC1 = new Kolo(new Punkt(10, 10), 20).GetBoundingRectangle();
            //Console.WriteLine(PC1);
            //PC1.Draw();

            //Console.WriteLine();
            //var PR1 = new Prostokat();
            //Console.WriteLine(PR1);
            //PR1.Draw();

            //Console.WriteLine();
            //var o1 = new Odcinek(new Punkt(-4,-4), new Punkt(4, 4));
            //Console.WriteLine(o1);
            //o1.GetBoundingRectangle().Draw();
        }
        public static void MinimumBoundingRectangle(IList<IFigura> listaFigur)
        {
            string[] z;
            string wynik ="";
            string poprzedniWynik = string.Empty;
            string[] M, N;
            string koniec = "" ;
            foreach (var x in listaFigur)
            {
                wynik = "";
                z = x.ToString().Split(" ");
                wynik += z[1].Split(",")[0] +" ";
                wynik += z[1].Split(",")[1] + " ";
                wynik += z[2].Split(",")[0] + " ";
                wynik += z[2].Split(",")[1];
            }
            if (poprzedniWynik == "" || poprzedniWynik == null)
            {
                poprzedniWynik = wynik; 
            }
            else { 
                M = poprzedniWynik.Split(" ");
                    N = wynik.Split(" ");
                for (int T = 0; T < 4; T++)
                {
                    if (int.Parse(N[T]) > int.Parse(M[T]))
                        koniec += N[T];
                    else
                    {
                        koniec += M[T];
                    }
                        

                }
                poprzedniWynik = koniec;
            }
            Console.WriteLine(poprzedniWynik);
        }

    }
}
