#region Usings

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

#endregion

namespace PropertyGridTabItems.CustomColorPicker
{
    /// <summary>
    ///   Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker
    {
        #region Delegates

        public delegate void ColorChangedEvent(Color color);

        #endregion

        private readonly List<Color> _currentColors;
        public ColorChangedEvent ColorChanged;

        public ColorPicker()
        {
            InitializeComponent();

            _currentColors = new List<Color>
                                 {
                                     Colors.YellowGreen,
                                     Colors.Gray,
                                     Colors.IndianRed,
                                     Colors.Gold,
                                     Colors.DeepPink,
                                     Colors.DarkOrchid,
                                     Colors.LightBlue,
                                     Colors.DarkGoldenrod,
                                     Colors.DarkSeaGreen,
                                     Colors.DarkTurquoise,
                                     Colors.Lavender,
                                     Colors.Silver,
                                     Colors.Olive,
                                     Colors.DarkBlue,
                                     Colors.LightGreen,
                                     Colors.YellowGreen,
                                     Colors.Red,
                                     Colors.Purple,
                                     Colors.SandyBrown,
                                     Colors.Black
                                 };
            PopulateColorCbx();
            cbxColor.SelectedIndex = 0;
        }

        private void PopulateColorCbx()
        {
            cbxColor.Items.Clear();
            foreach (var currentColor in _currentColors)
            {
                var canvas = new Canvas
                                 {
                                     Height = 20,
                                     Width = 90,
                                     Background = new SolidColorBrush(currentColor),
                                     HorizontalAlignment = HorizontalAlignment.Left,
                                     VerticalAlignment = VerticalAlignment.Center
                                 };

                cbxColor.Items.Add(canvas);
            }
        }

        private void CbxColorSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorChanged == null) return;
            var colorList = e.AddedItems;
            if (colorList.Count <= 0) return;
            var canvas = (Canvas) (colorList[0]);
            var color = (SolidColorBrush) canvas.Background;
            ColorChanged(color.Color);
        }
    }
}