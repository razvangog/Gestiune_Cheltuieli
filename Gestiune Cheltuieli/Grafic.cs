using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Gestiune_Cheltuieli
{
    public class Grafic
    {
        public static Graphics deseneazaGrafic(PictureBox suprafata)
        {
            return suprafata.CreateGraphics();
        }
    }
}
