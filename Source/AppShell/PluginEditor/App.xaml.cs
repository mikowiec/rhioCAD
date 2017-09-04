#region Usings

using System.Windows;
using ErrorReportCommon;
using ErrorReportCommon.Messages;
using PluginEditor.UI;

#endregion

namespace PluginEditor
{
    /// <summary>
    ///   Lógica de interacción para App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            NaroMessage.SetFactory(new MessageBoxMessage());
            var pluginManagerWindow = new ManagementPluginWindow();
            pluginManagerWindow.ShowDialog();
        }
    }
}