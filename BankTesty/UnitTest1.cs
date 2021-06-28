using Microsoft.VisualStudio.TestTools.UnitTesting;
using KontoWBanku;

namespace BankTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SprawdzeniePoprawnosciWplatyPieniedzy()
        {
            decimal bilans = 140;
            decimal wplata = 10;
            decimal mamOtrzymac = 150;
            var konto = new Konto("Krystian", bilans);
            konto.Wplata(wplata);
            Assert.AreEqual(mamOtrzymac, konto.BilansKonta);
        }

        [TestMethod]
        public void SprawdzaniePoprawnosciWyplatyPieniedzy()
        {
            decimal bilans = 1000;
            decimal wyplata = 123;
            decimal mamOtrzymac = 877;

            var konto = new Konto("Krystian", bilans);

            konto.Wyplata(wyplata);

            Assert.AreEqual(mamOtrzymac, konto.BilansKonta);
        }
    }
}
