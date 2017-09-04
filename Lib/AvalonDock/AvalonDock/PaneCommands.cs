#region Usings

using System.Windows.Input;

#endregion

namespace AvalonDock
{
    public sealed class PaneCommands
    {
        private static readonly object syncRoot = new object();


        private static RoutedUICommand dockCommand;

        /// <summary>
        ///   Dock <see cref = "Pane" /> to container <see cref = "DockingManager" />
        /// </summary>
        public static RoutedUICommand Dock
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == dockCommand)
                    {
                        dockCommand = new RoutedUICommand("Dock", "Dock", typeof (PaneCommands));
                    }
                }
                return dockCommand;
            }
        }
    }
}