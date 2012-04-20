using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestiune_Cheltuieli;
namespace TestProject1
{
    /// <summary>
    /// Summary description for NotiteReaderTest
    /// </summary>
    [TestClass]
    public class NotiteReaderTest
    {
        string caleFisier;
        List<Notita> listaBuna, listaTest;

        [TestInitialize]
        public void TestInitialize1()
        {
            //caleFisier = @"C:\Users\RazvanReb\GIT\Gestiune_Cheltuieli\Gestiune Cheltuieli\TestProject1\bin\Debug\notiteTest.xml";
            // string cale = Directory.GetCurrentDirectory();
            string cale = "";
            caleFisier = cale + @"D:\Git\Gestiune Cheltuieli\Gestiune Cheltuieli\TestProject1\bin\Debug\notiteTest.xml";

            listaBuna = new List<Notita>();
            listaBuna.Add(new Notita() { id = 1, text = "Test notite 1", data = Convert.ToDateTime("1/2/2012 12:58:44 AM"), expirat = true });
            listaBuna.Add(new Notita() { id = 2, text = "test 2", data = Convert.ToDateTime("3/4/2012 5:33:48 PM"), expirat = false });
            listaBuna.Add(new Notita() { id = 3, text = "test 3", data = Convert.ToDateTime("5/6/2012 5:23:53 PM"), expirat = true });
            listaBuna.Add(new Notita() { id = 4, text = " test 4", data = Convert.ToDateTime("7/8/2012 5:34:42 PM"), expirat = false });

            listaTest = NotitaReader.citesteNotite(caleFisier);
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool test = testeazaEgalitateListe(listaBuna, listaTest);
            Assert.IsTrue(test, "Cele doua liste sunt diferite!");
        }

        [TestCleanup]
        public void TestCleanup1()
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
