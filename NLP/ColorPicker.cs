using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCloud
{
    public partial class ColorPicker : Form
    {
        ColorDialog colorDlg;
        public Color nodeStartColor;
        public Color nodeEndColor;
        
        public ColorPicker()
        {
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            InitializeComponent();
        }

        private void btnStartColor_Click(object sender, EventArgs e)
        {
            colorDlg.Color = startColor.BackColor;
            colorDlg.FullOpen = true;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                startColor.BackColor = colorDlg.Color;
                nodeStartColor = startColor.BackColor;
            }
        }

        private void btnEndColor_Click(object sender, EventArgs e)
        {
            colorDlg.Color = endColor.BackColor;
            colorDlg.FullOpen = true;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                endColor.BackColor = colorDlg.Color;
                nodeEndColor = endColor.BackColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}