using System;
using System.Collections.Generic;
using System.Linq;

namespace cwiczeniePhoneMenu
{
    public class Phone
    {
        private string owner;
        private string phoneNumber;
        public string Owner
        {
            get
            {
                if (owner == null || owner == "")
                    throw new ArgumentException("Owner name is empty or null!");
                else
                    return owner;
            }
            protected set
            {
                if (value == null || value == "")
                    throw new ArgumentException();
                owner = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            protected set
            {
                if (value == null)
                    throw new ArgumentException();
                phoneNumber = value.Trim();
                if (phoneNumber.Length != 9)
                    throw new FormatException();
                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c))
                        throw new FormatException();
                }
            }
        }
        public int PhoneBookCapacity
        {
            get;
            protected set;
        }
        public int HistoriaPolaczenCapacity
        {
            get;
            protected set;
        }
        public Phone(string owner, string phoneNumber, int phoneBookCapacity = 100, int historiaPolaczenCap = 100)
        {
            this.owner = owner;
            this.phoneNumber = phoneNumber;
            this.PhoneBookCapacity = phoneBookCapacity;
            phoneBook = new Dictionary<string, string>();
            phoneBook.EnsureCapacity(phoneBookCapacity);
            historia = new Queue<string>();
            HistoriaPolaczenCapacity = historiaPolaczenCap;
        }
        

        private bool IsCorrectPhoneNumber(string number)
        {
            if (number == null)
                return false;
            phoneNumber = number.Trim();
            if (phoneNumber.Length != 9)
                return false;
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        
        public readonly Dictionary<string, string> phoneBook /* = new Dictionary<string, string>() */;
        public int Count => phoneBook.Count;
        public bool AddContact(string name, string number)
        {
            if (Count < PhoneBookCapacity)
            {
                if (!IsCorrectPhoneNumber(number))
                    return false;
                else
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        return false;
                        //phoneBook[name] = number;
                    }
                    phoneBook.Add(name, number);
                    return true;
                }
            }
            else
                throw new InvalidOperationException("książka adresowa jest pełna");
        }
        public string Call(string name)
        {
            string wyjscie = "";
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"Calling {phoneBook[name]} ({name}) ...");
                wyjscie = $"Calling {phoneBook[name]} ({name}) ...";
                HistoriaPolaczen(name, phoneBook[name]);
            }
            else
            {
                throw new InvalidOperationException("Osoby nie ma w książce kontaktów");
            }
            return wyjscie;
        }
        public override string ToString() // ZADANIE 1
        {
            return $"Nazwa właściciela: {this.Owner}, numer telefonu: {this.phoneNumber}, ile miejsca: {PhoneBookCapacity - Count}";
        }
        public bool RemoveContact(string name) // Zadanie 2
        {
            if (phoneBook.ContainsKey(name))
            {
                phoneBook.Remove(name);
                return true;
            }
            else
                return false;
        }
        public string FindPhoneNumber(string name) // Zadanie 3
        {
            if (phoneBook.ContainsKey(name))
                return phoneBook[name];
            else
                return String.Empty;
        }
        public List<string> FindOwners(string phoneNumber) // Zadanie 4
        {
            List<string> lista = new List<string>();

            foreach (var x in phoneBook)
            {
                if (x.Value == phoneNumber)
                    lista.Add(x.Key);
            }

            return lista;

        }
        public bool ChangePhoneNumber(string name, string phoneNumber) // Zadanie 5
        {
            if (phoneBook.ContainsKey(name))
            {
                if (IsCorrectPhoneNumber(phoneNumber))
                {
                    phoneBook[name] = phoneNumber;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public void PrintPhoneBook() // Zadanie 6
        {
            List<string> lista = new List<string>(phoneBook.Keys);
            for (int i = 0; i < phoneBook.Count; i++)
            {
                int z = i + 1;
                Console.WriteLine($"{z,-2} {lista[i],-10} {phoneBook[lista[i]]}");
            }
        }
        
        private Queue<string> historia;
        
        private void HistoriaPolaczen(string nazwa, string numerTel)
        {
            if (historia.Count == HistoriaPolaczenCapacity)
            {
                historia.Dequeue();
            }
            DateTime data = DateTime.Now;
            historia.Enqueue($"{data,-15:HH:mm:ss} {data,-20:dd MMMM yyyy} {nazwa,-15} {numerTel}");
        }
        public void WyswietlHistorie()
        {
            historia.Reverse();

            foreach (string x in historia.Reverse())
                Console.WriteLine(x);
        }
        public void ResetujTelefon()
        {
            Console.WriteLine("Podaj nazwę właściciela");
            var name = Console.ReadLine();
            Owner = name;

            Console.WriteLine("Podaj numer telefonu właściciela");
            var num = Console.ReadLine();
            PhoneNumber = num;

            Console.WriteLine("Podaj wielkość książki telefonicznej");
            var capBook = int.Parse(Console.ReadLine());
            PhoneBookCapacity = capBook;

            Console.WriteLine("Podaj numer telefonu właściciela");
            var capHistoria = int.Parse(Console.ReadLine());
            HistoriaPolaczenCapacity = capHistoria;

            phoneBook.Clear();
            historia.Clear();
            new Phone(Owner, PhoneNumber, PhoneBookCapacity, HistoriaPolaczenCapacity);
        }
    }
}
