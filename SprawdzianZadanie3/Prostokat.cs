using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianZadanie3
{
    public class Prostokat :Kwadrat    
    {
        private int bokdwa;

        public int BokDrugi
        {
            get
            {
                return bokdwa;
            }
            set
            {
                if (value < 0)
                    bokdwa = 0;
                else
                {
                    bokdwa = value;
                }
            
            }
        }
        public Prostokat(Punkt DOLNY, int Bok, int BokDrugi) : base(DOLNY, Bok)
        {
            if (BokDrugi < 0)
                bokdwa = 0;
            else
            {
                bokdwa = BokDrugi;
            }
            DefaultColor = ConsoleColor.Yellow;
        }
        public Prostokat() : this(new Punkt(), 1, 2) { }
        public override string ToString() => $"R({LewyDolny}, {Bok} x {BokDrugi})";
    
    
        public new void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine($"R({LewyDolny}, {Bok} x {BokDrugi}) obwod={Obwod:F2}, pole={Pole:F2}");
            Console.ResetColor();
        }


        public new double Pole => Bok * BokDrugi;

        public new double Obwod => Bok * 2 + BokDrugi *2;

        public new double Dlugosc => Bok * 2 + BokDrugi * 2;


    }

    public class Ekran
    {
        private List<Figura> figury = new List<Figura>();
        public void Dodaj(Figura f) => figury.Add(f);
        public void Usun(Figura f) => figury.Remove(f);
        public void Rysuj() => figury.ForEach(f => f.Rysuj());

        public double SumarycznyObwod()
        {
         
            double wynik = 0.0;
            for (int i = 0; i < figury.Count; i++)
            {

                if (figury[i] is Kwadrat)
                {
                    var kw = figury[i].ToString().Split("=");
                    var obwod = kw[1].Split(",")[0];
                    wynik = double.Parse(obwod);
                }

                if(figury[i] is Prostokat)
                {
                    var pr = figury[i].ToString().Split("=");
                    var obwod = pr[1].Split(" ")[0];
                    wynik = double.Parse(obwod);
                }
            }
            return Math.Round(wynik);
        }
        public double SumarycznePole()
        {

            double wynik = 0.0;
            for (int i = 0; i < figury.Count; i++)
            {

                if (figury[i] is Kwadrat)
                {
                    var kw = figury[i].ToString().Split("=");
                    var obwod = kw[2];
                    wynik = double.Parse(obwod);
                }

                if (figury[i] is Prostokat)
                {
                    var pr = figury[i].ToString().Split("=");
                    var obwod = pr[2];
                    wynik = double.Parse(obwod);
                }
            }
            return Math.Round(wynik);
        }
    }
}
