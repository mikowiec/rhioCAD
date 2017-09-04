#region Usings

using System.Collections.Generic;
using System.IO;
using System.Windows;
using ErrorReportCommon.Messages;
using Microsoft.Win32;
using NaroConstants.Names;
using PluginInterface;

#endregion

namespace PluginEditor.UI
{
    /// <summary>
    ///   Lógica de interacción para ManagementPluginWindow.xaml
    /// </summary>
    public partial class ManagementPluginWindow
    {
        private readonly SortedDictionary<string, bool> _autoPluginListNames = new SortedDictionary<string, bool>();

        private readonly List<PluginDescription> _pluginList =
            new List<PluginDescription>();

        public ManagementPluginWindow()
        {
            InitializeComponent();
            UpdatePluginList();
        }

        private void InstallPluginClicked(object sender, RoutedEventArgs e)
        {
            var fileOpenDialog = new OpenFileDialog {Filter = "Naro Plugin Assembly (*.dll)|*.dll"};
            var result = fileOpenDialog.ShowDialog();
            if ((bool) (!result)) return;
            var fileName = fileOpenDialog.FileName;
            if (!PluginUtil.IsNaroPlugin(fileName))
            {
                NaroMessage.Show("You should select a NaroCAD plugin!");
                return;
            }
            File.Copy(fileName, AppSettings.Instance.StartFolder);
            UpdatePluginList();
        }

        private void UpdatePluginList()
        {
            BuildConfigPluginList();
            var availablePlugins = ScanFolder();
            pluginList.Items.Clear();
            foreach (var name in _autoPluginListNames)
            {
                availablePlugins.Remove(name.Key);
                var pluginDescription = new PluginDescription
                                            {Name = name.Key, State = PluginState.Removable, Enabled = name.Value};
                AddPluginEntry(pluginDescription);
            }
            foreach (var availableName in availablePlugins)
            {
                var pluginDescription = new PluginDescription
                                            {Name = availableName, State = PluginState.Available, Enabled = true};
                AddPluginEntry(pluginDescription);
            }
        }

        private void AddPluginEntry(PluginDescription pluginDescription)
        {
            var entry = new PluginEntryListItem(pluginDescription);
            entry.Changed += OnEntryChanged;
            pluginList.Items.Add(entry);
        }

        private void OnEntryChanged()
        {
            var listLines = new List<string>();
            foreach (var pluginItem in pluginList.Items)
            {
                var pluginEntry = (PluginEntryListItem) pluginItem;
                var description = pluginEntry.PluginDescription;
                if (description.State == PluginState.Available)
                    continue;
                var line = !description.Enabled ? "# " : string.Empty;
                listLines.Add(line + description.Name);
            }
            File.WriteAllLines(NaroAppConstantNames.PluginFileDescription, listLines.ToArray());
        }

        private List<string> ScanFolder()
        {
            var assemblies = Directory.GetFiles(NaroAppConstantNames.InstallDirectory, "*.dll");
            _pluginList.Clear();
            var filePluginList = new List<string>();
            var filterList = new List<string> {"msvcm90.dll", "msvcp90.dll", "msvcr90.dll"};
            foreach (var assembly in assemblies)
            {
                if (filterList.Contains(Path.GetFileName(assembly))) continue;
                if (!PluginUtil.IsNaroPlugin(assembly)) continue;
                var fileName = Path.GetFileName(assembly);
                if (string.IsNullOrEmpty(fileName)) continue;

                var pluginName = Path.GetFileNameWithoutExtension(fileName);
                filePluginList.Add(pluginName);
            }
            return filePluginList;
        }

        private void BuildConfigPluginList()
        {
            _autoPluginListNames.Clear();

            var listFilePlugins = PluginUtil.AutoLoadPlugins();
            foreach (var filePlugin in listFilePlugins)
                _autoPluginListNames.Add(filePlugin.Key, filePlugin.Value);
        }

        private void ClosedClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}