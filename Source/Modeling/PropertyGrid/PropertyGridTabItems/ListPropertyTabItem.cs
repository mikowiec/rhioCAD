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
    public class ConstraintInfo
    {
        public string ConstraintName { get; set; }
        public NodeBuilder ConstraintNode { get; set; }
    }

    public class ListPropertyTabItem : PropertyTabItemBase
    {
        private ListBox _listBox;
        private string _value;


        public override void FillControlEvents(DockPanel parentControl)
        {
            var grid = new Grid();
            var row1 = new RowDefinition {Height = new GridLength(55, GridUnitType.Pixel)};
            var col1 = new ColumnDefinition
                           {
                               Width = new GridLength(0.10, GridUnitType.Star),
                               MaxWidth = 136
                           };
            grid.RowDefinitions.Add(row1);
            grid.ColumnDefinitions.Add(col1);

            _listBox = new ListBox()
                           {
                               Height = 44,
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
            _listBox.KeyDown += ListBoxOnKeyDown;
            _listBox.DisplayMemberPath = "ConstraintName";
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
            var allConstraints = new List<ConstraintInfo>();
            foreach (var element in _result)
            {
               allConstraints.Add(new ConstraintInfo
                                        {
                                            ConstraintNode = element,
                                            ConstraintName = GeomUtils.CleanName(element.FunctionName)
                                        });
            }
            _listBox.ItemsSource = allConstraints;
        }


        private void ListBoxOnSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            if(((ListBox)sender).SelectedItems.Count > 0)
            {
                var dependencies =
                    ((ConstraintInfo) ((ListBox) sender).SelectedItems[0]).ConstraintNode.Dependency.Count;
                for(int i =0;i<dependencies; i++)
                {
                    var reference = ((ConstraintInfo) ((ListBox) sender).SelectedItems[0]).ConstraintNode.Dependency[i];
                    if (reference.Name == InterpreterNames.Reference && reference.ReferenceBuilder != null)
                        reference.ReferenceBuilder.Color = System.Drawing.Color.Red;
                }
            }
        }
    }
}