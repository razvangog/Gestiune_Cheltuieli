using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Gestiune_Cheltuieli
{
    public class NotitaWriter
    {
        public static void scrieNotite(string numeFisier, List<Notita> lista)
        {
            if (File.Exists(numeFisier) == true)
                File.Delete(numeFisier);

            XmlDocument fisierXML = new XmlDocument();

            XmlElement root = fisierXML.CreateElement("notite");
            fisierXML.AppendChild(root);

            foreach (Notita not in lista)
            {
                XmlElement elem = fisierXML.CreateElement("notita");
                
                elem.SetAttribute("id", Convert.ToString(not.id));
                elem.SetAttribute("data", Convert.ToString(not.data));
                elem.SetAttribute("expirat", Convert.ToString(not.expirat));

                elem.InnerText = not.text;
                
                root.AppendChild(elem);
            }

            fisierXML.Save(numeFisier);
        }
    }
}
