using System;
using System.Collections.Generic;
using System.Text;



namespace WordCloud
{
    class NodeInfo
    {
        public NodeInfo(string name, int count)
		{
			Name = name;
			Count = count;
		}

		public string Name;
        public float Count;
    }
}
