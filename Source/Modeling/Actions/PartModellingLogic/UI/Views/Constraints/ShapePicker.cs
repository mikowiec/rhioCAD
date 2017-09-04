#region Usings

using System.Windows.Forms;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Constraints
{
    public partial class ShapePicker : UserControl
    {
        public ShapePicker()
        {
            InitializeComponent();
        }

        public NodeBuilder Builder { get; set; }

        public void SetNode(Node node)
        {
            if (node == null)
            {
                Builder = new NodeBuilder(null);
                textBox.Text = string.Empty;
                return;
            }
            Builder = new NodeBuilder(node);
            textBox.Text = Builder.ShapeName;
        }
    }
}