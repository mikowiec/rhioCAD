#region Usings

using System.Windows.Input;

#endregion

namespace BooDocumentImportExport.Views
{
    /// <summary>
    ///   Lógica de interacción para BooShapeList.xaml
    /// </summary>
    public partial class BooShapeList
    {
        public BooShapeList()
        {
            InitializeComponent();
        }

        private void SplineAddPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(BooModifier.BooDocumentExport);
        }
    }
}