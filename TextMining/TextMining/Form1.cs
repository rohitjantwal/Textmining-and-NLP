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
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Assignee"].ToString());

                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Status"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Resolution"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["summary"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["changed"].ToString());
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

            int Attribute = 0;
            int SBR = 0;
            int NSBR = 0;
            
            //float PSN
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbDataReader dr;
               
                com.CommandText = "select count(*) from Data where category='SBR'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.IsDBNull(0) == false)
                    {
                        SBR = int.Parse(dr.GetValue(0).ToString());
                    }


                }
                dr.Close();
                //fetching Total NSBR
                com.CommandText = "select count(*) from Data where category='NSBR'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.IsDBNull(0) == false)
                    {
                        NSBR = int.Parse(dr.GetValue(0).ToString());
                    }


                }
                dr.Close();
                //float PA = .5f;
                //float PB = .5f;
                //float PAPB = 1;
                //float PBPA = 2;
                //float Value = PAPB * PB;
                //float Value2 = PBPA * PA;
                //if (Value > Value2)
                //{
                //    MessageBox.Show("SBR");
                //}
                //else
                //{
                //    MessageBox.Show("NSBR");
                //}
                //com.CommandText="select 
                string Category = "";
                int SBRProduct = 0;
                int NSBRproduct = 0;
                int SBRComponent = 0;
                int NSBRComponent = 0;
                int SBRAssignee = 0;
                int NSBRAssignee = 0;
                int SBRStatus = 0;
                int NSBRStatus = 0;
                int SBRResolution = 0;
                int NSBRResolution = 0;
                int SBRSummary = 0;
                int NSBRSummary = 0;
                int SBRchanged = 0;
                int NSBRChanged = 0;
                int totalSBR = 0;
                int totalNSBR = 0;
                int totalRESULT = 0;
                //double PaSBR ;
                //double PaSBRa;
                //double PaNSBR = 0.00;
                //double PaNSBRa=0.00;
                

                //Count Product SBR and NSBR
                com.CommandText = "select Category from Data where Product='" + txtProduct.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("SBR"))
                    {
                        SBRProduct++;
                    }
                    else
                    {
                        NSBRproduct++;
                    }

                }
                dr.Close();
                //Count Component SBR and NSBR
                com.CommandText = "select Category from Data where Component='" + txtComponent.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("SBR"))
                    {
                        SBRComponent++;
                    }
                    else
                    {
                        NSBRComponent++;
                    }

                }
                dr.Close();
                //Count Resolution SBR and NSBR
                com.CommandText = "select Category from Data where Resolution='" + txtResolution.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("SBR"))
                    {
                        SBRResolution++;
                    }
                    else
                    {
                        NSBRResolution++;
                    }

                }
                dr.Close();
               //Count Status SBR and NSBR
                com.CommandText = "select Category from Data where Status='" + txtStatus.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("SBR"))
                    {
                        SBRStatus++;
                    }
                    else
                    {
                        NSBRStatus++;
                    }

                }
                dr.Close();
                com.CommandText = "select Category from Data where Category='" + testtxt.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())

                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("SBR"))
                    {
                        totalSBR++;
                    }


                }
                dr.Close();

                com.CommandText = "select Category from Data where Category='" + txtNSBR.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["Category"].ToString();
                    if (Category.Equals("NSBR"))
                    {
                        totalNSBR++;
                    }


                }
                dr.Close();
            
                con.Close();


                lblTotalSBR.Text = " TOTAL SBR-" + totalSBR + "Total NSBR-" + totalNSBR; 
                totalRESULT=Convert.ToInt32(totalNSBR + totalSBR);
                TotalCountInResult.Text = "Total Category-"+totalRESULT;
                lblProduct.Text = "SBR-" + SBRProduct + " NSBR- " + NSBRproduct;
                lblComp.Text = "SBR-" + SBRComponent + " NSBR- " + NSBRComponent;
                lblReso.Text = "SBR-" + SBRResolution + " NSBR-" + NSBRResolution;
                lblStatus.Text = "SBR-" + SBRStatus + " NSBR-" + NSBRStatus;
                try
                {

                double PaSBR = (((double)SBRProduct / totalSBR) * ((double)SBRComponent / totalSBR) *((double)SBRResolution / totalSBR) *((double)SBRStatus / totalSBR));
                double PaSBRa = (PaSBR * ((double)totalSBR / totalRESULT));
                    lblProbablitySBR.Text = "Probablity For SBR-" + PaSBRa;
                double PaNSBR = (((double)NSBRproduct / totalNSBR) * ((double)NSBRComponent / totalNSBR) * ((double)NSBRResolution / totalNSBR) * ((double)NSBRStatus / totalNSBR));
                double  PaNSBRa = (PaNSBR * ((double)totalNSBR / totalRESULT));
                    lblProbablityNSBR.Text = "Probablity For NSBR-" + PaNSBRa;

                    if (PaSBRa > PaNSBRa)
                    {
                        MessageBox.Show("Hence The Probablity for These Attribute(SBR)-'" + PaSBRa + "'");

                    }
                    else
                    {
                        MessageBox.Show("Hence The Probablity for These Attribute(NSBR)-'"+PaNSBRa+"'");
                    }
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}
