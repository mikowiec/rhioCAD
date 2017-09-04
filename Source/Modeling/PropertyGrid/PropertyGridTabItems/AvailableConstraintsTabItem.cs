#region Usings
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using NaroConstants.Names;
using NaroSketchAdapter.Views;
using OccCode;
using PropertyDescriptorsInterface;
using System.Collections.Generic;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
using MetaActionsInterface;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ConstraintsModule.Views;
using Naro.Infrastructure.Library.Geometry;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;


#endregion

namespace PropertyGridTabItems
{
    public class NewConstraintInfo
    {
        public string ConstraintName { get; set; }
        public string ConstraintFunctionName { get; set; }
        public Node SketchNode { get; set; }
        public List<Node> SelectedNodes { get; set; }
    }

    public class AvailableConstraintsTabItem : PropertyTabItemBase
    {
        private ListBox _listBox;
        private string _value;


        private int _height;

        public AvailableConstraintsTabItem(int height)
        {
            _height = height;
        }

        public override void FillControlEvents(DockPanel parentControl)
        {
            var grid = new Grid();
            var row1 = new RowDefinition {Height = new GridLength(_height + 10, GridUnitType.Pixel)};
            var col1 = new ColumnDefinition
                           {
                               Width = new GridLength(0.10, GridUnitType.Star),
                               MaxWidth = 136
                           };
            grid.RowDefinitions.Add(row1);
            grid.ColumnDefinitions.Add(col1);

            _listBox = new ListBox()
                           {
                               Height = _height,
                               Foreground = new SolidColorBrush(Colors.Black),
                               Margin = new Thickness(26, 0, 7, 0),
                               MaxWidth = 132,
                               MinWidth = 50
                           };
            Grid.SetColumn(_listBox, 0);
            Grid.SetRow(_listBox, 0);
            grid.Children.Add(_listBox);

            _listBox.SetResourceReference(FrameworkElement.StyleProperty, "roundTextBox");
           
            parentControl.Children.Add(grid);
         
            _listBox.SelectionChanged += ListBoxOnSelectionChanged;
            _listBox.DisplayMemberPath = "ConstraintName";
            UpdateFieldValue();
        }


        public int SetTabOrder(int tabIndex)
        {
            _listBox.TabIndex = tabIndex;
            return 1;
        }
        
        public override void Focus()
        {
            _listBox.Focus();
        }

        private void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            _listBox.ItemsSource = (List<NewConstraintInfo>)result;
        }

        private void ListBoxOnSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            if (((ListBox)sender).SelectedItems.Count > 0)
            {
                var sketchNode = ((NewConstraintInfo) ((ListBox) sender).SelectedItems[0]).SketchNode;
                var currentNodes = ((NewConstraintInfo) ((ListBox) sender).SelectedItems[0]).SelectedNodes;
                var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
                document.Transact();
                var constraintDocumentHelper = new ConstraintDocumentHelper(document, sketchNode);
                var firstPointIndex = NodeUtils.GetFirstPointIndex(currentNodes[0]);
                constraintDocumentHelper.SetMousePosition(firstPointIndex);
                var constraintAdded = constraintDocumentHelper.ApplyConstraint(currentNodes,
                    ((NewConstraintInfo) ((ListBox) sender).SelectedItems[0]).ConstraintFunctionName);
                if(currentNodes.Count ==1)
                    NodeBuilderUtils.AdddHintsForNode(document, currentNodes[0], constraintAdded.Node);
                constraintDocumentHelper.ImpactAndSolve(currentNodes[0]);
                document.Commit("Added constraint to scene");
                UpdateFieldValue();
            }
            

        }
    }
}