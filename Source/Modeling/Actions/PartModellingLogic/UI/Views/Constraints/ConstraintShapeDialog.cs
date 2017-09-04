#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BooEvaluator.Boo;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using Resources.Infrastructure;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Constraints
{
    public sealed partial class ConstraintShapeDialog : Form
    {
        #region Delegates

        public delegate void OnRefreshView();

        #endregion

        private readonly SortedDictionary<string, int> _acceptZero = new SortedDictionary<string, int>();

        private readonly Document _document;

        private readonly SortedDictionary<string, SortedDictionary<string, string>> _shapeConstraints =
            new SortedDictionary<string, SortedDictionary<string, string>>();

        public OnRefreshView RefreshViewView;
        private NodeBuilder _builder;

        public ConstraintShapeDialog(Document document)
        {
            _document = document;
            InitializeComponent();

            RegisterFunctionConstraints();
        }

        private void RegisterFunctionConstraints()
        {
            AddShapeConstraint(FunctionNames.Rectangle, FunctionNames.RectangleWidthConstraint, "Width");
            AddShapeConstraint(FunctionNames.Rectangle, FunctionNames.RectangleHeightConstraint, "Height");

            AddShapeConstraint(FunctionNames.LineTwoPoints, "Dimension", "Length");
            AddShapeConstraint(FunctionNames.LineTwoPoints, Constraint2DNames.ParallelFunction, "Parallel lines");

            AddShapeConstraint(FunctionNames.Ellipse, FunctionNames.EllipseMinorRadiusConstraint, "Minor Radius");
            AddShapeConstraint(FunctionNames.Ellipse, FunctionNames.EllipseMajorRadiusConstraint, "Major Radius");

            AddShapeConstraint(FunctionNames.Circle, FunctionNames.CircleRangeConstraint, "Radius");

            AddShapeConstraint(FunctionNames.Box, FunctionNames.BoxHeightConstraint, "Height");

            AddShapeConstraint(FunctionNames.Cone, FunctionNames.ConeMinorRadiusConstraint, "Minor Radius");
            _acceptZero[FunctionNames.ConeMinorRadiusConstraint] = 0;
            AddShapeConstraint(FunctionNames.Cone, FunctionNames.ConeHeightConstraint, "Height");
            AddShapeConstraint(FunctionNames.Cone, FunctionNames.ConeMajorRadiusConstraint, "Major Radius");

            AddShapeConstraint(FunctionNames.Cylinder, FunctionNames.CylinderRadiusConstraint, "Radius");
            AddShapeConstraint(FunctionNames.Cylinder, FunctionNames.CylinderHeightConstraint, "Height");

            AddShapeConstraint(FunctionNames.Sphere, FunctionNames.SphereRadiusConstraint, "Radius");

            AddShapeConstraint(FunctionNames.Torus, FunctionNames.TorusMajorRangeConstraint, "Major Radius");
            AddShapeConstraint(FunctionNames.Torus, FunctionNames.TorusMinorRangeConstraint, "Minor Radius");
        }

        private void AddShapeConstraint(string functionName, string constraintName, string description)
        {
            if (!_shapeConstraints.ContainsKey(functionName))
            {
                var supportedConstraint = new SortedDictionary<string, string> {{constraintName, description}};
                _shapeConstraints[functionName] = supportedConstraint;
            }
            else
            {
                if (_shapeConstraints[functionName].ContainsKey(constraintName))
                    throw new InvalidDataException("Constraint already exists");
                _shapeConstraints[functionName].Add(constraintName, description);
            }
        }

        private void ConstraintShapeDialogShown(object sender, EventArgs e)
        {
            Reset();
        }

        public void SetNode(Node node)
        {
            shapeNameControl.SetNode(node);
            _builder = shapeNameControl.Builder;
            RefreshList();
        }

        private void RefreshList()
        {
            var previousIndex = listConstraints.SelectedIndex;
            if (previousIndex == -1) previousIndex = 0;
            CallRefresh();
            listConstraints.BeginUpdate();
            listConstraints.Items.Clear();
            
            //if (_builder.LastExecute == false)
            //{
            //    listConstraints.EndUpdate();
            //    return;
            //}
            var constraints = (from child in _document.Root.Children where NodeUtils.NodeIsConstraint(child.Key, _document) select child.Value).ToList();
            if (_builder.Node == null)
            {
                foreach (var constraint in constraints)
                {
                    var nb = new NodeBuilder(constraint);
                    var listItem = new ConstraintListItem(_document, nb, nb.FunctionName, nb.FunctionName+": "+NodeUtils.GetConstraintDependencies(constraint));
                    listConstraints.Items.Add(listItem);
                }
            }
            else
            {
                foreach(var constraint in constraints)
                {
                    if(Document.NodeReferences(constraint, _builder.Node) || NodeUtils.LineHasLengthConstraint(_builder.Node, constraint))
                    {
                        var nb = new NodeBuilder(constraint);
                        var listItem = new ConstraintListItem(_document, nb, nb.FunctionName, nb.FunctionName + ": " + NodeUtils.GetConstraintDependencies(constraint, _builder.ShapeName));
                        listConstraints.Items.Add(listItem);
                    }
                }
            }
            listConstraints.EndUpdate();
            if (listConstraints.Items.Count > 0)
            {
                listConstraints.SelectedIndex = previousIndex < listConstraints.Items.Count ? previousIndex : 0;
            }
        }

        private void CallRefresh()
        {
            if (RefreshViewView != null)
                RefreshViewView();
        }

        private void Reset()
        {
            shapeNameControl.Text = string.Empty;
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            ApplyNewConstraintValue();
        }

        private bool AcceptZero()
        {
            var constraintDesc = (ConstraintListItem) listConstraints.SelectedItem;
            var functionName = constraintDesc.Name;
            return _acceptZero.ContainsKey(functionName);
        }

        private void ApplyNewConstraintValue()
        {
            double value;
            try
            {
                value = BooEval.GetDouble(valueTextBox.Text);
            }
            catch (FormatException)
            {
                NaroMessage.Show(ExtensionsResources.Invalid_number_format);
                return;
            }
            if (!AcceptZero() && value < 0.001)
            {
                NaroMessage.Show(ExtensionsResources.ConstraintShapeDialog_Value_Bigger_Than_Zero);
                return;
            }
            var constraintDesc = (ConstraintListItem) listConstraints.SelectedItem;
            constraintDesc.GenerateBuilder();
            var builder = constraintDesc.Builder;
            builder[1].Real = value;
            builder.ExecuteFunction();
            RefreshList();
        }

        private void ConstraintShapeDialogDeactivate(object sender, EventArgs e)
        {
            Opacity = 0.75;
        }

        private void ConstraintShapeDialogActivated(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void ListConstraintsSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listConstraints.SelectedIndex;
            valuePanel.Visible = (selectedIndex != -1);
            removeButton.Visible = (selectedIndex != -1) && ((ConstraintListItem) listConstraints.SelectedItem).IsSet();
            if (selectedIndex == -1) return;

            var constraintDesc = (ConstraintListItem) listConstraints.SelectedItem;
            valueTextBox.Text = "-";//"constraintDesc.IsSet() ? constraintDesc.Builder[1].Real.ToString() : "0";
            valueTextBox.Focus();
        }

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            var constraintDesc = (ConstraintListItem) listConstraints.SelectedItem;
            NodeBuilderUtils.DeleteNode(constraintDesc.Builder.Node, _document);
            RefreshList();
        }

        private void ValueTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            ApplyNewConstraintValue();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}