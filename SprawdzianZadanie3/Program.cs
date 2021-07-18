using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SprawdzianZadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // klasa Kwadrat, konstruktor domyślny
            Kwadrat k = new Kwadrat();
            Console.WriteLine(k);
            k.Rysuj();
        }
    }
}
