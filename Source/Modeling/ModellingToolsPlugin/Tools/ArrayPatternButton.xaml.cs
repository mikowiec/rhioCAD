#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para PatternToolButton.xaml
    /// </summary>
    public partial class ArrayPatternButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public ArrayPatternButton()
        {
            InitializeComponent();
        }

        private void ArrayPatternClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Array Pattern button");
            //SwitchUserAction(ModifierNames.PatternLinearArray);
            SwitchUserAction(ModifierNames.ArrayPattern);
        }
    }
}