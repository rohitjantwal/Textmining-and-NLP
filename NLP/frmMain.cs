using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NLP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Diksha\Desktop\Minor Final\TextMining\TextMining\bin\Debug\TextMining.exe");
        }

        private void oldCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOldCategory frm = new frmOldCategory();
            frm.Show();
        }

        private void stopListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           WordCloud.StopWords frm = new WordCloud.StopWords();
            frm.Show();
        }

        private void startListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewStartList frm = new frmViewStartList();
            frm.Show();
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCategory frm = new frmNewCategory();
            frm.Show();
        }

        private void comparisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompare frm = new frmCompare();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
