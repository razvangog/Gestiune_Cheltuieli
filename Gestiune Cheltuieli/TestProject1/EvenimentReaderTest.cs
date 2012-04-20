using System;
using System.IO;
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
           // string cale = Directory.GetCurrentDirectory();
            string cale = ""; 
            caleFisier = cale + @"D:\Git\Gestiune Cheltuieli\Gestiune Cheltuieli\TestProject1\bin\Debug\evenimenteTest.xml";           
            //caleFisier = @"C:\Users\RazvanReb\GIT\Gestiune_Cheltuieli\Gestiune Cheltuieli\TestProject1\bin\Debug\evenimenteTest.xml";

            listaBuna = new List<Eveniment>();
            listaBuna.Add(new Eveniment() { id = 1, data = Convert.ToDateTime("1/2/2012 9:23:41 PM"), perioada = PerioadaEveniment.OdataLaXZile, xZile = 10, tipEveniment = TipEveniment.Cheltuiala, suma = 999, detalii = "Cheltuiala veche" });
            listaBuna.Add(new Eveniment() { id = 2, data = Convert.ToDateTime("3/4/2012 11:20:02 PM"), perioada = PerioadaEveniment.Lunar, tipEveniment = TipEveniment.Venit, suma = 2200, detalii = "Salariu" });
            listaBuna.Add(new Eveniment() { id = 3, data = Convert.ToDateTime("5/6/2012 11:23:59 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Venit, suma = 200, detalii = "Am castigat la loto" });
            listaBuna.Add(new Eveniment() { id = 4, data = Convert.ToDateTime("7/8/2012 11:20:22 PM"), perioada = PerioadaEveniment.Saptamanal, tipEveniment = TipEveniment.Cheltuiala, suma = 155, detalii = "Plata factura curent" });
            listaBuna.Add(new Eveniment() { id = 5, data = Convert.ToDateTime("9/10/2012 11:30:49 PM"), perioada = PerioadaEveniment.AltTip, tipEveniment = TipEveniment.Cheltuiala, suma = 150, detalii = "Am pierdut niste bani" });

            listaTest = EvenimentReader.citesteEvenimente(caleFisier);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool test = testeazaEgalitateListe(listaBuna, listaTest);
            Assert.IsTrue(test, "Cele doua liste sunt diferite!");
        }

        [TestCleanup]
        public void TestCleanup2()
        {
            caleFisier = "";
            listaBuna = new List<Eveniment>();
            listaTest = new List<Eveniment>();
        }

        public bool testeazaEgalitateListe(List<Eveniment> l1, List<Eveniment> l2)
        {
            if (l1.Count != l2.Count) return false;
            foreach (var evenimentList1 in l1)
            {
                if (l2.Contains(evenimentList1) == false) return false;
                else l2.Remove(evenimentList1);
            }
            return true;
        }
    }
}
