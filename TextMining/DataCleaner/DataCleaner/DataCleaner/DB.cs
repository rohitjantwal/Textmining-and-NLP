using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextMining
{
    class DB
    {
        public static string getcon()
        {
            return "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\')) + "\\DB.mdb";
        }
    }
}
