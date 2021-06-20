using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczeniePhone
{
    public class Phone
    {
        private string owner;
        private string phoneNumber;

        /// <summary>
        /// Property okreslające właściciela telefonu, read-only
        /// </summary>
        /// <exception cref="ArgumentException">Owner name is empty or null!</exception>
        public string Owner
        {
            get
            {
                if (owner == null || owner == "")
                    throw new ArgumentException("Owner name is empty or null!");
                else
                    return owner;
            }
            private set
            {
                if (value == null || value == "")
                    throw new ArgumentException();

                owner = value;
            }
        }

        /// <summary>
        /// Property określające numer telefonu (nie null, dokładnie 9 cyfr), read-only
        /// </summary>
        /// <value>string of 9 digits</value>
        /// <exception cref="ArgumentException">Phone number is empty or null!</exception>
        /// <exception cref="FormatException">Invalid phone number!</exception>
        public string PhoneNumber
        {
            get => phoneNumber;

            private set
            {
                if (value == null)
                    throw new ArgumentException();

                phoneNumber = value.Trim();
                if (phoneNumber.Length != 9)
                {
                    throw new FormatException();

                }
                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c))
                        throw new FormatException();
                }


            }
        }
        /// <summary>
        /// Weryfikuje poprawność numeru telefonu: nie null, długości 9, tylko cyfry
        /// </summary>
        /// <param name="number">string opisujący numer telefonu</param>
        /// <returns>true - jeśli numer poprawny, w przeciwnym przypadku false</returns>
        private bool IsCorrectPhoneNumber(string number)
        {
            if (number == null)
                return false;

            phoneNumber = number.Trim();
            if (phoneNumber.Length != 9)
            {
                return false;

            }
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;

            //if (number.Length != 9)
            //    return false;
            //else
            //    try
            //    {
            //        int.Parse(number);
            //        return true;
            //    }
            //    catch (Exception)
            //    {
            //        return false;
            //    }
        }

        /// <summary>
        /// Maksymalny rozmiar ksiażki kontaktowej (read-only)
        /// </summary>
        public int PhoneBookCapacity
        {
            get;
            private set;
        }

        // Dictionary of <name, number>
        public readonly Dictionary<string, string> phoneBook /* = new Dictionary<string, string>() */;

        ///// <summary>
        ///// Tworzy obiekt typu Phone, w oparciu o podane parametry
        ///// </summary>
        ///// <param name="owner">właściciel telefonu</param>
        ///// <param name="phoneNumber">numer telefonu, dokładnie 9 cyfr</param>
        ///// <param name="phoneBookCapacity">pojemnosć książki adresowej</param>
        //public Phone(string owner, string phoneNumber, int phoneBookCapacity = 100) // PODSTAWOWY KONSTRUKTOR
        //{
        //    this.owner = owner;
        //    this.phoneNumber = phoneNumber;
        //    this.PhoneBookCapacity = phoneBookCapacity;
        //    phoneBook = new Dictionary<string, string>();
        //    phoneBook.EnsureCapacity(phoneBookCapacity);
        //}

        /// <summary>
        /// Zwraca liczbę wpisów do książki kontaktowej telefonu
        /// </summary>        
        public int Count => phoneBook.Count;

        /// <summary>
        /// Dodaje kontakt do ksiażki kontaktowej telefonu
        /// </summary>
        /// <param name="name">nazwa właściciela numeru</param>
        /// <param name="number">numer telefonu</param>
        /// <returns>true - jeśli kontakt został dopisany, false w przeciwnym przypadku</returns>
        /// <exceprion cref="InvalidOperationException">książka adresowa jest pełna</exception>
        public bool AddContact(string name, string number)
        {
            //if (PhoneBookCapacity == phoneBookCount)
            //  throw new InvalidOperationException("książka adresowa jest pełna");
            //  return false;
            //

            if (Count < PhoneBookCapacity)
            {
                if (!IsCorrectPhoneNumber(number))
                {
                    return false;
                }

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
            {
                throw new InvalidOperationException("książka adresowa jest pełna");
            }

        }
        /// <summary>
        /// Operacja uruchomienia połączenia
        /// </summary>
        /// <param name="name">kontakt, do którego dzwonimy</param>
        /// <returns>tekst komunikatu o formacie "Calling {number} ({name}) ..."</returns>
        /// <exception cref="InvalidOperationException">Osoby nie ma w książce kontaktów</exception>
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


        private int HistoriaPolaczenCapacity // Zadanie 7
        {
            get;
            set;
        }
        //private List<string> historia = new List<string>();
        private Queue<string> historia;

        public Phone(string owner, string phoneNumber, int phoneBookCapacity = 100, int historiaPolaczenCap=100)
        {
            this.owner = owner;
            this.phoneNumber = phoneNumber;
            this.PhoneBookCapacity = phoneBookCapacity;
            phoneBook = new Dictionary<string, string>();
            phoneBook.EnsureCapacity(phoneBookCapacity);
            historia = new Queue<string>();
            HistoriaPolaczenCapacity = historiaPolaczenCap;
        }

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

            foreach(string x in historia.Reverse())
                Console.WriteLine(x);
        }

        public void ResetujTelefon()
        {
            Console.WriteLine("Podaj nazwę właściciela");
            var name = Console.ReadLine();
            Owner = name;

            Console.WriteLine("Podaj numer telefonu właściciela");
            var num= Console.ReadLine();
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
