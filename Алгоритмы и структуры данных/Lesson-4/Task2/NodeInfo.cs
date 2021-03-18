using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class NodeInfo
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }

        public string Text { get; set; }
        public int StartPos { get; set; }
        public int Size { get { return Text.Length; } }
        public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
        public NodeInfo Parent { get; set; }
        public NodeInfo Left { get; set; }
        public NodeInfo Right { get; set; }
    }
}
