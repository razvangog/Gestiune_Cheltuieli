using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Gestiune_Cheltuieli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    /// <summary>
    /// Summary description for EvenimentWriterTest
    /// </summary>
    [TestClass]
    public class EvenimentWriterTest
    {
        private string caleFisier = "";
        private List<Eveniment> lista, listaCopie, listaNoua;

        [TestInitialize]
        public void TestInitialize4()
        {
            
            // string cale = Directory.GetCurrentDirectory();
            string cale = "";
            caleFisier = cale + @"C:\evenimenteWriterTest2.xml";
            lista = new List<Eveniment>();
            lista.Add(new Eveniment() { id = 1, data = Convert.ToDateTime("1/2/2012 9:23:41 PM"), perioada = PerioadaEveniment.OdataLaXZile, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            lista.Add(new Eveniment() { id = 2, data = Convert.ToDateTime("3/4/2012 11:20:02 PM"), perioada = PerioadaEveniment.Lunar, tipEveniment = TipEveniment.Venit, suma = 2200, detalii = "Salariu" });
            lista.Add(new Eveniment() { id = 3, data = Convert.ToDateTime("5/6/2012 11:23:59 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Venit, suma = 200, detalii = "Am castigat la loto" });
            lista.Add(new Eveniment() { id = 4, data = Convert.ToDateTime("7/8/2012 11:20:22 PM"), perioada = PerioadaEveniment.Saptamanal, tipEveniment = TipEveniment.Cheltuiala, suma = 155, detalii = "Plata factura curent" });
            lista.Add(new Eveniment() { id = 5, data = Convert.ToDateTime("9/10/2012 11:30:49 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Cheltuiala, suma = 150, detalii = "Am pierdut niste bani" });

            EvenimentWriter.scrieEvenimente(caleFisier, lista);
            listaNoua = EvenimentReader.citesteEvenimente(caleFisier);

            listaCopie = new List<Eveniment>();
            listaCopie.Add(new Eveniment() { id = 1, data = Convert.ToDateTime("1/2/2012 9:23:41 PM"), perioada = PerioadaEveniment.OdataLaXZile, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaCopie.Add(new Eveniment() { id = 2, data = Convert.ToDateTime("3/4/2012 11:20:02 PM"), perioada = PerioadaEveniment.Lunar, tipEveniment = TipEveniment.Venit, suma = 2200, detalii = "Salariu" });
            listaCopie.Add(new Eveniment() { id = 3, data = Convert.ToDateTime("5/6/2012 11:23:59 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Venit, suma = 200, detalii = "Am castigat la loto" });
            listaCopie.Add(new Eveniment() { id = 4, data = Convert.ToDateTime("7/8/2012 11:20:22 PM"), perioada = PerioadaEveniment.Saptamanal, tipEveniment = TipEveniment.Cheltuiala, suma = 155, detalii = "Plata factura curent" });
            listaCopie.Add(new Eveniment() { id = 5, data = Convert.ToDateTime("9/10/2012 11:30:49 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Cheltuiala, suma = 150, detalii = "Am pierdut niste bani" });
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool test = testeazaEgalitateListe(listaNoua, listaCopie);
            Assert.IsTrue(test, "Cele doua liste sunt diferite!");
        }

        [TestCleanup]
        public void TestCleanup4()
        {
            caleFisier = "";
            lista = new List<Eveniment>();
            listaCopie = new List<Eveniment>();
            listaNoua = new List<Eveniment>();
        }

        public bool testeazaEgalitateListe(List<Eveniment> l1, List<Eveniment> l2)
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
