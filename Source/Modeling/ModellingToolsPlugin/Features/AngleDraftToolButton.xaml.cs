#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Features
{
    ///<summary>
    ///</summary>
    public partial class AngleDraftToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public AngleDraftToolButton()
        {
            InitializeComponent();
        }

        private void AngleDraftingClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing AngleDraft button");
            SwitchUserAction(ModifierNames.AngleDraftEnhanced);
        }
    }
}