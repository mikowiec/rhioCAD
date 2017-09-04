#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using BooEvaluator.Boo;
using Naro.Infrastructure.Interface.Boo;
using Naro.Infrastructure.Interface.Views.Timers;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace TestBuilderPlugin.View
{
    /// <summary>
    ///   Interaction logic for BooUnitTestRemote.xaml
    /// </summary>
    public partial class BooUnitTestRemote
    {
        private const string TimerName = "TestUnit";
        private readonly ActionsGraph _actionsGraph;
        private FolderBrowserDialog _folderPicker;

        public BooUnitTestRemote(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;

            InitializeComponent();
        }

        private void OpenClick(object sender, RoutedEventArgs e)
        {
            _progress.Value = 0;
            _folderPicker = new FolderBrowserDialog {SelectedPath = @"..\..\NaroTestSuite\Boo"};
            var dialogResult = _folderPicker.ShowDialog();
            if (dialogResult != System.Windows.Forms.DialogResult.OK)
                return;
            var fileList = GetBooFileList(_folderPicker.SelectedPath);
            BackToDefaultDirectory();
            ResetProgressBar(fileList);
            var isScript = _isScriptCheck.IsChecked ?? false;
            var updateTime = GetUpdateTime();
            foreach (var fileName in fileList)
            {
                var testWrapper = new TestWrapper(_actionsGraph, fileName, isScript, this);
                TimerTaskManager.Instance.AddTask(TimerName, testWrapper.ExecuteFileName);
            }
            TimerTaskManager.Instance.AddTask(TimerName, ViewRefreshHandler);
            TimerTaskManager.Instance.StartTimer(TimerName, updateTime);
        }

        private void ResetProgressBar(ICollection fileList)
        {
            _progress.Value = 0;
            _progress.Maximum = fileList.Count;
        }

        private int GetUpdateTime()
        {
            int updateTime;
            try
            {
                updateTime = BooEval.GetInt32(_intervalTextBox.Text);
            }
            catch
            {
                updateTime = 300;
            }
            return updateTime;
        }

        private static void BackToDefaultDirectory()
        {
            var naroDirectory = NaroAppConstantNames.InstallDirectory;
            Directory.SetCurrentDirectory(naroDirectory);
        }

        private void ViewRefreshHandler(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void IncrementProgress(string fileName)
        {
            _progress.Value++;
            var text = String.Format("File: {0} ({1}/{2})", fileName, _progress.Value, _progress.Maximum);
            _statusText.Text = text;
            ViewRefresh();
        }

        private void ViewRefresh()
        {
            _actionsGraph.InputContainer[InputNames.View].Send(NotificationNames.RefreshView);
        }

        private static List<string> GetBooFileList(string directoryName)
        {
            var di = new DirectoryInfo(directoryName);
            var files = di.GetFiles("*.boo");
            var sd = new SortedDictionary<string, int>();
            foreach (var fileName in files)
                sd[fileName.FullName] = 1;
            return sd.Keys.ToList();
        }

        private void ButtonCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #region Nested type: TestWrapper

        private class TestWrapper
        {
            private readonly ActionsGraph _actionsGraph;
            private readonly Document _document;
            private readonly string _fileName;
            private readonly bool _isScript;
            private readonly BooUnitTestRemote _remote;

            public TestWrapper(ActionsGraph actionsGraph, string fileName, bool isScript, BooUnitTestRemote remote)
            {
                _actionsGraph = actionsGraph;
                _fileName = fileName;
                _isScript = isScript;
                _remote = remote;

                _document =
                    _actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();
            }

            public void ExecuteFileName(object sender, EventArgs eventArgs)
            {
                var document = _document;
                var fileName = _fileName;
                try
                {
                    if (_isScript)
                    {
                        // Set the script location/execution path
                        BooUtil.ExecuteBooScript(_actionsGraph, fileName);
                    }
                    else
                    {
                        BooUtil.ExecuteBooProgram(_actionsGraph, fileName);
                    }
                }
                catch (Exception ex)
                {
                    Ensure.IsTrue(false, "Error executing file: " + fileName + " Exception: " + ex.Message);
                }
                _remote.IncrementProgress(fileName);
                try
                {
                    document.Undo();
                }
                catch (Exception ex)
                {
                    Ensure.IsTrue(false, "Error on undo file: " + fileName + " Exception: " + ex.Message);
                }
            }
        }

        #endregion
    }
}