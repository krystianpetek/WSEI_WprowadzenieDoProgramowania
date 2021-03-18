using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            string imie = Interaction.InputBox("Podaj imię","Okienko imię");
            Console.WriteLine("Podano imię: " + imie);

            string nazwisko = Interaction.InputBox("Podaj nazwisko", "Okienko nazwisko");
            Console.WriteLine("Podano nazwisko: "+nazwisko);

            Interaction.MsgBox("Witaj " + imie + " " + nazwisko);
            Interaction.MsgBox(string.Format("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko));

            int wiek = Convert.ToInt32(Interaction.InputBox("Podaj wiek", "Okienko wiek"));
            Console.WriteLine("Podano wiek: " + wiek);
            if(wiek < 67)
            {
                Interaction.MsgBox("do emerytury zostało Ci " + (67 - wiek) + "lat", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
            else
            {
                Interaction.MsgBox("Jesteś emerytem", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "okienko emerytura");
            }
        }
    }
}
