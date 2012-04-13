using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Gestiune_Cheltuieli
{
    public class EvenimentReader
    {
        //Citeste un fisier XML si returneaza o lista de structuri Eveniment
        //Parametrii:
        //- numeFisier (string) = numele fisierului XML din care citesc
        public static List<Eveniment> citesteEvenimente(string numeFisier)
        {
            List<Eveniment> lista = new List<Eveniment>();

            if (File.Exists(numeFisier) == true)
            {
                XmlDocument fisierXML = new XmlDocument();

                fisierXML.Load(numeFisier);

                XmlNode root = fisierXML.SelectSingleNode("evenimente");

                foreach (XmlNode elem in root.SelectNodes("eveniment"))
                {
                    Eveniment ev = new Eveniment();

                    ev.id = Convert.ToInt32(elem.Attributes["id"].Value);
                    ev.data = Convert.ToDateTime(elem.Attributes["data"].Value);

                    switch (elem.Attributes["perioada"].Value)
                    {
                        case "Lunar":
                            ev.perioada = PerioadaEveniment.Lunar;
                            break;
                        case "Saptamanal":
                            ev.perioada = PerioadaEveniment.Saptamanal;
                            break;
                        case "OdataLaXZile":
                            ev.perioada = PerioadaEveniment.OdataLaXZile;
                            ev.xZile = Convert.ToInt32(elem.Attributes["xZile"].Value);
                            break;
                        case "AltTip":
                            ev.perioada = PerioadaEveniment.AltTip;
                            break;
                    }

                    switch (elem.Attributes["tipEveniment"].Value)
                    {
                        case "Cheltuiala":
                            ev.tipEveniment = TipEveniment.Cheltuiala;
                            break;
                        case "Venit":
                            ev.tipEveniment = TipEveniment.Venit;
                            break;
                    }

                    ev.suma = Convert.ToInt32(elem.Attributes["suma"].Value);
                    ev.detalii = elem.InnerText;

                    lista.Add(ev);
                }
            }
            //else
                //MessageBox.Show("Fisierul " + numeFisier + " nu exista.");

            return lista;
        }
    }
}
