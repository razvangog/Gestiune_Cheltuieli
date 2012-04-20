using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Gestiune_Cheltuieli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    /// <summary>
    /// Summary description for NotitaWriterTest
    /// </summary>
    [TestClass]
    public class NotitaWriterTest
    {
        private string caleFisier = "";
        private List<Notita> lista, listaCopie , listaNoua;
        
        [TestInitialize]
        public void TestInitialize3()
        {
            // string cale = Directory.GetCurrentDirectory();
            string cale = "";             
            caleFisier = cale + @"C:\notiteWriterTest2.xml";
            lista = new List<Notita>();
            lista.Add(new Notita() { id = 1, text = "test 1", data = Convert.ToDateTime("1/2/2012 12:58:44 AM"), expirat = true });
            lista.Add(new Notita() { id = 2, text = "test 2", data = Convert.ToDateTime("3/4/2012 5:33:48 PM"), expirat = false });
            lista.Add(new Notita() { id = 3, text = "test 3", data = Convert.ToDateTime("5/6/2012 5:23:53 PM"), expirat = true });
            lista.Add(new Notita() { id = 4, text = "test 4", data = Convert.ToDateTime("7/8/2012 5:34:42 PM"), expirat = false });

            NotitaWriter.scrieNotite(caleFisier,lista);
            listaNoua =  NotitaReader.citesteNotite(caleFisier);

            listaCopie = new List<Notita>();
            listaCopie.Add(new Notita() { id = 1, text = "test 1", data = Convert.ToDateTime("1/2/2012 12:58:44 AM"), expirat = true });
            listaCopie.Add(new Notita() { id = 2, text = "test 2", data = Convert.ToDateTime("3/4/2012 5:33:48 PM"), expirat = false });
            listaCopie.Add(new Notita() { id = 3, text = "test 3", data = Convert.ToDateTime("5/6/2012 5:23:53 PM"), expirat = true });
            listaCopie.Add(new Notita() { id = 4, text = "test 4", data = Convert.ToDateTime("7/8/2012 5:34:42 PM"), expirat = false });
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool test = testeazaEgalitateListe(listaNoua, listaCopie);
            Assert.IsTrue(test, "Cele doua liste sunt diferite!");
        }

        [TestCleanup]
        public void TestCleanup3()
        {
            caleFisier = "";
            lista = new List<Notita>();
            listaCopie = new List<Notita>();
            listaNoua = new List<Notita>();
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
