using System;
using System.Runtime.InteropServices; //dllimport
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;



namespace WordCloud
{
    public partial class WcForm : Form
    {
        //color picker for changing node colors
        ColorPicker m_ColorPickerDlg = new ColorPicker();
        
        //stop words dialog
        StopWords m_StopWordsDlg = new StopWords();

        //stop words collection
        ArrayList m_arrStopWords = null;

        public WcForm()
        {
            //pre-populate with default stop words list
            m_arrStopWords = m_StopWordsDlg.getStopWords();

            //form setup
            InitializeComponent();
            
            //setup treemap
            InitTreemap();
        }

        //*************************************************************************
        //    Method: toolStripBtnOpenFile_Click()
        //
        /// <summary>
        ///    Open a text file for processing.
        /// </summary>
        //
        //*************************************************************************
        
        private void toolStripBtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open File Dialog";
            fdlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                // create reader & open file
                StreamReader sr = new StreamReader(fdlg.FileName);

                // read in text
                string input = null;
                StringBuilder sbRawText = new StringBuilder();
                while ((input = sr.ReadLine()) != null)
                {
                    sbRawText.Append(input);
                }

                // close the stream
                sr.Close();
                sr = null;
                input = null;

                ProcessTextInput(sbRawText);
            }
        }

        //*************************************************************************
        //    Method: toolStripBtnInputText_Click()
        //
        /// <summary>
        ///    Input text for processing.
        /// </summary>
        //
        //*************************************************************************

        private void toolStripBtnInputText_Click(object sender, EventArgs e)
        {
            InputDialog dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string input = dlg.mText;
                StringBuilder sbRawText = new StringBuilder(input);
                ProcessTextInput(sbRawText);
            }
        }

        //*************************************************************************
        //    Method: toolStripButtonStopWords_Click()
        //
        /// <summary>
        ///    Modify stop words.
        /// </summary>
        //
        //************************************************************************* 

        private void toolStripButtonStopWords_Click(object sender, EventArgs e)
        {
            if (m_StopWordsDlg.ShowDialog() == DialogResult.OK)
            {
                //get list regardless
                m_arrStopWords.Clear();
                m_arrStopWords = m_StopWordsDlg.getStopWords();
            }
        }

        //*************************************************************************
        //    Method: toolStripButtonFont_Click()
        //
        /// <summary>
        ///    Change display font
        /// </summary>
        //
        //************************************************************************* 
        
        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            
            //set current font displayed
            fd.ShowColor = true;
            fd.Color = this.TreePanel.m_FontColor;
            fd.Font = new Font(this.TreePanel.m_FontName,
                                this.TreePanel.m_FontSize,
                                this.TreePanel.m_FontStyle);
            
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                //set new font
                this.TreePanel.SetFont(fd.Font.Name, fd.Font.Size, fd.Font.Style, fd.Color);

                //force a repaint with new font
                this.TreePanel.Invalidate();
                this.TreePanel.Update();
            }
        }

        //*************************************************************************
        //    Method: toolStripBtnNodeColor_Click()
        //
        /// <summary>
        ///    Change node colors.
        /// </summary>
        //
        //************************************************************************* 
        
        private void toolStripBtnNodeColor_Click(object sender, EventArgs e)
        {
            if (m_ColorPickerDlg.ShowDialog() == DialogResult.OK)
            {
                Color ec = m_ColorPickerDlg.nodeEndColor;

                this.TreePanel.m_startColor = m_ColorPickerDlg.nodeStartColor;
                this.TreePanel.m_endColor = m_ColorPickerDlg.nodeEndColor;

                //force a repaint with new colors
                this.TreePanel.Invalidate();
                this.TreePanel.Update();
            }
        }

        //*************************************************************************
        //    Method: toolStripButtonShowCount_Click()
        //
        /// <summary>
        ///    Toggle node count on/off
        /// </summary>
        //
        //************************************************************************* 
        
        private void toolStripButtonShowCount_Click(object sender, EventArgs e)
        {
            this.TreePanel.m_bShowWordCount = this.toolStripButtonShowCount.Checked;
        }

        //*************************************************************************
        //    Method: toolStripButtonScaleText_Click()
        //
        /// <summary>
        ///    Toggle text scaling on/off
        /// </summary>
        //
        //************************************************************************* 

        private void toolStripButtonScaleText_Click(object sender, EventArgs e)
        {
            this.TreePanel.m_bUseTextScaling = this.toolStripButtonScaleText.Checked;
            this.TreePanel.Invalidate();
            this.TreePanel.Update();
        }

        //*************************************************************************
        //    Method: toolStripBtnSaveImage_Click()
        //
        /// <summary>
        ///    Save treemap as an image.
        /// </summary>
        //
        //************************************************************************* 

        private void toolStripBtnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify Destination Filename";
            sfd.Filter = "Gif Files|*.gif";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                //force repaint so we get rid of save dialog before taking a screenshot
                this.Invalidate();
                this.Update();
                this.TreePanel.Invalidate();
                this.TreePanel.Update();

                //save the image
                Bitmap treeImage;
                Graphics myGraphics = this.CreateGraphics();
                Size s = this.Size;
                treeImage = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(treeImage);
                memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
                treeImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                treeImage.Dispose();
                memoryGraphics.Dispose();
            }
        }

        //*************************************************************************
        //    Method: tbWordCount_ValueChanged()
        //
        /// <summary>
        ///    update treemap and cotrols when word count slider is moved.
        /// </summary>
        //
        //************************************************************************* 
 
        private void tbWordCount_ValueChanged(object sender, EventArgs e)
        {
            this.wordCountlabel.Text = string.Format("Minimum word count to display {0}:", this.tbWordCount.Value);

            this.MinWordCount = this.tbWordCount.Value;
            this.TreePanel.SetMinimumWordCount(MinWordCount);
            this.TreePanel.Invalidate();
            this.TreePanel.Update();
        }

        //*************************************************************************
        //    Method: ProcessTextInput()
        //
        /// <summary>
        ///    read in text into collections along with the stop words, then pass to 
        ///    thread for processing.
        /// </summary>
        //
        //************************************************************************* 

        private void ProcessTextInput(StringBuilder sbRawText)
        {
            //now create worker to handle stemming and counting with threads
            ProgressWindow progress = new ProgressWindow();
            progress.Text = "Reading in text";

            //wrap up objects to pass
            object obj = new object[] { progress, sbRawText, m_arrStopWords };

            //fire up the thread
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(DoWordProcessing), obj);
            progress.ShowDialog();

            //update slider max
            this.tbWordCount.Maximum = (int)this.TreePanel.m_nLargestCount;

            //force everything to repaint
            this.Invalidate();
            this.TreePanel.Invalidate();
            this.Update();
        }

        //*************************************************************************
        //  Method: DoWordProcessing()
        //
        /// <summary>
        /// Worker thread method that processes words
        /// </summary>
        //*************************************************************************
        private void DoWordProcessing(object obj)
        {
            //unpack array
            object[] objArray = (object[])obj;
            IProgressCallback callback = (IProgressCallback)objArray[0];
            StringBuilder sbRawText = (StringBuilder)objArray[1];
            ArrayList arrStopWords = (ArrayList)objArray[2];

            try
            {
                //Build a hash of words and thier frequency
                Hashtable wordsHash = new Hashtable();
                Hashtable stemmedWordsHash = new Hashtable();
                PorterStemmer ps = new PorterStemmer();
                
                //construct our document from the input text
                Document doc = new Document(sbRawText.ToString());

                callback.Begin(0, doc.Words.Count);

                for (int i = 0; i < doc.Words.Count; ++i)
                {
                    //cancel button clicked?
                    if (callback.IsAborting)
                    {
                        callback.End();
                        return;
                    }

                    //update progress dialog
                    callback.SetText(String.Format("Reading word: {0}", i));
                    callback.StepTo(i);
                    
                    //Don't do numbers
                    if (!IsNumeric(doc.Words[i]))
                    {
                        // normalize each word to lowercase
                        string key = doc.Words[i].ToLower();
                    
                        //check stop words list
                        if (!arrStopWords.Contains(key))
                        {
                            //set our stemming term
                            ps.stemTerm(key);

                            //get the stem word
                            string stemmedKey = ps.getTerm();

                            //either add to hash or increment frequency
                            if (!stemmedWordsHash.Contains(stemmedKey))
                            {
                                //add new word
                                stemmedWordsHash.Add(stemmedKey, 1);
                                wordsHash.Add(stemmedKey, key);
                            }
                            else
                            {
                                //increment word count
                                stemmedWordsHash[stemmedKey] = (int)stemmedWordsHash[stemmedKey] + 1;
                            }
                        }
                    }
                }

                //now let the treemap load the information
                this.TreePanel.PopulateTreeMap(wordsHash, stemmedWordsHash);

            }
            catch (System.Threading.ThreadAbortException)
            {
                // noop
            }
            catch (System.Threading.ThreadInterruptedException)
            {
                // noop
            }
            finally
            {
                if (callback != null)
                {
                    callback.End();
                }
            }
        }

        //util function for checking to see if we're dealing with a number
        public static System.Boolean IsNumeric (System.Object Expression)
        {
            if(Expression == null || Expression is DateTime)
                return false;

            if(Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;
          
            try
            {
                if(Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                    return true;
            }
            catch {} // just dismiss errors but return false
                
            return false;
        }
    }
}