using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZwiazkiKlas
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public void Print() => Console.WriteLine($"Person: {Name}");

        public override string ToString() => Name;
    }
}