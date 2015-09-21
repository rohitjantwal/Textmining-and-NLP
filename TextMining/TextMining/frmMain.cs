using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;
namespace TextMining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // getlist();
            //update();

        }
        void getlist()
        {
            listView1.Items.Clear();
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from Data", con);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    listView1.Items.Add(dr["Id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Product"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Component"].ToString());
                   // listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Assignee"].ToString());

                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Status"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Resolution"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["summary"].ToString());
                    //listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["changed"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Category"].ToString());


                }
                dr.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getlist();
        }


        
        private void button2_Click_1(object sender, EventArgs e)
        {







        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if ((listView1.Items.Count) == 0)
            {
                MessageBox.Show("Get the chance Loading the data otherwise data could be incorrect format");
            }
            else
            {


                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Resolution, COUNT(Resolution) AS dup_count FROM Data GROUP BY Resolution HAVING (COUNT(Resolution) >1)", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    listView2.Items.Add(dr["Resolution"].ToString());
                    listView2.Items[listView2.Items.Count - 1].SubItems.Add(dr["dup_Count"].ToString());
                }
                dr.Close();
                con.Close();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void getNewList()
        {
            listView3.Items.Clear();
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from tmp", con);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    listView3.Items.Add(dr["Id"].ToString());
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Product"].ToString());
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Component"].ToString());
                    //listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Assignee"].ToString());

                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Status"].ToString());
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Resolution"].ToString());
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["summary"].ToString());
                   // listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["changed"].ToString());
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["Category"].ToString());


                }
                dr.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if ((listView2.Items.Count) == 0)
            {
                MessageBox.Show("Get the chance for Preprocessing the data otherwise data could be incorrect format");
            }
            else
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("SELECT Resolution, COUNT(Resolution) AS dup_count FROM Data GROUP BY Resolution HAVING (COUNT(Resolution) >1)", con);
                OleDbCommand cmd = new OleDbCommand("select query1.Resolution FROM (SELECT Resolution, Count(*) AS dup1_count FROM Data GROUP BY Data.Resolution) query1,(SELECT max(query2.dup1_count) as highest_count FROM (SELECT Resolution, Count(*) AS dup1_count FROM Data GROUP BY Data.Resolution) query2) query3 where query1.dup1_count = query3.highest_count", con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    while (dr1.Read())
                    {   int cnt=0;
                        string Reso="";
                        if ((((int)(dr1.GetValue(1))) > cnt )&&(!(Reso.Equals("---"))))
                        {
                            cnt = (int)dr1.GetValue(1);
                            Reso = dr1.GetValue(0).ToString();
                        }
                        OleDbCommand com = new OleDbCommand("update tmp set Resolution =@Resolution where resolution='---'", con);
                        com.Parameters.AddWithValue("@Resolution", Reso);
                        com.ExecuteNonQuery();
                       
                    }
                }
                con.Close();
                getNewList();
                MessageBox.Show("Done");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string appPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\')) + "\\AnalyzerViewer.exe";
            //System.Diagnostics.Process.Start(appPath);
            System.Diagnostics.Process.Start(@"C:\Users\Diksha\Desktop\Minor Final\TextMining\DataCleaner\DataCleaner\DataCleaner\bin\Debug\AnalyzerViewer.exe");
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 FRM = new Form2();
            FRM.Show();
        }
    }

}
