using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Research.CommunityTechnologies.Treemap;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Drawing2D;



namespace WordCloud
{
    class TreemapPanel : Panel
    {
        /// Treemap drawing engine.
        protected TreemapGenerator m_TreemapGenerator;

        /// Graphics object for drawing the panel.  Valid only within the OnPaint() call.
        protected Graphics m_Graphics;

        ///hack for callback
        protected Form m_ParentForm;

        //word with largest count in tree
        public float m_nLargestCount = 0;
        public float m_nSmallestCount = 0;

        //minimum count to display. Set to 1 by default to show all
        protected int m_nDisplayCount = 5;

        //collection of nodes
        protected ArrayList m_nodes;

        //node (gradient) colors
        public Color m_startColor = Color.FromArgb(0, 255, 0);
        public Color m_endColor = Color.FromArgb(0, 255, 0);

        //font attributes
        public string m_FontName = "Microsoft Sans Serif";
        public float m_FontSize = 9;
        public FontStyle m_FontStyle = System.Drawing.FontStyle.Bold;
        public Color m_FontColor = Color.Black;

        //toggle showing word count in nodes
        public bool m_bShowWordCount = true;

        //toggle showing word count in nodes
        public bool m_bUseTextScaling = true;


        //*************************************************************************
        //  Methods
        //*************************************************************************
        
        public TreemapPanel(Form parent)
        {
            //set parent for callback
            m_ParentForm = parent;

            // Create the treemap drawing engine.
            m_TreemapGenerator = new TreemapGenerator();

            // We want to do owner drawing, so handle the DrawItem event.
            m_TreemapGenerator.DrawItem +=
                new TreemapGenerator.TreemapDrawItemEventHandler(DrawItem);

            m_Graphics = null;
            m_nodes = new ArrayList();

            // Setup the treemap
            InitTree();

            // Avoid flicker while drawing.  According to "Windows Forms
            // Programming in C#," the following three styles are all required.
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            // Force the panel to be redrawn when it's resized.
            this.ResizeRedraw = true;
        }

        //*************************************************************************
        //  Method: SetMinimumWordCount()
        //
        /// <summary>
        /// Set the minimum count for what to show 
        /// </summary>
        //*************************************************************************

        public void SetMinimumWordCount(int count)
        {
            m_nDisplayCount = count;
            RepopulateTreeMap();
        }

        //*************************************************************************
        //  Method: SetFont()
        //
        /// <summary>
        /// Set font attributes
        /// </summary>
        //*************************************************************************
        
        public void SetFont(string fName, float fSize, System.Drawing.FontStyle fStyle, Color fColor)
        {
            m_FontName = fName;
            m_FontSize = fSize;
            m_FontStyle = fStyle;
            m_FontColor = fColor;
        }
        
        //*************************************************************************
        //  Method: InitTree()
        //
        /// <summary>
        /// Add initial node to tree when app starts 
        /// </summary>
        //*************************************************************************
        public void InitTree()
        {
            //add one root node at startup
            ArrayList nodes = new ArrayList();
            NodeInfo nodeinfo = new NodeInfo("", 5);
            nodes.Add(nodeinfo);
            m_nodes = nodes;
            
            RepopulateTreeMap();
        }

        //*************************************************************************
        //  Method: PopulateTreeMap()
        //
        /// <summary>
        /// Populates map from hash data
        /// </summary>
        //*************************************************************************
        public void PopulateTreeMap(Hashtable wordsHash, Hashtable stemmedWordsHash)
        {
            AssertValid();

            ArrayList nodes = new ArrayList();
            ArrayList aKeys = new ArrayList(stemmedWordsHash.Keys);
            aKeys.Sort();

            foreach (string key in aKeys)
            {
                //build each node element
                int count = (int)stemmedWordsHash[key];
                string name = (string)wordsHash[key];
                
                //show count in node?
                if(m_bShowWordCount)
                    name += String.Format(" ({0})", count);
                
                NodeInfo nodeinfo = new NodeInfo(name, count);
                nodes.Add(nodeinfo);
            }

            m_nodes = nodes;
            RepopulateTreeMap();
        }

        //*************************************************************************
        //  Method: RepopulateTreeMap()
        //
        /// <summary>
        /// Repopulates the map
        /// </summary>
        //*************************************************************************
        private void RepopulateTreeMap()
        {
            if(m_nodes.Count == 0)
                return;

            Nodes TreemapGeneratorNodes;
            
            //reset treemap
            m_TreemapGenerator.Clear();
            
            TreemapGeneratorNodes = m_TreemapGenerator.Nodes;

            foreach(NodeInfo n in m_nodes)
            {
                //does this node have enough to display?
                if(n.Count >= m_nDisplayCount)
                {
                    //Create node with basic default size and color
                    Node oWordNode = new Node(n.Name, n.Count * 50.0f, 0F);

                    //set object data
                    oWordNode.Tag = n;
                    
                    //add category to tree
                    TreemapGeneratorNodes.Add(oWordNode);

                    //used later for determining node color
                    if (n.Count > m_nLargestCount)
                        m_nLargestCount = n.Count;
                    else if (n.Count < m_nSmallestCount)
                        m_nSmallestCount = n.Count;
                }
            }
        }

        //*************************************************************************
        //  Method: RepopulateTreeMapAsCategories() - NOT USED, just here as an example 
        //
        /// <summary>
        /// Repopulates the map into categories
        /// </summary>
        //*************************************************************************
        private void RepopulateTreeMapAsCategories()
        {
            if (m_nodes.Count == 0)
                return;

            Nodes TreemapGeneratorNodes;

            //reset treemap
            m_TreemapGenerator.Clear();

            TreemapGeneratorNodes = m_TreemapGenerator.Nodes;

            // Create count category nodes [1-5, 6-10, 11-15, 16+]
            Node RootNode = new Node("Word Cloud", 50F, 0F);
            Node CategoryNode1to5 = new Node("1-5", 50F, 0F);
            Node CategoryNode6to10 = new Node("6-10", 50F, 0F);
            Node CategoryNode11to15 = new Node("11-15", 50F, 0F);
            Node CategoryNode16plus = new Node("16+", 50F, 0F);

            foreach (NodeInfo n in m_nodes)
            {
                if (n.Count >= m_nDisplayCount)
                {
                    //Create node
                    Node oWordNode = new Node(n.Name, n.Count * 50.0f, 0F);

                    //set object data
                    oWordNode.Tag = n;

                    //add node to appropriate count category
                    if (n.Count <= 5)
                    {
                        Debug.WriteLine("Adding item to 1-5 node");
                        CategoryNode1to5.Nodes.Add(oWordNode);
                    }
                    else if (n.Count > 5 && n.Count <= 10)
                    {
                        Debug.WriteLine("Adding item to 6-10 node");
                        CategoryNode6to10.Nodes.Add(oWordNode);
                    }
                    else if (n.Count > 10 && n.Count <= 15)
                    {
                        Debug.WriteLine("Adding item to 11-15 node");
                        CategoryNode11to15.Nodes.Add(oWordNode);
                    }
                    else if (n.Count > 15)
                    {
                        Debug.WriteLine("Adding item to over 15 node");
                        CategoryNode16plus.Nodes.Add(oWordNode);
                    }

                    //used for coloring later
                    if (n.Count > m_nLargestCount)
                        m_nLargestCount = n.Count;
                }
            }

            //add category nodes to root category, the add root to treemap

            RootNode.Nodes.Add(CategoryNode1to5);
            RootNode.Nodes.Add(CategoryNode6to10);
            RootNode.Nodes.Add(CategoryNode11to15);
            RootNode.Nodes.Add(CategoryNode16plus);
            TreemapGeneratorNodes.Add(RootNode);

        }

        
        //*************************************************************************
        //    Method: OnPaint()
        //
        /// <summary>
        ///    Handles the Paint event on the Panel.
        /// </summary>
        ///
        /// <param name="e">
        /// Standard event argument.
        /// </param>
        //*************************************************************************

        protected override void OnPaint(PaintEventArgs e)
        {
            AssertValid();

            // Save the Graphics object so it can be accessed by OnDrawItem().
            m_Graphics = e.Graphics;

            // Tell the TreemapGenerator to draw the treemap using owner-
            // implemented code.  This causes the DrawItem event to get fired for
            // each node in the treemap.
            m_TreemapGenerator.Draw(this.ClientRectangle);

            // All DrawItem events have been fired.  Make sure the Graphics object
            // doesn't get used again.
            m_Graphics = null;
        }

        //*************************************************************************
        //    Method: DrawItem()
        //
        /// <summary>
        ///    Handles the DrawItem event on the TreemapGenerator.
        /// </summary>
        ///
        /// <param name="sender">
        /// Standard event argument.
        /// </param>
        ///
        /// <param name="e">
        /// Standard event argument.
        /// </param>
        //*************************************************************************

        protected void DrawItem(Object sender, TreemapDrawItemEventArgs e)
        {
            AssertValid();

            Node oNode = e.Node;
            float fontSize = m_FontSize;
            float count = 0;

            // Retrieve the NodeInfo object from the node's tag.
            if (oNode.Tag is NodeInfo)
            {
                //get word count
                NodeInfo oInfo = (NodeInfo)oNode.Tag;
                count = oInfo.Count;
                
                //if we're using text scaling, increment font size
                if(m_bUseTextScaling)
                    fontSize += oInfo.Count;
            }
            else
            {
                //should never get here
                Debug.WriteLine("DrawItem: Skipping node - bad");
                return;
            }

            //set color alpha based on frequency
            Color newStartColor = GetColor(count, m_startColor);
            Color newEndColor = GetColor(count, m_endColor);

            //set gradient colors and gamma
            LinearGradientBrush nodeBrush = new LinearGradientBrush(e.Bounds,
                newStartColor, newEndColor, LinearGradientMode.Vertical);

            nodeBrush.GammaCorrection = true;

            m_Graphics.FillRectangle(nodeBrush, e.Bounds);

            // Create font and align in the center
            Font newfont = new Font(m_FontName, fontSize, m_FontStyle);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //draw the text
            m_Graphics.DrawString(e.Node.Text, newfont, new SolidBrush(m_FontColor), e.Bounds, sf);

            // Draw a black border around each node
            Pen blackPen = new Pen(Color.Black, 2);
            m_Graphics.DrawRectangle(blackPen, e.Bounds);

            //clean up
            nodeBrush.Dispose();
            newfont.Dispose();
            blackPen.Dispose();
        }

        //*************************************************************************
        //    Method: GetColor()
        //
        /// <summary>
        ///    Returns the color to be drawn for a given node based on its frequency.
        /// </summary>
        ///
        //*************************************************************************

        protected Color GetColor(float count, Color clr)
        {
            //crude algorithm for determining color based on relative word count 
            float alphaPercentValue = (float)count / m_nLargestCount;
            float dnewAlpha = (float)alphaPercentValue * 255f;
            int newAlpha = (int)dnewAlpha;

            return Color.FromArgb(newAlpha, clr.R, clr.G, clr.B);
        }

        //*************************************************************************
        //  Method: AssertValid()
        //
        /// <summary>
        /// Asserts if the object is in an invalid state.  Debug-only.
        /// </summary>
        //*************************************************************************

        [Conditional("DEBUG")]

        public void AssertValid()
        {
            Debug.Assert(m_TreemapGenerator != null);
        }

    }
}
