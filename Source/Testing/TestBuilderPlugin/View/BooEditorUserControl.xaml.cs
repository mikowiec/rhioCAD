#region Usings

using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Indentation;
using log4net;
using Naro.Infrastructure.Interface.Boo;
using Naro.Infrastructure.Interface.Views.Timers;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.Utils;

#endregion

namespace TestBuilderPlugin.View
{
    /// <summary>
    ///   Interaction logic for BooEditorUserControl.xaml
    /// </summary>
    public partial class BooEditorUserControl
    {
        private const string TimerName = "CompileSource";
        private const string CodeCompiledSuccesfully = "Code compiled succesfully";
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private ActionsGraph _actionsGraph;
        private CompileEditingData _compileData;
        private OpenFileDialog _openFileDialog;
        private SaveFileDialog _saveFileDialog;

        public BooEditorUserControl()
        {
            InitializeComponent();
        }

        public void Setup(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            SetupBooEditor();

            SetupOpenSaveDialogs();
        }

        private void SetupBooEditor()
        {
            _textEditor.Options.ShowSpaces = true;
            _textEditor.Options.ShowTabs = true;
            _textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("Boo");
            _textEditor.TextArea.IndentationStrategy = new DefaultIndentationStrategy();
        }

        private void SetupOpenSaveDialogs()
        {
            _openFileDialog = new OpenFileDialog
                                  {
                                      DefaultExt = ".boo",
                                      Filter = "Boo files (.boo)|*.boo|All files|*.*"
                                  };
            _saveFileDialog = new SaveFileDialog
                                  {
                                      DefaultExt = ".boo",
                                      Filter = "Boo files (.boo)|*.boo|All files|*.*"
                                  };
            _errorTextArea.Text = CodeCompiledSuccesfully;
            _compileData = new CompileEditingData(this);
        }


        private void OpenClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Open Boo files ");
            var result = _openFileDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            var allText = File.ReadAllText(_openFileDialog.FileName);
            UpdateEditorText(allText);
        }

        public void UpdateEditorText(string allText)
        {
            _textEditor.Text = allText;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Save Boo files ");
            var result = _saveFileDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            File.WriteAllText(_saveFileDialog.FileName, _textEditor.Text);
        }

        private void ExecuteClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Execute Boo scripts ");
            var script = _textEditor.Text;
            ExecuteBooScript(script);
        }

        private static ActionsGraph GetCurrentActionGraph(ActionsGraph mainGraph)
        {
            return mainGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetContainer).Get
                <ActionsGraph>();
        }

        private void ExecuteBooScript(string script)
        {
            var isScript = _isScriptCheckBox.IsChecked ?? false;
            var context = BooUtil.GetCompilerContext(script, isScript);
            foreach (var error in context.Errors)
                NaroMessage.Show(error.ToString());
            if (context.Errors.Count != 0)
                return;
            var assembly = context.GeneratedAssembly;
            Ensure.IsNotNull(assembly);
            var currentGraph = GetCurrentActionGraph(_actionsGraph);
            if (!isScript)
            {
                BooUtil.ExecuteBooProgram("Script", context, currentGraph);
            }
            else
            {
                BooUtil.ExecuteBooScript("Script", context, currentGraph);
                currentGraph[InputNames.View].Send(NotificationNames.RefreshView);
                currentGraph[InputNames.UiElementsItem].Send(NotificationNames.RebuildTreeView);
            }
        }

        private void TextEditorTextChanged(object sender, EventArgs e)
        {
            RecompileSource();
        }

        private void RecompileSource()
        {
            if (_compileData == null) return;
            TimerTaskManager.Instance.StopTask(TimerName);
            TimerTaskManager.Instance.AddTask(TimerName, _compileData.Execute);
            TimerTaskManager.Instance.StartTimer(TimerName, 500);
        }

        private void IsScriptCheckBoxClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Test Boo Scripts ");
            RecompileSource();
        }

        private void HelpButtonClick(object sender, RoutedEventArgs e)
        {
            Log.Info("After pressing Boo Help button");
            var helpWindow = new BooHelpWindow();
            helpWindow.Show();
        }

        #region Nested type: CompileEditingData

        private class CompileEditingData
        {
            private readonly BooEditorUserControl _window;

            public CompileEditingData(BooEditorUserControl window)
            {
                _window = window;
            }

            public void Execute(object sender, EventArgs eventArgs)
            {
                var script = _window._textEditor.Text;
                var isScript = _window._isScriptCheckBox.IsChecked ?? false;
                var context = BooUtil.GetCompilerContext(script, isScript);
                var isCompilingSuccesfully = context.Errors.Count == 0;
                _window.executeBtn.IsEnabled = isCompilingSuccesfully;
                if (isCompilingSuccesfully)
                {
                    _window._errorTextArea.Text = CodeCompiledSuccesfully;
                    return;
                }
                var error = context.Errors[0];
                _window._errorTextArea.Text = error.ToString();
            }
        }

        #endregion
    }
}