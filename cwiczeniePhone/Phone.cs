using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczeniePhone
{
    public class Phone
    {
        private readonly string owner;
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
        }

        private readonly string phoneNumber;
        /// <summary>
        /// Property określające numer telefonu (nie null, dokładnie 9 cyfr), read-only
        /// </summary>
        /// <value>string of 9 digits</value>
        /// <exception cref="ArgumentException">Phone number is empty or null!</exception>
        /// <exception cref="FormatException">Invalid phone number!</exception>
        public string PhoneNumber
        {
            get
            {
                if (phoneNumber.Length != 9)
                {
                    try
                    {
                        int.Parse(this.phoneNumber);
                        return this.phoneNumber;
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("Invalid phone number!");
                    };

                }
                else
                {
                    throw new ArgumentException("Phone number is empty or null!");
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
            if (number.Length != 9)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Maksymalny rozmiar ksiażki kontaktowej (read-only)
        /// </summary>
        public int PhoneBookCapacity
        {
            get;
        }

        // Dictionary of <name, number>
        private readonly Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        /// <summary>
        /// Tworzy obiekt typu Phone, w oparciu o podane parametry
        /// </summary>
        /// <param name="owner">właściciel telefonu</param>
        /// <param name="phoneNumber">numer telefonu, dokładnie 9 cyfr</param>
        /// <param name="phoneBookCapacity">pojemnosć książki adresowej</param>
        public Phone(string owner, string phoneNumber, int phoneBookCapacity = 100)
        {
            this.owner = owner;
            this.phoneNumber = phoneNumber;
            this.PhoneBookCapacity = phoneBookCapacity;
        }

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
            if (Count < PhoneBookCapacity)
            {
                Console.WriteLine("dodaje " +name);
                if (!IsCorrectPhoneNumber(number))
                {
                    Console.WriteLine("Nieprawidłowy numer");
                    return false;
                }

                else
                {

                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("Duplikat");
                        return false;
                    }
                    phoneBook.Add(name, number);

                    return true;
                }
            }
            else
            {
                Console.WriteLine("Przekroczono limit książki telefonicznej");
                return false;
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
            if(phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"Calling {phoneBook[name]} ({name}) ...");
                wyjscie = $"Calling {phoneBook[name]} ({name}) ...";
            }
            else
            {
                throw new InvalidOperationException("Osoby nie ma w książce kontaktów");
            }
            return wyjscie;
        }
        public override string ToString()
        {
            return $"Nazwa właściciela: {this.Owner}, numer telefonu: {this.phoneNumber}, ile miejsca: {PhoneBookCapacity - Count}";
        }

    }
}
