#region Usings

using System.Windows.Input;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    /// <summary>
    ///   Interaction logic for FloatingWindow.xaml
    /// </summary>
    public partial class FloatingWindow
    {
        public FloatingWindow()
        {
            InitializeComponent();
        }

        private void StackPanel1MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void AddToolsVisualComponent(FloatingToolBase toolBase, SelectionContainer selectedItem,
                                            ActionsGraph actionsGraph)
        {
            toolBase.PopulateView(_toolsStack, selectedItem, actionsGraph);
        }

        public void ClearTools()
        {
            _toolsStack.Children.Clear();
        }
    }
}