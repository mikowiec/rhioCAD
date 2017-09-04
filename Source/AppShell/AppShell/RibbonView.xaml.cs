#region Usings

using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Extensions.Wpf;
using log4net;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using NaroSetup;

#endregion

namespace AppShell
{
    /// <summary>
    ///   Interaction logic for RibbonView.xaml
    /// </summary>
    public partial class RibbonView
    {
        #region Delegates

        public delegate void RestoreDefaultLayoutEvent();

        #endregion

        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public RestoreDefaultLayoutEvent OnRestoreDefaultLayout;
        private ActionsGraph _actionGraph;

        public RibbonView()
        {
            InitializeComponent();
           // ribbonControl.Title = "NaroCAD " + NaroAppConstantNames.Version + " Beta";
            ribbonControl.BorderBrush = Brushes.LawnGreen;
            AppMenu.MouseDoubleClick += AppMenuDoubleClick;
        }

        private void AppMenuDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Log.Info("After pressing double ckick at application menu:");
            var curApp = Application.Current;
            curApp.Shutdown();
        }

        public void SetActionGraph(ActionsGraph actionsGraph)
        {
            _actionGraph = actionsGraph;
        }

        private void LaunchCommand(string actionName)
        {
            _actionGraph.SwitchAction(actionName);
        }

        private void NewCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing NewFile button");
            LaunchCommand(ModifierNames.NewFile);
        }

        private void OpenCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FileOpen button");
            LaunchCommand(ModifierNames.FileOpen);
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FileSave button");
            LaunchCommand(ModifierNames.FileSave);
        }

        private void SaveAsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing FileSaveAs button");
            LaunchCommand(ModifierNames.FileSaveAs);
        }

        private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Undo button");
            LaunchCommand(ModifierNames.Undo);
        }

        private void RedoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Redo button");
            LaunchCommand(ModifierNames.Redo);
        }

        private void ExportStepExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ExportToStep button");
            StartExport.Command = ExportStep.Command;
            LaunchCommand(ModifierNames.ExportToStep);
        }

        private void ExportNaroXmlExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ExportToNaroXml button");
            StartExport.Command = ExportNaroXml.Command;
            LaunchCommand(ModifierNames.ExportToNaroXml);
        }

        private void ImportBrepExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ImportFromBrep button");
            StartImport.Command = ImportBrep.Command;
            LaunchCommand(ModifierNames.ImportFromBrep);
        }

        private void ImportStepExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ImportFromStep button");
            StartImport.Command = ImportStep.Command;
            LaunchCommand(ModifierNames.ImportFromStep);
        }

        private void ImportNaroXmlExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ImportFromNaroXml button");
            StartImport.Command = ImportNaroXml.Command;
            LaunchCommand(ModifierNames.ImportFromNaroXml);
        }

        private void OptionsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Options button");
            var optionsSetup = _actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            optionsSetup.ShowOptions("Welcome");
        }

        private void RibbonControlIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            WpfSplash.Instance.Close();
        }

        private void RibbonCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Close button");
            var curApp = Application.Current;
            curApp.Shutdown();
        }

        private void RestoreDefaultLayoutExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing RestoreDefaultLayout button");
            SystemUtilities.Command = RestoreDefaultLayout.Command;
            if (OnRestoreDefaultLayout != null)
                OnRestoreDefaultLayout();
        }

        private void StartPluginEditorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing StartPluginEditor button");
            SystemUtilities.Command = StartPluginEditor.Command;
            var process = new Process {StartInfo = new ProcessStartInfo {FileName = "PluginEditor.exe"}};
            process.Start();
        }
    }
}