using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using NLP;

namespace WordCloud
{
    public partial class AddStopWord : Form
    {
        public string StopWord = "";
        
        public AddStopWord()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StopWord = this.inputTextBox.Text;
            this.DialogResult = DialogResult.OK;
            OleDbConnection con = new OleDbConnection(DB.getcon());
            con.Open();
            OleDbCommand com2 = new OleDbCommand();
            com2.Connection = con;
            com2.CommandText = "insert into StopWords ([Data]) values ('" + StopWord + "')";
            com2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Word Inserted");
            
            
            
        }
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}