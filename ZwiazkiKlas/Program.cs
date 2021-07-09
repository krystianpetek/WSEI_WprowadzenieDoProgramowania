using System;

namespace ZwiazkiKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            var kp = new Owner("Krystian Petek");
            Console.WriteLine(kp.ToString());
            kp.Print();

            var przyczepka = new CarTrailer();
            var myCar = new Car();
            myCar.Trailer = przyczepka;
            //Console.WriteLine(myCar);
            kp.Buy(myCar);
            Console.WriteLine(kp);

            kp.Print();
            var mycar2 = new Car();
            kp.Buy(mycar2);
            kp.Print();

            mycar2 = null;
            kp.Sell(mycar2);
            // BŁĄD bo usuniety obiekt           mycar2.Drive();
            Console.WriteLine(mycar2);

            // ROWER
            var myBicycle = new Bicycle();
            kp.Buy(myBicycle);

            var ElectricBike = new ElectricBicycle();
            kp.Buy(ElectricBike);
            kp.Print();

            Vehicle p;
            p = new Car();
            Console.WriteLine(p is Car);
            Console.WriteLine(p is Vehicle);
            Console.WriteLine(p is IWithEngine);

            p = new Bicycle();
            Console.WriteLine(p is IWithEngine);

            p = new Drone();
            kp.Buy(p);
            Console.WriteLine(p);

            foreach( var pojazd in kp.pojazdy)
                if(pojazd is IWithEngine)
                Console.WriteLine(pojazd);


        }
    }
}
