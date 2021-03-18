using System;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
			int tablica = args.Length;
			if (tablica == 0)
			{
				Console.WriteLine("Podaj imię: ");
				string imie = Console.ReadLine();
				Console.WriteLine("Podaj nazwisko: ");
				string nazwisko = Console.ReadLine();
				Console.WriteLine("Podaj swój wiek: ");
				int wiek = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"Witaj {imie} {nazwisko}");
				if (wiek < 0)
				{
					Console.WriteLine("Błędnie wprowadzone dane");
				}
				else if (wiek < 67)
				{
					int obliczWiek = 67 - wiek;
					Console.WriteLine($"mając {wiek} lat, brakuje Ci jeszcze {obliczWiek} lat do emerytury");
				}
				else
				{
					Console.WriteLine("Jesteś emerytem");
				}
			}
			else if (tablica == 1)
			{
				string imie = args[0];
				Console.WriteLine("Podaj nazwisko: ");
				string nazwisko = Console.ReadLine();
				Console.WriteLine("Podaj swój wiek: ");
				int wiek = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Witaj {imie} {nazwisko}");
				if (wiek < 0)
				{
					Console.WriteLine("Błędnie wprowadzone dane");
				}
				else if (wiek < 67)
				{
					int obliczWiek = 67 - wiek;
					Console.WriteLine($"mając {wiek} lat, brakuje Ci jeszcze {obliczWiek} lat do emerytury");
				}
				else
				{
					Console.WriteLine("Jesteś emerytem");
				}
			}

			else if (tablica == 2)
			{
				string imie = args[0];
				string nazwisko = args[1];
				Console.WriteLine("Podaj swój wiek: ");
				int wiek = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Witaj {imie} {nazwisko}");
				if (wiek < 0)
				{
					Console.WriteLine("Błędnie wprowadzone dane");
				}
				else if (wiek < 67)
				{
					int obliczWiek = 67 - wiek;
					Console.WriteLine($"mając {wiek} lat, brakuje Ci jeszcze {obliczWiek} lat do emerytury");
				}
				else
				{
					Console.WriteLine("Jesteś emerytem");
				}

			}
			else
			{
				string imie = args[0];
				string nazwisko = args[1];
				int wiek = Convert.ToInt32(args[2]);
				Console.WriteLine($"Witaj {imie} {nazwisko}");
				if (wiek < 0)
				{
					Console.WriteLine("Błędnie wprowadzone dane");
				}
				else if (wiek < 67)
				{
					int obliczWiek = 67 - wiek;
					Console.WriteLine($"Mając {wiek} lat, brakuje Ci jeszcze {obliczWiek} lat do emerytury");
				}
				else
				{
					Console.WriteLine("Jesteś emerytem");
				}
			}

		}
	}
}
