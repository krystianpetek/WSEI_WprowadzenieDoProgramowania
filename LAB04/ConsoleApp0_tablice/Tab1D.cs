using System;
using System.Diagnostics;

namespace ConsoleApp0_tablice
{
    public static class Tab1D
    {
        /// <summary>
        /// Generuje tablicę losowych liczb całkowitych z podanego zakresu i o zadanym rozmiarze
        /// </summary>
        /// <param name="size">rozmiar tablicy, dodatnia liczba całkowita</param>
        /// <param name="minVal">wartość minimalna, włącznie</param>
        /// <param name="maxVal">wartość maksymalna, włącznie</param>
        /// <returns>tablica liczb losowych</returns>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.random"/>
        public static int[] GenTab(uint size = 10, int minVal = 0, int maxVal = 100)
        {
            Debug.Assert(minVal <= maxVal);
            Random rnd = new Random();
            int[] tab = new int[size];
            for (int i = 0; i < size; i++)
                tab[i] = rnd.Next(minVal, maxVal + 1);
            return tab;
        }


        /// <summary>
        /// Konwertuje tablicę na string
        /// </summary>
        /// <param name="tab">niepusta tablica</param>
        /// <returns>string reprezentujący tablicę</returns>
        /// <see cref="https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/keywords/params"/>
        public static string ConvertToString(params int[] tab)
        {
            Debug.Assert(tab != null, "Tablica jest null");
            Debug.Assert(tab.Length > 0, "Tablica jest pusta (0-elementowa)");

            return "[" + string.Join(", ", tab) + "]";
        }


        // == Zadania ============================

        /// <summary>
        /// Zwraca sumę liczb parzystych zapisanych w tablicy zadanej jako parametr
        /// </summary>
        public static int SumaParzystych(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            //throw new NotImplementedException();
            int dlugoscTablicy = tab.Length;
            int suma = 0;
            for (int i = 0; i < dlugoscTablicy; i++)
            {
                if (tab[i] % 2 == 0)
                    suma += tab[i];
            }
            return suma;
            //ZROBIONE
        }


        /// <summary>
        /// Zwraca sumę elementów tablicy spełniających podany warunek
        /// </summary>
        /// <param name="warunek">predykat int => bool</param>
        /// <param name="tab">niepusta tablica</param>
        /// <returns>suma elementów spełniających warunek. Jesli żaden nie spełnia warunku, zwrazane jest 0</returns>
        /// <example>
        /// Przykład wywołania:
        /// <code>int suma = Tab1D.SumaJezeli(x => x%2 == 1, new int[] {1, 2, 3})</code>
        /// Wynik: 4
        /// </example>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1"/>
        public static int SumaJezeli(Predicate<int> warunek, params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Zwraca indeks pierwszego wystąpienia elementu minimalnego w tablicy
        /// </summary>
        public static int IndexMin(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
            //wykonaj zadanie z uzyciem pętli for(;;), foreach, while, do-while
        }


        /// <summary>
        /// Wyznacza równocześnie element minimalny i maksymalny w tablicy. Zapamiętuje w zmiennych przekazywanych przez referencję obustronną.
        /// </summary>
        /// <remarks>
        /// Ponieważ funkcja zwracać może tylko jedną wartość, zastosujemy procedurę o dwukierunkowej komunikacji.
        /// Deklarujemy, że min oraz max są parametrami przekazywanymi przez referencję, a nie (jak zwykle) przez wartość (kopię). 
        /// Uwaga: ponieważ parametry min oraz max są przekazywane przez referencję, musimy zatem mieć te zmienne “aktywne” przed wywołaniem procedury. Mimo, iż są one zewnętrzne dla kodu procedury, ona w swoim wnętrzu, zmieni ich zawartość. 
        /// Uwaga: procedura nie może być użyta w kontekście wyrażenia. Musi być oddzielną instrukcją.
        /// </remarks>
        /// <example>
        /// Wywołanie: 
        /// <code>
        /// int min = 1000; 
        /// int max = 100; 
        /// Console.WriteLine("min = {0}; max = {1}", min, max);
        /// MinMaxRef(ref min, ref max, 3, 2, 1, 5, 6, 7, 2, 73); 
        /// Console.WriteLine($"min = {min}; max = {max}"); 
        /// </code>
        /// W wywołaniu, podobnie jak w sygnaturze funkcji, musimy jawnie użyć słowa kluczowego <code>ref</code>. 
        /// </example>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref"/>
        public static void MinMaxRef(ref int min, ref int max, params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Wyznacza równocześnie element minimalny i maksymalny w tablicy. Zapamiętuje w zmiennych przekazywanych przez referencję jednostronną <code>out</code>.
        /// </summary>
        /// <example>
        /// Wywołanie: 
        /// <code>int min, max; 
        /// MinMaxOut(out min, out max, 3, 2, 1, 5, 6, 7, 2, 73); 
        /// Console.WriteLine("min = {0}; max = {1}", min, max); 
        /// </code>
        /// W tym przypadku nie ma znaczenia, jakie wartości są przypisane zmiennym min, max przed wywołaniem procedury.Procedura je zmieni (out – kierunek od procedury do zmiennej zewnętrznej).
        /// </example>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier"/>
        public static void MinMaxOut(out int min, out int max, params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Wyznacza równocześnie element minimalny i maksymalny w tablicy, zwraca je jako ValueTuple. 
        /// Dostępne od C# 7.
        /// </summary>
        /// <example>
        /// Wywołanie: 
        /// <code>int min, max; 
        /// (min, max) = MinMax(3, 2, 1, 5, 6, 7, 2, 73); 
        /// Console.WriteLine($"min = {min}; max = {max}"); 
        /// </code>
        /// W tym przypadku nie ma znaczenia, jakie wartości są przypisane zmiennym min, max przed wywołaniem funkcji (funkcja je zmieni).
        /// </example>
        /// <see cref="https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/builtin-types/value-tuples"/>
        public static (int,int) MinMax(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            int min = tab[0];
            int max = tab[0];
            int i = 0;
            while(i != tab.Length)
            {
                if (tab[i] > max)
                    max = tab[i];

                if (tab[i] < min)
                    min = tab[i];

                i++;
            }
            return(min, max);
            //ZROBIONE
        }

        /// <summary>
        /// Zwraca parę wartości: minimum i jego indeks (miejsce wystapienia w tablicy)
        /// </summary>
        /// <remarks>
        /// Zwracanie wielu wartości przez funkcję wprowadzone w C# 7
        /// </remarks>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/tuples"/>
        public static (int min, int IndexMin) MinAndIndexMin(params int[] tab)
        {
            return (0, 0);
        }


        /// <summary>
        /// Zwraca liczbę wystapień elementu <code>key</code> w tablicy
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-parameter-modifier"/>
        /// <see cref="https://stackoverflow.com/questions/47328622/where-is-c-sharp-7-2-in-visual-studio-project-settings"/>
        public static int Count(in int key, params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Zwraca tablicę indeksów komórek tablicy tab[], w których znajduje sie poszukiwany element <code>key</code>.
        /// Jeśli element nie wystepuje, zwraca <code>null</code>.
        /// </summary>
        /// <example>
        /// Dla tablicy [2, 1, 3, 1, 2, 2, 1, 4, 1] indeksowaną 0..8 oraz klucza 1
        /// zwraca tablicę [1, 3, 6, 8]
        /// </example>
        public static int[] WhereIs(in int key, params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Zwraca true, jesli tablica jest posortowana rosnąco
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public static bool IsSortedAsc(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Sortuje tablicę metodą babelkową, malejąco
        /// </summary>
        /// <see cref="https://pl.wikipedia.org/wiki/Sortowanie_bąbelkowe"/>
        public static void BubbleSortDesc(int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Łączy posortowane rosnąco tablice, tworząc nową, również posortowaną
        /// </summary>
        /// <param name="tab1">pierwsza tablica posortowana rosnąco</param>
        /// <param name="tab2">druga tablica posortowana rosnąco</param>
        /// <returns>nowa tablica, będą połączeniem obu, również posortowana rosnąco</returns>
        /// <example>
        /// 
        /// </example>
        public static int[] MergeAsc(int[] tab1, int[] tab2)
        {
            Debug.Assert(tab1 != null && tab2 != null);
            Debug.Assert(tab1.Length > 0 && tab1.Length > 0);
            Debug.Assert(IsSortedAsc(tab1) && IsSortedAsc(tab2));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zwraca medianę ciągu danych
        /// </summary>
        /// <see cref="https://pl.wikipedia.org/wiki/Mediana"/>
        public static int Median(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Zwraca modalną (dominantę) podanego ciągu danych. 
        /// Jeśli modalna nie istnieje, zwraca <code>null</code>.
        /// </summary>
        /// <see cref="https://pl.wikipedia.org/wiki/Dominanta_(statystyka)">
        public static int? Mode(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }


        /// <summary>
        /// Zwraca najdłuższy spójny podciąg rosnący w zadanym ciągu.
        /// Jeśli takich podciągów jest więcej, zwraca ten o najmniejszym indeksie początku.
        /// </summary>
        /// <example>
        /// Dla tablicy [3, 1, 2, 4, 1, 2, 6, 6, 3, 5]
        /// zwróci [1, 2, 4]
        /// Nie zwróci [1, 2, 6, 6], bo podciąg nie jest rosnący (jest niemalejący)
        /// Dla tablicy [4, 3, 2, 1] zwróci [4], ponieważ oryginalny ciąg jest malejący 
        /// </example>
        public static int[] NajdluzszyRosnacyPodciagSpojny(params int[] tab)
        {
            Debug.Assert(tab != null);
            Debug.Assert(tab.Length > 0);
            throw new NotImplementedException();
        }



        // ===== Zadania kreatywne ==============

        // Zadanie: Tablica okresowa
        // Napisz funkcję, która zwraca 0 jeśli tablica nie jest okresowa, w przeciwnym przypadku zwracająca wartość okresu.
        // Okresem nazywamy najmniejszą liczbę k>0, że dla każdego i: a[i] = a[i+k] (o ile da się zaadresować i+k)
        // Przykład: tablica [1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2] jest okresowa, okres wynosi 4
        // Przykład: tablica [1, 4, 2, 6, 1, 3, 4, 1] nie jest okresowa
        // Przykład: tablica [1, 2, 1, 2, 1, 2, 3] nie jest okresowa
        // Napisz funkcję, która generuje tablicę okresową liczb całkowitych, o zadanym okresie i zadanym rozmiarze tablicy
        // Wykorzystaj tę funkcję do przetestowania poprzedniej.

    } //koniec klasy Tab1D
}
