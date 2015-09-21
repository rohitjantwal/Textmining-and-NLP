using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NLP
{
    class DB
    {
        public static string getcon()
        {
            return @"Provider=Microsoft.Jet.oledb.4.0; Data Source=" + Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\')) + "\\DB.mdb";

        }
    }
}
