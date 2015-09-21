using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NLP
{
    public partial class frmNewCategory : Form
    {
        public frmNewCategory()
        {
            InitializeComponent();
        }

        private void frmNewCategory_Load(object sender, EventArgs e)
        {
            getdata();
            getlist1();
        }
        void getdata()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from frequencies", con);
                OleDbCommand com1 = new OleDbCommand("select * from Data", con);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(com);
                OleDbDataAdapter myDataAdapter1 = new OleDbDataAdapter(com1);
                // con.MultipleActiveResultSets = True;
                DataTable myDataSet = new DataTable();

                DataTable myDataSet1 = new DataTable();
                myDataAdapter.Fill(myDataSet);
                myDataAdapter1.Fill(myDataSet1);
                OleDbDataReader dra;
                // DataRowCollection drc = myDataSet.Tables["frequencies"].Rows;
                //DataRowCollection drc1 = myDataSet1.Tables["Data"].Rows;
                //int ir=0,jr=0;
                // List<string> word = new List<string>();
                string word;
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                OleDbCommand com3 = new OleDbCommand();
                com3.Connection = con;
                //com2.CommandText = "DROP TABLE sbrnsbr";
                //com2.ExecuteNonQuery();
                com2.CommandText = "CREATE TABLE [sbrnsbr](" +
            "[Word] VARCHAR( 50 ) NOT NULL ," +
            "[Value] VARCHAR( 6 ) NOT NULL )";
                com2.ExecuteNonQuery();
                foreach (DataRow dr in myDataSet.Rows)
                {
                    int sbr = 0, nsbr = 0;
                    word = Convert.ToString(dr["Word"]);
                    //word.Add(" " + dr.ItemArray[0].ToString());
                    string ar;

                    foreach (DataRow dr1 in myDataSet1.Rows)
                    {
                        ar = Convert.ToString(dr1["Summary"]);
                        Int64 idno = Convert.ToInt64(dr1["Id"]);

                        //new Regex(needle).Matches(haystack).Count;
                        foreach (Match m in Regex.Matches(ar, word))
                        {
                            com3.CommandText = "select Category from [Data1] where [Id]=" + idno;
                            dra = com3.ExecuteReader();
                            dra.Read();
                            if (dra.GetValue(0).ToString().Equals("sbr"))
                            {
                                sbr++;
                            }
                            else if (dra.GetValue(0).ToString().Equals("nsbr"))
                            {
                                nsbr++;
                            }
                            dra.Close();
                        }

                        // ir ++;
                    }


                    if (nsbr > sbr)
                    {
                        com2.CommandText = "insert into sbrnsbr ([Word],[Value]) values ('" + word + "','" + "nsbr" + "')";
                        com2.ExecuteNonQuery();
                    }
                    else if (sbr > nsbr)
                    {
                        com2.CommandText = "insert into sbrnsbr ([Word],[Value]) values ('" + word + "','" + "sbr" + "')";
                        com2.ExecuteNonQuery();
                    }
                    else
                    {
                        continue;
                    }

                }
                //jr++;
                con.Close();
                getnewcategory();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void getnewcategory()
        {

            try
            {

                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from sbrnsbr", con);
                OleDbCommand com1 = new OleDbCommand("select * from Data", con);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(com);
                OleDbDataAdapter myDataAdapter1 = new OleDbDataAdapter(com1);
                DataTable myDataSet = new DataTable();
                DataTable myDataSet1 = new DataTable();
                myDataAdapter.Fill(myDataSet);
                myDataAdapter1.Fill(myDataSet1);
                OleDbDataReader dra;
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                OleDbCommand com3 = new OleDbCommand();
                com3.Connection = con;
                // int i=0;
                string ar;
                Int64 idno;
                string cat;

                foreach (DataRow dr1 in myDataSet1.Rows)
                {
                    // Debug.WriteLine("in it");

                    int sbr = 0, nsbr = 0;
                    ar = Convert.ToString(dr1["Summary"]);
                    idno = Convert.ToInt64(dr1["Id"]);
                    cat = Convert.ToString(dr1["Category"]);
                    //string word;
                    //string value;
                    //string ar1=RemoveStopWords(ar);
                    string[] wordnew = ar.Split(' ');
                    //string wordcheck;

                    foreach (string word1 in wordnew)
                    {
                        //Debug.WriteLine("y");
                        //foreach (DataRow dr in myDataSet.Rows)
                        //{
                        // wordcheck = Convert.ToString(dr["Word"]);
                        // if (wordcheck.Equals(word1))
                        //{
                        com3.CommandText = "select Value from [sbrnsbr] where Word='" + word1 + "'";
                        //com3.Parameters.Add("@Word", OleDbType.VarChar, 40).Value = word1;
                        dra = com3.ExecuteReader();
                        while (dra.Read())
                        {
                            if (dra.IsDBNull(0) == false)
                            {
                                if (dra.GetValue(0).ToString().Equals("sbr"))
                                {
                                    sbr++;
                                }
                                else if (dra.GetValue(0).ToString().Equals("nsbr"))
                                {
                                    nsbr++;
                                }
                            }
                        }
                        dra.Close();
                    }
                    //}
                    // }

                    //foreach (DataRow dr in myDataSet.Rows)
                    //{

                    //    word = Convert.ToString(dr["Word"]);
                    //    value = Convert.ToString(dr["Value"]);



                    //foreach (Match m in Regex.Matches(ar, word))
                    //{

                    //if (value.Equals("sbr"))
                    //{
                    //    sbr++;
                    //}
                    //else if (value.Equals("nsbr"))
                    //{
                    //    nsbr++;
                    //}

                    //}

                    //}

                    if (nsbr > sbr)
                    {
                        string queryString = "UPDATE [Data1] SET [NewCategory] =@NewCategory WHERE [Id] =@Id ";

                        OleDbCommand command = new
      OleDbCommand(queryString, con);
                        command.Parameters.AddWithValue("@NewCategory", "nsbr");
                        command.Parameters.AddWithValue("@Id", idno);

                        command.ExecuteNonQuery();
                        //com2.Parameters.AddWithValue("@NewCategory", "nsbr");
                        //com2.Parameters.AddWithValue("@Id", idno);
                        // Debug.WriteLine("@Id");

                        //com2.CommandText = "UPDATE [Data1] SET [NewCategory] =@NewCategory WHERE [Id] =@Id ";

                        //com2.ExecuteNonQuery();
                    }
                    else if (sbr > nsbr)
                    {
                        string queryString = "UPDATE [Data1] SET [NewCategory] =@NewCategory WHERE [Id] =@Id ";

                        OleDbCommand command = new
      OleDbCommand(queryString, con);
                        command.Parameters.AddWithValue("@NewCategory", "sbr");
                        command.Parameters.AddWithValue("@Id", idno);

                        command.ExecuteNonQuery();

                        //com2.Parameters.AddWithValue("@NewCategory", "sbr");
                        //com2.Parameters.AddWithValue("@Id", idno);
                        // Debug.WriteLine(@Id);
                        //com2.CommandText = "UPDATE [Data1] SET [NewCategory]=@NewCategory WHERE [Id] =@Id ";

                        //com2.ExecuteNonQuery();
                    }
                    else if (sbr == nsbr)
                    {
                        string queryString = "UPDATE [Data1] SET [NewCategory] =@NewCategory WHERE [Id] =@Id ";

                        OleDbCommand command = new
      OleDbCommand(queryString, con);
                        command.Parameters.AddWithValue("@NewCategory", cat);
                        command.Parameters.AddWithValue("@Id", idno);

                        command.ExecuteNonQuery();
                        //com2.Parameters.AddWithValue("@NewCategory", cat);
                        //com2.Parameters.AddWithValue("@Id", idno);
                        //Debug.WriteLine(Id);
                        //com2.CommandText = "UPDATE [Data1] SET [NewCategory] =@NewCategory WHERE [Id] =@Id ";

                        //com2.ExecuteNonQuery();
                    }
                    // i ++;

                }


                con.Close();




            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void getlist1()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(DB.getcon());
                con.Open();
                OleDbCommand com = new OleDbCommand("select * from Data1", con);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lst.Items.Add(dr["Summary"].ToString());
                    lst.Items[lst.Items.Count - 1].SubItems.Add(dr["Category"].ToString());
                    lst.Items[lst.Items.Count - 1].SubItems.Add(dr["NewCategory"].ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
            //string RemoveStopWords(string line){
            //    string[] arrToCheck = new string[] { "try ", "yourself", "before " };

            //    string input = "Did you try this yourself before asking";
            //    foreach (string word in arrToCheck)
            //    {
            //        input = input.Replace(word, "");
            //    }
            //    return input;
            // }
        }
    }
}
