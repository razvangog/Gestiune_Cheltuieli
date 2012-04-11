using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Gestiune_Cheltuieli
{
    public class EvenimentWriter
    {
        public static void scrieEvenimente(string numeFisier, List<Eveniment> lista)
        {
            if (File.Exists("evenimente.xml") == true)
                File.Delete("evenimente.xml");

            XmlDocument fisierXML = new XmlDocument();

            XmlElement root = fisierXML.CreateElement("evenimente");
            fisierXML.AppendChild(root);
            
            foreach (Eveniment e in lista)
            {
                XmlElement elem = fisierXML.CreateElement("eveniment");
                
                elem.SetAttribute("data", Convert.ToString(e.data));
                elem.SetAttribute("perioada", Convert.ToString(e.perioada));
                
                if(e.perioada == PerioadaEveniment.OdataLaXZile)
                    elem.SetAttribute("xZile", Convert.ToString(e.xZile));

                elem.SetAttribute("tipEveniment", Convert.ToString(e.tipEveniment));
                elem.SetAttribute("suma", Convert.ToString(e.suma));

                elem.InnerText = Convert.ToString(e.detalii);

                root.AppendChild(elem);
            }

            fisierXML.Save(numeFisier);
        }
    }
}
