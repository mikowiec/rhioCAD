#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Sketch
{
    public partial class BlockPlaneButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        private bool _isBlocked;

        public BlockPlaneButton()
        {
            InitializeComponent();
        }

        private void BlockPlaneButtonClick(object sender, ExecutedRoutedEventArgs e)
        {
            if (!_isBlocked)
            {
                Log.Info("After pressing BlockPlane button : plane is blocked");
                Block();
            }
            else
            {
                Log.Info("After pressing BlockPlane button : plane is unblocked");
                Unblock();
            }
        }

        private void Block()
        {
            SwitchUserAction(ModifierNames.BlockPlane);
            _isBlocked = true;
        }

        private void Unblock()
        {
            SwitchUserAction(ModifierNames.UnblockPlane);
            _isBlocked = false;
        }
    }
}