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
    public partial class frmCompare : Form
    {
        public frmCompare()
        {
            InitializeComponent();
        }

        private void frmCompare_Load(object sender, EventArgs e)
        {
            getMeasures();
        }
        void getMeasures() {
            try{
            OleDbConnection con = new OleDbConnection(DB.getcon());
            con.Open();
            OleDbCommand com = new OleDbCommand("select * from Data1", con);
           
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(com);
 
            DataTable myDataSet = new DataTable();

            myDataAdapter.Fill(myDataSet);
            int tp=0,tn=0,fp=0,fn=0;
            double suc=0.0,pre=0.0;
            
            foreach (DataRow dr in myDataSet.Rows)
            {
              string olddata = Convert.ToString(dr["Category"]);
              string newdata = Convert.ToString(dr["NewCategory"]);
              if(olddata.Equals("sbr")&&newdata.Equals("sbr")){
                  tp ++;
              }
              else if(olddata.Equals("nsbr")&&newdata.Equals("nsbr")){
                   tn ++;
              }
              else if(olddata.Equals("sbr")&&newdata.Equals("nsbr")){
                  fp ++;
              }
              else if(olddata.Equals("nsbr")&&newdata.Equals("sbr")){
                 fn ++;
              }
           }

            lblfn.Text = Convert.ToString(fn);
            lblfp.Text = Convert.ToString(fp);
            lbltn.Text = Convert.ToString(tn);
            lbltp.Text = Convert.ToString(tp);
            suc = (((double)(tp + tn) / (tp + fp + tn + fn)) * 100);
            pre = (((double)tp / (tp + fp)) * 100);
            lblsuc.Text = Convert.ToString(suc);
            lblpre.Text = Convert.ToString(pre);
         }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
