using System;
namespace WordCloud
{
    partial class WcForm
    //public class WcForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TreemapPanel TreePanel;
        private int MinWordCount = 5;
        
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WcForm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnInputText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStopWords = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNodeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonScaleText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowCount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wordCountlabel = new System.Windows.Forms.ToolStripLabel();
            this.tbWordCount = new WordCloud.ToolStripTrackBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSaveImage = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnOpenFile,
            this.toolStripBtnInputText,
            this.toolStripSeparator2,
            this.toolStripButtonStopWords,
            this.toolStripSeparator4,
            this.toolStripButtonFont,
            this.toolStripBtnNodeColor,
            this.toolStripButtonScaleText,
            this.toolStripButtonShowCount,
            this.toolStripSeparator1,
            this.wordCountlabel,
            this.tbWordCount,
            this.toolStripSeparator3,
            this.toolStripBtnSaveImage});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(869, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // toolStripBtnOpenFile
            // 
            this.toolStripBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenFile.Image")));
            this.toolStripBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenFile.Name = "toolStripBtnOpenFile";
            this.toolStripBtnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnOpenFile.Text = "Open Text File";
            this.toolStripBtnOpenFile.Click += new System.EventHandler(this.toolStripBtnOpenFile_Click);
            // 
            // toolStripBtnInputText
            // 
            this.toolStripBtnInputText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnInputText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnInputText.Image")));
            this.toolStripBtnInputText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnInputText.Name = "toolStripBtnInputText";
            this.toolStripBtnInputText.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnInputText.Text = "Input Text";
            this.toolStripBtnInputText.Click += new System.EventHandler(this.toolStripBtnInputText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStopWords
            // 
            this.toolStripButtonStopWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStopWords.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStopWords.Image")));
            this.toolStripButtonStopWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStopWords.Name = "toolStripButtonStopWords";
            this.toolStripButtonStopWords.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStopWords.Text = "Stop Words";
            this.toolStripButtonStopWords.Click += new System.EventHandler(this.toolStripButtonStopWords_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFont
            // 
            this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFont.Image")));
            this.toolStripButtonFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFont.Name = "toolStripButtonFont";
            this.toolStripButtonFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFont.Text = "Font";
            this.toolStripButtonFont.Click += new System.EventHandler(this.toolStripButtonFont_Click);
            // 
            // toolStripBtnNodeColor
            // 
            this.toolStripBtnNodeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNodeColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNodeColor.Image")));
            this.toolStripBtnNodeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNodeColor.Name = "toolStripBtnNodeColor";
            this.toolStripBtnNodeColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnNodeColor.Text = "Node Color";
            this.toolStripBtnNodeColor.Click += new System.EventHandler(this.toolStripBtnNodeColor_Click);
            // 
            // toolStripButtonScaleText
            // 
            this.toolStripButtonScaleText.Checked = true;
            this.toolStripButtonScaleText.CheckOnClick = true;
            this.toolStripButtonScaleText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonScaleText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonScaleText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonScaleText.Image")));
            this.toolStripButtonScaleText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonScaleText.Name = "toolStripButtonScaleText";
            this.toolStripButtonScaleText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonScaleText.Text = "Scale Text";
            this.toolStripButtonScaleText.Click += new System.EventHandler(this.toolStripButtonScaleText_Click);
            // 
            // toolStripButtonShowCount
            // 
            this.toolStripButtonShowCount.Checked = true;
            this.toolStripButtonShowCount.CheckOnClick = true;
            this.toolStripButtonShowCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowCount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowCount.Image")));
            this.toolStripButtonShowCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowCount.Name = "toolStripButtonShowCount";
            this.toolStripButtonShowCount.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowCount.Text = "Show Count";
            this.toolStripButtonShowCount.Click += new System.EventHandler(this.toolStripButtonShowCount_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // wordCountlabel
            // 
            this.wordCountlabel.Name = "wordCountlabel";
            this.wordCountlabel.Size = new System.Drawing.Size(198, 22);
            this.wordCountlabel.Text = "Minimum word count to display (5):";
            // 
            // tbWordCount
            // 
            this.tbWordCount.BackColor = System.Drawing.SystemColors.Control;
            this.tbWordCount.Minimum = 1;
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.Size = new System.Drawing.Size(150, 22);
            this.tbWordCount.Text = "Word Count";
            this.tbWordCount.Value = 5;
            this.tbWordCount.ValueChanged += new System.EventHandler(this.tbWordCount_ValueChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnSaveImage
            // 
            this.toolStripBtnSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveImage.Image")));
            this.toolStripBtnSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveImage.Name = "toolStripBtnSaveImage";
            this.toolStripBtnSaveImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSaveImage.Text = "Save As Image";
            this.toolStripBtnSaveImage.Click += new System.EventHandler(this.toolStripBtnSaveImage_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 151);
            // 
            // WcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 641);
            this.Controls.Add(this.toolStripMain);
            this.Name = "WcForm";
            this.Text = "NLP";
            this.Resize += new System.EventHandler(this.OnResize);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitTreemap()
        {
            this.TreePanel = new TreemapPanel(this);
            this.TreePanel.SuspendLayout();

            //this.TreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreePanel.Location = new System.Drawing.Point(0, 25);
            this.TreePanel.Name = "TreeMapMainPanel";
            this.TreePanel.Size = new System.Drawing.Size(645, 614);
            this.TreePanel.Height = this.Height - 60;
            this.TreePanel.Width = this.Width - 8;
            this.TreePanel.TabIndex = 1;
                        
            this.Controls.Add(this.TreePanel);

            this.TreePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Invalidate();
        }

        public void OnResize(object sender, EventArgs ee)
        {
            //quick hack to resize
            this.TreePanel.Dock = System.Windows.Forms.DockStyle.None;
            this.TreePanel.Location = new System.Drawing.Point(0, 25);
            this.TreePanel.Height = this.Height-60;
            this.TreePanel.Width = this.Width-8;
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveImage;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private ToolStripTrackBar tbWordCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripBtnInputText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnNodeColor;
        private System.Windows.Forms.ToolStripLabel wordCountlabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonStopWords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowCount;
        private System.Windows.Forms.ToolStripButton toolStripButtonScaleText;
    }
}

