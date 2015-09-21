using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.OleDb;
namespace WordCloud
{
    public partial class StopWords : Form
    {
        public StopWords()
        {
            InitializeComponent();
        }

        public ArrayList getStopWords()
        {
            // populate the arraylist from list
            ArrayList arraylist = new ArrayList();
            foreach (object row in lbStopWords.Items)
            {
                arraylist.Add(row.ToString());
            }

            return arraylist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStopWord awDlg = new AddStopWord();
            if (awDlg.ShowDialog() == DialogResult.OK)
            {
                lbStopWords.Items.Add(awDlg.StopWord);
            }
        }

        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //    //remove selected items
        //    while (lbStopWords.SelectedIndices.Count > 0)
        //    {
        //        lbStopWords.Items.RemoveAt(lbStopWords.SelectedIndices[0]);
        //    }
        //}

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open Stop Words File Dialog";
            fdlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                // create reader & open file
                StreamReader sr = new StreamReader(fdlg.FileName);

                //clear list first
                this.lbStopWords.Items.Clear();
                
                // read in text
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    this.lbStopWords.Items.Add(input);
                }

                // close the stream
                sr.Close();
                sr = null;
                input = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            try
            {
                OleDbConnection con = new OleDbConnection(NLP.DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                
                //com.CommandText = "delete from StopWords";
                //com.ExecuteNonQuery();
                for (int i = 0; i <lbStopWords.Items.Count ; i++)
                {
                    com.CommandText = "insert into StopWords values('" + lbStopWords.Items[i].ToString() + "')";
                    com.ExecuteNonQuery();
                    
                }
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
    }
}