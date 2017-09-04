using System;

namespace NaroSetup.Pages.SketchHinter
{
    /// <summary>
    ///   Lógica de interacción para SketchHinterOptionsView.xaml
    /// </summary>
    public partial class SketchHinterOptionsView
    {
        public SketchHinterOptionsView()
        {
            InitializeComponent();
            PointPrecision.SetRanges(0, 100);
            AnglePrecision.SetRanges(0, 2 * Math.PI);
        }
    }
}