namespace NLP
{
    partial class frmCompare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltp = new System.Windows.Forms.Label();
            this.lbltn = new System.Windows.Forms.Label();
            this.lblfp = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsuc = new System.Windows.Forms.Label();
            this.lblpre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of True Positive Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of True Negative Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No of False Positive Values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No of False Negative Values";
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Location = new System.Drawing.Point(305, 26);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(35, 13);
            this.lbltp.TabIndex = 4;
            this.lbltp.Text = "label5";
            // 
            // lbltn
            // 
            this.lbltn.AutoSize = true;
            this.lbltn.Location = new System.Drawing.Point(305, 64);
            this.lbltn.Name = "lbltn";
            this.lbltn.Size = new System.Drawing.Size(35, 13);
            this.lbltn.TabIndex = 5;
            this.lbltn.Text = "label6";
            // 
            // lblfp
            // 
            this.lblfp.AutoSize = true;
            this.lblfp.Location = new System.Drawing.Point(305, 107);
            this.lblfp.Name = "lblfp";
            this.lblfp.Size = new System.Drawing.Size(35, 13);
            this.lblfp.TabIndex = 6;
            this.lblfp.Text = "label7";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(305, 156);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(35, 13);
            this.lblfn.TabIndex = 7;
            this.lblfn.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Success Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precision";
            // 
            // lblsuc
            // 
            this.lblsuc.AutoSize = true;
            this.lblsuc.Location = new System.Drawing.Point(304, 199);
            this.lblsuc.Name = "lblsuc";
            this.lblsuc.Size = new System.Drawing.Size(35, 13);
            this.lblsuc.TabIndex = 10;
            this.lblsuc.Text = "label7";
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.Location = new System.Drawing.Point(303, 239);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(35, 13);
            this.lblpre.TabIndex = 11;
            this.lblpre.Text = "label8";
            // 
            // frmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 447);
            this.Controls.Add(this.lblpre);
            this.Controls.Add(this.lblsuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfn);
            this.Controls.Add(this.lblfp);
            this.Controls.Add(this.lbltn);
            this.Controls.Add(this.lbltp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCompare";
            this.Text = "frmCompare";
            this.Load += new System.EventHandler(this.frmCompare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.Label lbltn;
        private System.Windows.Forms.Label lblfp;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsuc;
        private System.Windows.Forms.Label lblpre;
    }
}