namespace NLP
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nLPToolStripMenuItem,
            this.oldCategoryToolStripMenuItem,
            this.newCategoryToolStripMenuItem,
            this.stopListToolStripMenuItem,
            this.startListToolStripMenuItem,
            this.comparisonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nLPToolStripMenuItem
            // 
            this.nLPToolStripMenuItem.Name = "nLPToolStripMenuItem";
            this.nLPToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.nLPToolStripMenuItem.Text = "PreProcessing";
            this.nLPToolStripMenuItem.Click += new System.EventHandler(this.nLPToolStripMenuItem_Click);
            // 
            // oldCategoryToolStripMenuItem
            // 
            this.oldCategoryToolStripMenuItem.Name = "oldCategoryToolStripMenuItem";
            this.oldCategoryToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.oldCategoryToolStripMenuItem.Text = "Old Category";
            this.oldCategoryToolStripMenuItem.Click += new System.EventHandler(this.oldCategoryToolStripMenuItem_Click);
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            this.newCategoryToolStripMenuItem.Click += new System.EventHandler(this.newCategoryToolStripMenuItem_Click);
            // 
            // stopListToolStripMenuItem
            // 
            this.stopListToolStripMenuItem.Name = "stopListToolStripMenuItem";
            this.stopListToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.stopListToolStripMenuItem.Text = "Stop List";
            this.stopListToolStripMenuItem.Click += new System.EventHandler(this.stopListToolStripMenuItem_Click);
            // 
            // startListToolStripMenuItem
            // 
            this.startListToolStripMenuItem.Name = "startListToolStripMenuItem";
            this.startListToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.startListToolStripMenuItem.Text = "Start List";
            this.startListToolStripMenuItem.Click += new System.EventHandler(this.startListToolStripMenuItem_Click);
            // 
            // comparisonToolStripMenuItem
            // 
            this.comparisonToolStripMenuItem.Name = "comparisonToolStripMenuItem";
            this.comparisonToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.comparisonToolStripMenuItem.Text = "Comparison";
            this.comparisonToolStripMenuItem.Click += new System.EventHandler(this.comparisonToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 520);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Bug Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparisonToolStripMenuItem;
    }
}