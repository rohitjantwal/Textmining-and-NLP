using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NLP
{
    public partial class frmViewStartList : Form
    {
        public frmViewStartList()
        {
            InitializeComponent();
        }

        private void frmViewStartList_Load(object sender, EventArgs e)
        {
            getlist();
        }
        void getlist()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from frequencies", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "frequencies");
                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "Word";
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
