#region Usings

using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Naro.Infrastructure.Interface;
using NaroPipes.Constants;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.Utils;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Orientation = System.Windows.Controls.Orientation;
using RadioButton = System.Windows.Controls.RadioButton;

#endregion

namespace WpfPropertyGrid.Layers
{
    public class LayerVisualDescription
    {
        private readonly LayerContainerInterpreter _container;
        private readonly int _index;
        private readonly LayerView _parentView;
        private readonly ViewInfo _viewInfo;
        public ListBoxItem Item;
        public RadioButton RadioBtn;
        private Button _colorBtn;
        private CheckBox _visibilityCheckBox;

        public LayerVisualDescription(ViewInfo viewInfo, int index, LayerView parentView)
        {
            _viewInfo = viewInfo;
            _container = _viewInfo.Document.Root.Get<LayerContainerInterpreter>();
            _index = index;
            _parentView = parentView;
            Ensure.IsNotNull(_container);
            UpdateLayerValues();
        }

        private string Name { get; set; }
        private Color Color { get; set; }
        private bool IsVisible { get; set; }

        public int Index
        {
            get { return _index; }
        }

        private void UpdateLayerValues()
        {
            Name = _container.LayerNames[_index];
            Color = ShapeUtils.ToWpfColor(_container.LayerColors[_index]);
            IsVisible = _container.IsLayerVisible(_index);
        }

        public void AddToListBox()
        {
            var image = new Image {Height = 25, Width = 25};
            var tb = new TextBlock
                         {
                             Text = Name,
                             Foreground = new SolidColorBrush(Colors.Black),
                             VerticalAlignment = VerticalAlignment.Center
                         };
            var sp = new StackPanel {Orientation = Orientation.Horizontal};
            sp.Children.Add(image);
            _visibilityCheckBox = new CheckBox {IsChecked = IsVisible};
            _visibilityCheckBox.Click += VisiblityChange;
            var contentStack = new StackPanel {Orientation = Orientation.Horizontal};

            _visibilityCheckBox.Content = contentStack;

            _colorBtn = new Button
                            {
                                Background = new SolidColorBrush(Color),
                                Width = 25,
                                Height = 25,
                                Margin = new Thickness(5, 8, 5, 8)
                            };
            _colorBtn.Click += ColorPickerBtnClick;

            contentStack.Children.Add(_colorBtn);
            contentStack.Children.Add(sp);


            var rb = new RadioButton
                         {
                             Content = _visibilityCheckBox,
                             GroupName = "Layers",
                             Margin = new Thickness(20, 0, 0, 0),
                             IsChecked = _container.CurrentLayer == Index
                         };
            rb.Click += OnRadioChecked;
            RadioBtn = rb;

            var radioStack = new StackPanel {Orientation = Orientation.Horizontal};
            radioStack.Children.Add(rb);
            radioStack.Children.Add(tb);

            var lbi = new ListBoxItem {Content = radioStack};
            Item = lbi;
        }

        private void OnRadioChecked(object sender, RoutedEventArgs e)
        {
            var isChecked = RadioBtn.IsChecked ?? false;
            if (!isChecked)
                return;
            _viewInfo.SwitchAction(ModifierNames.None);
            BeginUpdate();
            _parentView.UpdateCurrentLayer(Index);
            EndUpdate();
        }

        private void EndUpdate()
        {
            _viewInfo.EndVisualUpdate("Change Current Layer");
        }

        private void BeginUpdate()
        {
            _viewInfo.BeginUpdate();
        }

        private void VisiblityChange(object sender, RoutedEventArgs e)
        {
            BeginUpdate();
            _container.SetLayerVisibility(Index, _visibilityCheckBox.IsChecked ?? false);
            _viewInfo.EndVisualUpdate("Changed Layer Visibility");
        }

        private void ColorPickerBtnClick(object sender, RoutedEventArgs e)
        {
            var form = ColorPickerSingleton.Instance.Form;
            var result = form.ShowDialog();
            if (result != DialogResult.OK)
                return;
            BeginUpdate();
            _colorBtn.Background = new SolidColorBrush(ShapeUtils.ToWpfColor(form.SelectedColor));
            Color = ((SolidColorBrush) (_colorBtn.Background)).Color;
            _container.LayerColors[_index] = ShapeUtils.FromWpfColor(Color);
            _container.OnModified();
            EndUpdate();
        }
    }
}