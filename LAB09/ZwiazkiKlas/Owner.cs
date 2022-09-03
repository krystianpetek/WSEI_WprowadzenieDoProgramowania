using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Owner : Person
    {
        public List<Vehicle> pojazdy;
        public Owner(string name) : base(name)
        {
            pojazdy = new List<Vehicle>();
        }

        public new void Print()
        {
            base.Print();
            if (pojazdy.Count == 0)
                Console.WriteLine("brak pojazdów");
            else
                Console.WriteLine(String.Join(",\n", pojazdy));
        }
        public override string ToString() => $"{Name}: {String.Join(",",pojazdy)}";

        public void Buy(Vehicle car)
        {
            if (car == null) return;

            if (!pojazdy.Contains(car))
                pojazdy.Add(car);

            car.Owner = this;
        }
        public void Sell(Vehicle car)
        {
            if (car is null) return;
            if (pojazdy.Contains(car)) pojazdy.Remove(car);
            car.Owner = null;
        }

    }
}