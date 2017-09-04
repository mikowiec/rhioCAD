#region Usings

using System.Windows;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;

#endregion

namespace TestBuilderPlugin.View
{
    /// <summary>
    ///   Interaction logic for DebugToolsRemote.xaml
    /// </summary>
    public partial class DebugToolsRemote
    {
        private readonly ActionsGraph _actionsGraph;

        public DebugToolsRemote(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            InitializeComponent();
        }

        private void LaunchOutputDebugClick(object sender, RoutedEventArgs e)
        {
            var document =
                _actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();
            var form = new OutputDebug();
            form.SetupDocument(document);
            form.Show();
        }

        private void LaunchUnitTestRemote(object sender, RoutedEventArgs e)
        {
            var window = new BooUnitTestRemote(_actionsGraph);
            window.Show();
        }
    }
}