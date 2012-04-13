using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Gestiune_Cheltuieli
{
    public class NotitaReader
    {
        //Citeste un fisier XML si returneaza o lista de structuri Notita
        //Parametrii:
        //- numeFisier (string) = numele fisierului XML din care citesc
        public static List<Notita> citesteNotite(string numeFisier)
        {
            List<Notita> lista = new List<Notita>();

            if (File.Exists(numeFisier) == true)
            {
                XmlDocument fisierXML = new XmlDocument();

                fisierXML.Load(numeFisier);

                XmlNode root = fisierXML.SelectSingleNode("notite");

                foreach (XmlNode elem in root.SelectNodes("notita"))
                {
                    Notita not = new Notita();
                    
                    not.id = Convert.ToInt32(elem.Attributes["id"].Value);
                    not.data = Convert.ToDateTime(elem.Attributes["data"].Value);
                    not.text = elem.InnerText;
                    not.expirat = Convert.ToBoolean(elem.Attributes["expirat"].Value);
                    
                    lista.Add(not);
                }
            }
            //else
                //MessageBox.Show("Fisierul " + numeFisier + " nu exista.");

            return lista;
        }
    }
}
