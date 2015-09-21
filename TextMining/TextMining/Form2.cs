using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TextMining
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }


        void getNewList1()
        {
            listView3.Items.Clear();
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from Data1", con);
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
                    listView3.Items[listView3.Items.Count - 1].SubItems.Add(dr["NewCategory"].ToString());

                }
                dr.Close();
                con.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
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

                com.CommandText = "select count(*) from Data1 where NewCategory='SBR'";
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
                com.CommandText = "select count(*) from Data1 where NewCategory='NSBR'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.IsDBNull(0) == false)
                    {
                        NSBR = int.Parse(dr.GetValue(0).ToString());
                    }


                }
                dr.Close();
                
                string Category = "";
                int SBRProduct = 0;
                int NSBRproduct = 0;
                int SBRComponent = 0;
                int NSBRComponent = 0;
                
                int SBRStatus = 0;
                int NSBRStatus = 0;
                int SBRResolution = 0;
                int NSBRResolution = 0;
                
                int totalSBR = 0;
                int totalNSBR = 0;
                int totalRESULT = 0;
                //double PaSBR ;
                //double PaSBRa;
                //double PaNSBR = 0.00;
                //double PaNSBRa=0.00;


                //Count Product SBR and NSBR
                com.CommandText = "select NewCategory from Data1 where Product='" + txtProduct.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("sbr"))
                    {
                        SBRProduct ++;
                    }
                    else
                    {
                        NSBRproduct ++;
                    }

                }
                
                dr.Close();
                //Count Component SBR and NSBR
                com.CommandText = "select NewCategory from Data1 where Component='" + txtComponent.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("sbr"))
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
                com.CommandText = "select NewCategory from Data1 where Resolution='" + txtResolution.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("sbr"))
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
                com.CommandText = "select NewCategory from Data1 where Status='" + txtStatus.Text + "'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("sbr"))
                    {
                        SBRStatus++;
                    }
                    else
                    {
                        NSBRStatus++;
                    }

                }
                dr.Close();
                com.CommandText = "select NewCategory from Data1 where NewCategory='sbr'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("sbr"))
                    {
                        totalSBR++;
                    }


                }
                dr.Close();

                com.CommandText = "select NewCategory from Data1 where NewCategory='nsbr'";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Category = dr["NewCategory"].ToString();
                    if (Category.Equals("nsbr"))
                    {
                        totalNSBR++;
                    }


                }
                dr.Close();

                con.Close();


                lblTotalSBR.Text = " TOTAL SBR-" + totalSBR + "Total NSBR-" + totalNSBR;
                totalRESULT = Convert.ToInt32(totalNSBR + totalSBR);
                TotalCountInResult.Text = "Total Category-" + totalRESULT;
                lblProduct.Text = "SBR-" + SBRProduct + " NSBR- " + NSBRproduct;
                lblComp.Text = "SBR-" + SBRComponent + " NSBR- " + NSBRComponent;
                lblReso.Text = "SBR-" + SBRResolution + " NSBR-" + NSBRResolution;
                lblStatus.Text = "SBR-" + SBRStatus + " NSBR-" + NSBRStatus;
                try
                {

                    double PaSBR = (((double)SBRProduct / totalSBR) * ((double)SBRComponent / totalSBR) * ((double)SBRResolution / totalSBR) * ((double)SBRStatus / totalSBR));
                    double PaSBRa = (PaSBR * ((double)totalSBR / totalRESULT));
                    lblProbablitySBR.Text = "Probablity For SBR-" + PaSBRa;
                    double PaNSBR = (((double)NSBRproduct / totalNSBR) * ((double)NSBRComponent / totalNSBR) * ((double)NSBRResolution / totalNSBR) * ((double)NSBRStatus / totalNSBR));
                    double PaNSBRa = (PaNSBR * ((double)totalNSBR / totalRESULT));
                    lblProbablityNSBR.Text = "Probablity For NSBR-" + PaNSBRa;
                    testtxt.Text = Convert.ToString(PaSBRa);
                    txtNSBR.Text = Convert.ToString(PaNSBRa);
                    if (PaSBRa > PaNSBRa)
                    {
                        MessageBox.Show("Hence The Attribute Value is SBR");

                    }
                    else
                    {
                        MessageBox.Show("Hence The Attribute Value is NSBR");
                    }


                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getNewList1();
        }

    }
}
