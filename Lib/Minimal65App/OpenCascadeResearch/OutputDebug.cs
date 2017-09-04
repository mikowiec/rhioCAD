using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenCascadeResearch
{
    public partial class OutputDebug : Form
    {
        public OutputDebug()
        {
            InitializeComponent();
        }

        public void ClearTreeList()
        {
            ObjectsTreeList.Nodes.Clear();
        }

        public void LoadTree(TreeNode nodes)
        {
            ObjectsTreeList.Nodes.Add(nodes);
            ObjectsTreeList.ExpandAll();
            ObjectsTreeList.Select();
        }
    }
}
