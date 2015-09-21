using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Text.RegularExpressions;

namespace NLP
{
    public partial class frmOldCategory : Form
    {
        public frmOldCategory()
        {
            InitializeComponent();
        }

        private void frmOldCategory_Load(object sender, EventArgs e)
        {
            getlist();
        }
        void getlist()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from Data", con);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lst.Items.Add(dr["Summary"].ToString());
                    lst.Items[lst.Items.Count - 1].SubItems.Add(dr["Category"].ToString());

                   
                }
                dr.Close();
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

       

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    CountWords();
        //}
        // void CountWords()
        //{
        //    try
        //    {
        //        ArrayList arr = new ArrayList();
        //        OleDbConnection con = new OleDbConnection(DB.getcon());
        //        con.Open();
        //        OleDbCommand com = new OleDbCommand();
        //        com.Connection = con;
        //        OleDbDataReader dr;
        //        string Data = "";
        //        int SecurityCnt = 0;
        //        int Advisorcnt = 0;
        //        for (int i = 0; i < lst.Items.Count; i++)
        //        {
        //            Data = lst.Items[i].SubItems[0].Text;
        //            Data = Regex.Replace(Data, "(?<=')(.*?)'(?=.*')", "$1");
        //            string[] DB2 = Data.Split(' ');
        //            foreach (string find in DB2)
        //            {
        //                com.CommandText = "select * from StopWords where Data='" + find + "'";
        //                dr = com.ExecuteReader();
        //                if (dr.Read())
        //                {
                                
        //                }
                    
                        
        //                if (!dr.Read())
        //                {
        //                    arr.Add("insert into StartList values('"+find+"')");

        //                }
        //                dr.Close();
                        
        //            }
                    
                    
        //        }
        //        com.CommandText = "delete from StartList";
        //        com.ExecuteNonQuery();
        //        for (int i = 0; i < arr.Count; i++)
        //        {
        //            com.CommandText = arr[i].ToString();
        //            com.ExecuteNonQuery();
        //        }
        //        con.Close();
        //        MessageBox.Show("Done");
                
                
        //    }
        //    catch (OleDbException ex)
        //    {
        //        MessageBox.Show(ex.Message);
               
        //    }
        //}
    }
}
