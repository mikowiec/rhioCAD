#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    internal abstract class FloatingToolGroupButton : FloatingToolBase
    {
        protected Popup Popup;
        private Button _btnExpander;

        protected FloatingToolGroupButton(string name)
            : base(name)
        {
            LabelTitle = "Not set";
            ToolTipTitle = "Not set";
        }

        protected string LabelTitle { private get; set; }
        protected string ToolTipTitle { private get; set; }
        protected string IconImage { private get; set; }

        private void PopulateCurrentCommand(ContentControl expander, SelectionContainer selectedItem)
        {
            expander.Name = LabelTitle;
            expander.ToolTip = ToolTipTitle;
            expander.VerticalAlignment = VerticalAlignment.Top;
            var icon = new Image();

            if (!String.IsNullOrEmpty(IconImage))
            {
                var bitmapImage = new BitmapImage(new Uri(IconImage, UriKind.RelativeOrAbsolute));
                icon.Source = bitmapImage;
            }
            expander.Content = icon;
        }

        public override void PopulateView(StackPanel panel, SelectionContainer entity, ActionsGraph actionsGraph)
        {
            _btnExpander = new Button
                               {
                                   Name = "test",
                                   Height = 20,
                                   Width = 20,
                                   Margin = new Thickness {Bottom = 1, Left = 2, Right = 2, Top = 2},
                               };
            _btnExpander.SetResourceReference(FrameworkElement.StyleProperty, "RoundedButtonFloatinToolbar");

            if (Popup != null && Popup.IsOpen)
                Popup.IsOpen = false;
            Popup = new Popup {Name = "test1"};

            _btnExpander.Click += BtnExpanderClick;

            PopulateCurrentCommand(_btnExpander, entity);

            var stackPanel = new StackPanel();
            PopulateExtendedView(stackPanel, entity);
            Popup.Child = stackPanel;
            panel.Children.Add(_btnExpander);
        }

        private void BtnExpanderClick(object sender, RoutedEventArgs e)
        {
            if (!Popup.IsOpen)
                Popup.MouseLeave += PopupMouseLeave;
            Popup.IsOpen = !Popup.IsOpen;
            Popup.Placement = PlacementMode.Mouse;
        }

        private void PopupMouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        protected virtual void PopulateExtendedView(StackPanel panel, SelectionContainer entity)
        {
        }
    }
}