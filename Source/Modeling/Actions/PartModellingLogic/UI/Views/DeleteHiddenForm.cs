#region Usings

using System;
using System.Windows.Forms;
using Naro.Infrastructure.Interface;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views
{
    public partial class DeleteHiddenForm : Form
    {
        private readonly Document _document;

        public DeleteHiddenForm(Document document)
        {
            _document = document;
            InitializeComponent();
            SetupDialog();
            RefreshList();
        }

        private void SetupDialog()
        {
            _searchControl.TokensChanged += RefreshList;
            glassButton2.Visible = false;
        }

        private void RefreshList()
        {
            var tokens = _searchControl.UpperKeyTokens;
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var child in _document.Root.Children)
            {
                var data = new ItemData(child.Value);
                if (FilteringUtils.PassFiltering(data.Builder.ShapeName.ToUpper(), tokens))
                    listBox1.Items.Add(data);
            }
            listBox1.EndUpdate();
        }

        private void GlassButton1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBox1DoubleClick(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index == -1)
                return;
            var data = (ItemData) listBox1.SelectedItem;
            NodeBuilderUtils.DeleteNode(data.Builder.Node, _document);
            RefreshList();
        }

        private void GlassButton2Click(object sender, EventArgs e)
        {
            var items = listBox1.SelectedItems;
            foreach (ItemData item in items)
                NodeBuilderUtils.DeleteNode(item.Builder.Node, _document);

            RefreshList();
            glassButton2.Visible = false;
        }

        private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            glassButton2.Visible = listBox1.SelectedItems.Count != 0;
        }

        #region Nested type: ItemData

        private class ItemData
        {
            public ItemData(Node node)
            {
                Builder = new NodeBuilder(node);
            }

            public NodeBuilder Builder { get; private set; }

            public override string ToString()
            {
                return Builder.ShapeName;
            }
        }

        #endregion
    }
}