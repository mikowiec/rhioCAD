#region Usings

using System.Windows.Input;
using AvalonDock.Properties;

#endregion

namespace AvalonDock
{
    /// <summary>
    ///   Encapsulates the
    /// </summary>
    public sealed class DockableFloatingWindowCommands
    {
        private static readonly object syncRoot = new object();

        private static RoutedUICommand dockableCommand;

        private static RoutedUICommand floatingCommand;

        public static RoutedUICommand SetAsDockableWindow
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == dockableCommand)
                    {
                        dockableCommand = new RoutedUICommand(Resources.DockableContentCommands_DockableFloatingWindow,
                                                              "DockableWindow", typeof (DockableFloatingWindowCommands));
                    }
                }
                return dockableCommand;
            }
        }

        public static RoutedUICommand SetAsFloatingWindow
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == floatingCommand)
                    {
                        floatingCommand = new RoutedUICommand(Resources.DockableContentCommands_FloatingWindow,
                                                              "FloatingWindow", typeof (DockableFloatingWindowCommands));
                    }
                }
                return floatingCommand;
            }
        }

        //private static RoutedUICommand closeCommand = null;
        //public static RoutedUICommand Close
        //{
        //    get
        //    {
        //        lock (syncRoot)
        //        {
        //            if (null == closeCommand)
        //            {
        //                closeCommand = new RoutedUICommand("Close", "Close", typeof(FloatingWindowCommands));
        //            }
        //        }
        //        return closeCommand;
        //    }
        //}

        //private static RoutedUICommand dockCommand = null;
        //public static RoutedUICommand Dock
        //{
        //    get
        //    {
        //        lock (syncRoot)
        //        {
        //            if (null == dockCommand)
        //            {
        //                dockCommand = new RoutedUICommand("Dock", "Dock", typeof(FloatingWindowCommands));
        //            }
        //        }
        //        return dockCommand;
        //    }
        //}
    }
}