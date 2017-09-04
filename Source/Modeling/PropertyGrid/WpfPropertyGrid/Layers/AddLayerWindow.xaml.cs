#region Usings

using System;
using System.Windows;
using System.Windows.Media;
using ErrorReportCommon.Messages;
using log4net;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace WpfPropertyGrid.Layers
{
    /// <summary>
    ///   Interaction logic for AddLayerWindow.xaml
    /// </summary>
    public partial class AddLayerWindow
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (AddLayerWindow));

        private readonly bool _updateValue;
        private LayerContainerInterpreter _container;
        private int _index;

        public AddLayerWindow(LayerContainerInterpreter container, bool updateValue)
        {
            Ensure.IsNotNull(container, "Layer Container should be defined!");
            _container = container;
            _updateValue = updateValue;
            InitializeComponent();

            _colorBtnPicker.Background = new SolidColorBrush(ComputeRandomColor());
        }

        public string LayerName
        {
            get { return _addNewLayerTextBox.Text; }
        }

        public Color LayerColor
        {
            get { return ((SolidColorBrush) (_colorBtnPicker.Background)).Color; }
            private set { _colorBtnPicker.Background = new SolidColorBrush(value); }
        }

        public void UpdateLayerDescription(LayerContainerInterpreter container, int index)
        {
            _index = index;
            _container = container;
            _addNewLayerTextBox.Text = container.LayerNames[index];
            _colorBtnPicker.Background = new SolidColorBrush(ShapeUtils.ToWpfColor(container.LayerColors[index]));
            Title = "Update Layer Name";
            _okNtn.Content = "_Update";
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After confirming the name of the new layer");
            var newLayerName = _addNewLayerTextBox.Text;
            if (_container.LayerNames.Contains(newLayerName))
            {
                NaroMessage.Show("Layer name already exist, please pick another!");
                Log.Info("The new layer cannot be added because of duplicate names");
                return;
            }
            DialogResult = true;
            if (_updateValue)
            {
                _container.LayerNames[_index] = newLayerName;
                Log.Info("Layer " + newLayerName + "added");
                _container.LayerColors[_index] = ShapeUtils.FromWpfColor(LayerColor);
            }
            Close();
        }

        private static Color ComputeRandomColor()
        {
            var random = new Random();
            var r = (byte) random.Next(255);
            var g = (byte) random.Next(255);
            var b = (byte) random.Next(255);
            return Color.FromRgb(r, g, b);
        }


        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }


        private void ColorBtnPickerClick(object sender, RoutedEventArgs e)
        {
            var form = ColorPickerSingleton.Instance.Form;
            form.SelectedColor = ShapeUtils.FromWpfColor(LayerColor);

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            LayerColor = ShapeUtils.ToWpfColor(form.SelectedColor);
        }
    }
}