namespace WordCloud
{
    partial class ColorPicker
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
            this.startColor = new System.Windows.Forms.Label();
            this.endColor = new System.Windows.Forms.Label();
            this.btnStartColor = new System.Windows.Forms.Button();
            this.btnEndColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startColor
            // 
            this.startColor.BackColor = System.Drawing.Color.Lime;
            this.startColor.Location = new System.Drawing.Point(107, 48);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(72, 23);
            this.startColor.TabIndex = 6;
            this.startColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // endColor
            // 
            this.endColor.BackColor = System.Drawing.Color.Lime;
            this.endColor.Location = new System.Drawing.Point(107, 82);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(72, 23);
            this.endColor.TabIndex = 7;
            this.endColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartColor
            // 
            this.btnStartColor.Location = new System.Drawing.Point(15, 48);
            this.btnStartColor.Name = "btnStartColor";
            this.btnStartColor.Size = new System.Drawing.Size(75, 23);
            this.btnStartColor.TabIndex = 8;
            this.btnStartColor.Text = "Start Color";
            this.btnStartColor.UseVisualStyleBackColor = true;
            this.btnStartColor.Click += new System.EventHandler(this.btnStartColor_Click);
            // 
            // btnEndColor
            // 
            this.btnEndColor.Location = new System.Drawing.Point(15, 82);
            this.btnEndColor.Name = "btnEndColor";
            this.btnEndColor.Size = new System.Drawing.Size(75, 23);
            this.btnEndColor.TabIndex = 9;
            this.btnEndColor.Text = "End Color";
            this.btnEndColor.UseVisualStyleBackColor = true;
            this.btnEndColor.Click += new System.EventHandler(this.btnEndColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Starting and ending colors for nodes";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(12, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(106, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 154);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEndColor);
            this.Controls.Add(this.btnStartColor);
            this.Controls.Add(this.endColor);
            this.Controls.Add(this.startColor);
            this.Name = "ColorPicker";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Node Colors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label startColor;
        internal System.Windows.Forms.Label endColor;
        private System.Windows.Forms.Button btnStartColor;
        private System.Windows.Forms.Button btnEndColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}