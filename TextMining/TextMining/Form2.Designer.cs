namespace TextMining
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalCountInResult = new System.Windows.Forms.Label();
            this.lblTotalNSBR = new System.Windows.Forms.Label();
            this.txtNSBR = new System.Windows.Forms.TextBox();
            this.lblTotalSBR = new System.Windows.Forms.Label();
            this.testtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProbablityNSBR = new System.Windows.Forms.Label();
            this.lblProbablitySBR = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReso = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Classify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TotalCountInResult);
            this.groupBox2.Controls.Add(this.lblTotalNSBR);
            this.groupBox2.Controls.Add(this.txtNSBR);
            this.groupBox2.Controls.Add(this.lblTotalSBR);
            this.groupBox2.Controls.Add(this.testtxt);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(39, 644);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1108, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count Category ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Calculate NSBR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Calculate SBR";
            // 
            // TotalCountInResult
            // 
            this.TotalCountInResult.AutoSize = true;
            this.TotalCountInResult.Location = new System.Drawing.Point(651, 28);
            this.TotalCountInResult.Name = "TotalCountInResult";
            this.TotalCountInResult.Size = new System.Drawing.Size(10, 13);
            this.TotalCountInResult.TabIndex = 20;
            this.TotalCountInResult.Text = "-";
            // 
            // lblTotalNSBR
            // 
            this.lblTotalNSBR.AutoSize = true;
            this.lblTotalNSBR.Location = new System.Drawing.Point(450, 61);
            this.lblTotalNSBR.Name = "lblTotalNSBR";
            this.lblTotalNSBR.Size = new System.Drawing.Size(10, 13);
            this.lblTotalNSBR.TabIndex = 19;
            this.lblTotalNSBR.Text = "-";
            // 
            // txtNSBR
            // 
            this.txtNSBR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNSBR.Location = new System.Drawing.Point(407, 20);
            this.txtNSBR.Name = "txtNSBR";
            this.txtNSBR.Size = new System.Drawing.Size(151, 20);
            this.txtNSBR.TabIndex = 9;
            // 
            // lblTotalSBR
            // 
            this.lblTotalSBR.AutoSize = true;
            this.lblTotalSBR.Location = new System.Drawing.Point(244, 54);
            this.lblTotalSBR.Name = "lblTotalSBR";
            this.lblTotalSBR.Size = new System.Drawing.Size(10, 13);
            this.lblTotalSBR.TabIndex = 18;
            this.lblTotalSBR.Text = "-";
            // 
            // testtxt
            // 
            this.testtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testtxt.Location = new System.Drawing.Point(100, 20);
            this.testtxt.Name = "testtxt";
            this.testtxt.Size = new System.Drawing.Size(147, 20);
            this.testtxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProbablityNSBR);
            this.groupBox1.Controls.Add(this.lblProbablitySBR);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblReso);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.txtResolution);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtComponent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Attributes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblProbablityNSBR
            // 
            this.lblProbablityNSBR.AutoSize = true;
            this.lblProbablityNSBR.Location = new System.Drawing.Point(685, 141);
            this.lblProbablityNSBR.Name = "lblProbablityNSBR";
            this.lblProbablityNSBR.Size = new System.Drawing.Size(10, 13);
            this.lblProbablityNSBR.TabIndex = 21;
            this.lblProbablityNSBR.Text = "-";
            // 
            // lblProbablitySBR
            // 
            this.lblProbablitySBR.AutoSize = true;
            this.lblProbablitySBR.Location = new System.Drawing.Point(685, 76);
            this.lblProbablitySBR.Name = "lblProbablitySBR";
            this.lblProbablitySBR.Size = new System.Drawing.Size(10, 13);
            this.lblProbablitySBR.TabIndex = 20;
            this.lblProbablitySBR.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(404, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "-";
            // 
            // lblReso
            // 
            this.lblReso.AutoSize = true;
            this.lblReso.Location = new System.Drawing.Point(404, 120);
            this.lblReso.Name = "lblReso";
            this.lblReso.Size = new System.Drawing.Size(10, 13);
            this.lblReso.TabIndex = 12;
            this.lblReso.Text = "-";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(404, 97);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(10, 13);
            this.lblComp.TabIndex = 11;
            this.lblComp.Text = "-";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(404, 65);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(10, 13);
            this.lblProduct.TabIndex = 10;
            this.lblProduct.Text = "-";
            // 
            // txtResolution
            // 
            this.txtResolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResolution.Location = new System.Drawing.Point(90, 115);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(230, 20);
            this.txtResolution.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resolution";
            // 
            // txtComponent
            // 
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Location = new System.Drawing.Point(91, 88);
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(230, 20);
            this.txtComponent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Component";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(90, 141);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(230, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Location = new System.Drawing.Point(90, 57);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(230, 20);
            this.txtProduct.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader20,
            this.columnHeader8});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(39, 179);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1108, 253);
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Product";
            this.columnHeader13.Width = 152;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Component";
            this.columnHeader14.Width = 111;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Status";
            this.columnHeader16.Width = 76;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Resolution";
            this.columnHeader17.Width = 90;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Summary";
            this.columnHeader18.Width = 356;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Category";
            this.columnHeader20.Width = 144;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TextMining.Properties.Resources._1507;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 94);
            this.panel1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(66, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(806, 206);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Component";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Resolution";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Summary";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Category";
            this.columnHeader7.Width = 208;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-282, -324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 81);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TextMining.Properties.Resources._1507;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 80);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(252, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(603, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load New Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "New Category";
            this.columnHeader8.Width = 248;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1360, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Naive Bayse";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalCountInResult;
        private System.Windows.Forms.Label lblTotalNSBR;
        private System.Windows.Forms.TextBox txtNSBR;
        private System.Windows.Forms.Label lblTotalSBR;
        private System.Windows.Forms.TextBox testtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProbablityNSBR;
        private System.Windows.Forms.Label lblProbablitySBR;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblReso;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}