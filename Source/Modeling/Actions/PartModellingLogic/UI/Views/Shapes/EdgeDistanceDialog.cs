#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Shapes
{
    public partial class EdgeDistanceDialog : Form
    {
        private readonly List<int> _dependencyIndexes = new List<int>();
        private NodeBuilder _shapeNode;

        public EdgeDistanceDialog(Node shapeNode)
        {
            InitializeComponent();

            if (!PopulateIndexes(shapeNode))
            {
                throw new Exception("Selected_Node_Should_Have_Axis_Or_Point");
            }
        }

        public double Distance { get; private set; }
        public int AppliedPoint { get; private set; }

        private bool PopulateIndexes(Node shapeNode)
        {
            _shapeNode = new NodeBuilder(shapeNode);
            var pos = 0;
            var children =
                _shapeNode.Node.Get<FunctionInterpreter>().Dependency.Children;
            foreach (var dependency in children)
            {
                if (dependency.Name == InterpreterNames.Point3D
                    || dependency.Name == InterpreterNames.Axis3D)
                    _dependencyIndexes.Add(pos);
                pos++;
            }
            if (_dependencyIndexes.Count == 0)
            {
                return false;
            }
            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            foreach (var index in _dependencyIndexes)
            {
                comboBox1.Items.Add(index);
            }
            comboBox1.SelectedIndex = 0;
            if (_dependencyIndexes.Count == 1)
            {
                comboBox1.Enabled = false;
            }
            comboBox1.EndUpdate();
            return true;
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            Distance = Convert.ToDouble(distanceTextBox.Text);
            AppliedPoint = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}