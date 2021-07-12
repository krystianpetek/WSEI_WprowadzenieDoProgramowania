﻿using System;
using System.Collections.Generic;

namespace MBRSpoj
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // LICZBA TESTOW
            for (int i = 0; i < t; i++)
            {
                var lista = new List<IFigura>();
                int n = int.Parse(Console.ReadLine()); // LICZBA OBIEKTÓW W TEŚCIE
                for (int j = 0; j < n; j++)
                {
                    var liniaPrzypadek = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    switch (liniaPrzypadek[0])
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
        }
        public static void MinimumBoundingRectangle(IList<IFigura> listaFigur)
        {
            int lewyDolX = 0, lewyDolY = 0;
            int prawaGoraX = 0, prawaGoraY = 0;
            int nowyLewyDolX = 0, nowyLewyDolY = 0;
            int nowaPrawaGoraX = 0, nowaPrawaGoraY = 0;
            for (int i = 0; i < listaFigur.Count; i++)
            {
                var x = listaFigur[i];
                nowyLewyDolX = int.Parse(x.ToString().Split(" ")[1].Split(",")[0]);
                nowyLewyDolY = int.Parse(x.ToString().Split(" ")[1].Split(",")[1]);
                nowaPrawaGoraX = int.Parse(x.ToString().Split(" ")[2].Split(",")[0]);
                nowaPrawaGoraY = int.Parse(x.ToString().Split(" ")[2].Split(",")[1]);

                if (i == 0)
                {
                    lewyDolX = nowyLewyDolX;
                    lewyDolY = nowyLewyDolY;
                    prawaGoraX = nowaPrawaGoraX;
                    prawaGoraY = nowaPrawaGoraY;
                }

                if (nowyLewyDolX < lewyDolX)
                    lewyDolX = nowyLewyDolX;

                if (nowyLewyDolY < lewyDolY)
                    lewyDolY = nowyLewyDolY;

                if (nowaPrawaGoraX > prawaGoraX)
                    prawaGoraX = nowaPrawaGoraX;

                if (nowaPrawaGoraY > prawaGoraY)
                    prawaGoraY = nowaPrawaGoraY;
            }
            Console.WriteLine($"{lewyDolX} {lewyDolY} {prawaGoraX} {prawaGoraY}");
        }
    }
}
