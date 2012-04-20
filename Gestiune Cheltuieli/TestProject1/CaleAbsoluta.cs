using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestProject1
{
    class CaleAbsoluta {
        static public string getCaleFisier(string fisier) {
            string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string cale = Path.GetDirectoryName(path);

            return cale + @"\" + fisier;
        }
    }
}
