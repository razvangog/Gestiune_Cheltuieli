using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestiune_Cheltuieli;

namespace TestProject1
{
    /// <summary>
    /// Summary description for EvenimentReaderTest
    /// </summary>
    [TestClass]
    public class EvenimentReaderTest
    {
        string caleFisier;
        List<Eveniment> listaBuna, listaTest;

        [TestInitialize]
        public void TestInitialize2()
        {
            caleFisier = @"C:\Users\RazvanReb\GIT\Gestiune_Cheltuieli\Gestiune Cheltuieli\TestProject1\bin\Debug\evenimenteTest.xml";

            listaBuna = new List<Eveniment>();
            listaBuna.Add(new Eveniment() { id = 1, data = Convert.ToDateTime("3/1/2012 9:23:41 PM"), perioada = PerioadaEveniment.OdataLaXZile, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaBuna.Add(new Eveniment() { id = 2, data = Convert.ToDateTime("4/12/2012 11:20:02 PM"), perioada = PerioadaEveniment.Lunar, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaBuna.Add(new Eveniment() { id = 3, data = Convert.ToDateTime("4/11/2012 11:23:59 PM"), perioada = PerioadaEveniment.AltTip, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaBuna.Add(new Eveniment() { id = 4, data = Convert.ToDateTime("4/13/2012 11:20:22 PM"), perioada = PerioadaEveniment.Saptamanal, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaBuna.Add(new Eveniment() { id = 5, data = Convert.ToDateTime("4/12/2012 11:30:49 PM"), perioada = PerioadaEveniment.AltTip, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });

            listaTest = NotitaReader.citesteNotite(caleFisier);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestInitialize2();
            bool test = testeazaEgalitateListe(listaBuna, listaTest);
            Assert.IsTrue(test, "Cele doua liste sunt diferite!");
            TestCleanup2();
        }

        [TestCleanup]
        public void TestCleanup2()
        {
            caleFisier = "";
            listaBuna = new List<Notita>();
            listaTest = new List<Notita>();
        }

        public bool testeazaEgalitateListe(List<Notita> l1, List<Notita> l2)
        {
            if (l1.Count != l2.Count) return false;
            foreach (var notitaList1 in l1)
            {
                if (l2.Contains(notitaList1) == false) return false;
                else l2.Remove(notitaList1);
            }
            return true;
        }
    }
}
