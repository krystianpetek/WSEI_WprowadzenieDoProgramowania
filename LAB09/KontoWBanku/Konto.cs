using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoWBanku
{
    public class Konto
    {
        private string klient;  //nazwa klienta
        private decimal bilans;  //aktualny stan środków na koncie
        private bool zablokowane = false; //stan konta
        private Konto()
        {
        }
        public Konto(string klient, decimal BilansNaStart = 0)
        {
            this.klient = klient;
            this.bilans = BilansNaStart;
            this.zablokowane = false;
        }

        public string NazwaKlienta
        {
            get
            {
                return this.klient;
            }
        }
        public decimal BilansKonta
        {
            get
            {
                return this.bilans;
            }
        }
        public bool CzyZablokowane
        {
            get
            {
                return this.zablokowane;
            }
        }

        public void Wplata(decimal kwota)
        {
            if (zablokowane == true)
                throw new ArgumentException("konto jest zablokowane");
            if (kwota < 0)
                throw new ArgumentException("kwota jest ujemna");

            this.bilans += kwota;
        }

        public void Wyplata(decimal kwota)
        {

            if (zablokowane == true)
                throw new ArgumentException("konto jest zablokowane");

            if (kwota >= this.bilans)
                throw new ArgumentException("niewystarczająca kwota");

            if (kwota <= 0)
                throw new ArgumentException("nie mozna wyplacic ujemnej kwoty");

            this.bilans -= kwota;

        }
        public void BlokujKonto()
        {
            this.zablokowane = true;
        }
        public void OdblokujKonto()
        {
            this.zablokowane = false;
        }
    }
}
