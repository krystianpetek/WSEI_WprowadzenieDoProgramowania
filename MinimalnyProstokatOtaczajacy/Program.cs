using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalnyProstokatOtaczajacy
{
    public class Program
    {        
        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine()); // LICZBA TESTOW
            //for (int i = 0; i < t; i++)
            //{
            //    var lista = new List<IFigura>();
            //    int n = int.Parse(Console.ReadLine()); // LICZBA OBIEKTÓW W TEŚCIE
            //    for (int j = 0; j < n; j++)
            //    {
            //        var liniaPrzypadek = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //        switch(liniaPrzypadek[0])
            //        {
            //            case "p":
            //                var pS = new Punkt(
            //                    double.Parse(liniaPrzypadek[1]),
            //                    double.Parse(liniaPrzypadek[2]));

            //                lista.Add(pS.GetBoundingRectangle());
            //                break;

            //            case "c":
            //                var cS = new Kolo(
            //                    new Punkt(
            //                        double.Parse(liniaPrzypadek[1]),
            //                        double.Parse(liniaPrzypadek[2])),
            //                    double.Parse(liniaPrzypadek[3]));
            //                lista.Add(cS.GetBoundingRectangle());
            //                break;
            //            case "l":
            //                var lS = new Odcinek(
            //                    new Punkt(double.Parse(liniaPrzypadek[1]),
            //                    double.Parse(liniaPrzypadek[2])),
            //                    new Punkt(double.Parse(liniaPrzypadek[3]),
            //                    double.Parse(liniaPrzypadek[4])));
            //                lista.Add(lS.GetBoundingRectangle());
            //                break;
            //        }
            //    }
            //    Console.ReadLine();
            //    MinimumBoundingRectangle(lista);
            //}

            var p1 = new Punkt(3, 3);
            Console.WriteLine(p1);
            p1.GetBoundingRectangle().Draw();

            p1 = new Punkt(5, 99);
            Console.WriteLine();
            Console.WriteLine(p1);
            p1.GetBoundingRectangle().Draw();

            Console.WriteLine();
            var k1 = new Kolo(new Punkt(5, 5), 5);
            Console.WriteLine(k1);
            k1.GetBoundingRectangle().Draw();
            k1.PROMIEN = 4;
            k1.SRODEK = new Punkt(0, 1);

            Console.WriteLine();
            Console.WriteLine(k1);
            k1.GetBoundingRectangle().Draw();
            Console.WriteLine();

            Prostokat PC1 = new Kolo(new Punkt(10, 10), 20).GetBoundingRectangle();
            Console.WriteLine(PC1);
            PC1.Draw();

            Console.WriteLine();
            var PR1 = new Prostokat();
            Console.WriteLine(PR1);
            PR1.Draw();

            Console.WriteLine();
            var o1 = new Odcinek(new Punkt(-4, -4), new Punkt(4, 4));
            Console.WriteLine(o1);
            o1.GetBoundingRectangle().Draw();

            List<IFigura> ListaFigur = new List<IFigura>();
            ListaFigur.Add(new Punkt(3, 3));
            ListaFigur.Add(new Kolo(new Punkt(0, 0), 9));
            ListaFigur.Add(new Punkt(100, 2));
            ListaFigur.Add(new Kolo(new Punkt(2, 2), 22));
            ListaFigur.Add(new Odcinek(new Punkt(-10, -10), new Punkt(-10, -11)));

            foreach (var x in ListaFigur)
                x.GetBoundingRectangle().Draw();

        }
        public static void MinimumBoundingRectangle(IList<IFigura> listaFigur)
        {
            int lewyDolX=0, lewyDolY=0;
            int prawaGoraX=0, prawaGoraY=0;
            int nowyLewyDolX=0, nowyLewyDolY=0;
            int nowaPrawaGoraX=0, nowaPrawaGoraY=0;
            for (int i = 0; i < listaFigur.Count; i++)
            {
                var x = listaFigur[i];
                nowyLewyDolX = int.Parse(x.ToString().Split(" ")[1].Split(",")[0]);
                nowyLewyDolY = int.Parse(x.ToString().Split(" ")[1].Split(",")[1]);
                nowaPrawaGoraX = int.Parse(x.ToString().Split(" ")[2].Split(",")[0]);
                nowaPrawaGoraY = int.Parse(x.ToString().Split(" ")[2].Split(",")[1]);
                
                if(i == 0)
                {
                    lewyDolX = nowyLewyDolX;
                    lewyDolY = nowyLewyDolY;
                    prawaGoraX= nowaPrawaGoraX;
                    prawaGoraY = nowaPrawaGoraY;
                }

                if (nowyLewyDolX < lewyDolX)
                    lewyDolX = nowyLewyDolX;

                if (nowyLewyDolY < lewyDolY)
                    lewyDolY = nowyLewyDolY;

                if (nowaPrawaGoraX > prawaGoraX)
                    prawaGoraX = nowaPrawaGoraX; 

                if (nowaPrawaGoraY> prawaGoraY)
                    prawaGoraY= nowaPrawaGoraY;
            }
                Console.WriteLine($"{lewyDolX} {lewyDolY} {prawaGoraX} {prawaGoraY}");
        }
    }
}