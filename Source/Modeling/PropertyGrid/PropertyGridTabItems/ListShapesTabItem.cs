#region Usings
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using NaroConstants.Names;
using OccCode;
using PropertyDescriptorsInterface;
using System.Collections.Generic;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
#endregion

namespace PropertyGridTabItems
{
    public class ShapeInfo
    {
        public string ShapeName { get; set; }
        public NodeBuilder ShapeNode { get; set; }
    }

    public class ListShapesTabItem : PropertyTabItemBase
    {
        private ListBox _listBox;
        private string _value;
        private int _height;

        public ListShapesTabItem(int height)
        {
            _height = height;
        }

        public ListShapesTabItem()
        {
            _height = 44;
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

            _listBox = new ListBox
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
            //_listBox.KeyDown += ListBoxOnKeyDown;
            _listBox.DisplayMemberPath = "ShapeName";
            UpdateFieldValue();
        }

        private void ListBoxOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {

            if (((ListBox)sender).SelectedItems.Count > 0 && keyEventArgs.Key == Key.Delete)
             {
                 var selectedItem = ((ListBox) sender).SelectedItems[0];
                 var node = ((ConstraintInfo) ((ListBox) sender).SelectedItems[0]).ConstraintNode.Node;
                
                 var document = NodeBuilderUtils.FindSketchNode(node).Root.Get<DocumentContextInterpreter>().Document;
                 NodeBuilderUtils.DeleteConstraintNode(document, node);
                 UpdateFieldValue();
                
                 keyEventArgs.Handled = true;
             }
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

        public void UpdateFieldValue()
        {
            object result = null;
            OnGetValue(ref result);
            if (result == null)
                return;
            var _result = (List<NodeBuilder>) result;
            var shapes = new List<ShapeInfo>();
            foreach (var element in _result)
            {
               shapes.Add(new ShapeInfo
                                        {
                                           ShapeNode = element,
                                           ShapeName = element.ShapeName
                                        });
            }
            _listBox.ItemsSource = shapes;
        }


        private void ListBoxOnSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            if(((ListBox)sender).SelectedItems.Count == 1)
            {
                var node =
                    ((ShapeInfo) ((ListBox) sender).SelectedItems[0]).ShapeNode;
                
            }
        }
    }
}