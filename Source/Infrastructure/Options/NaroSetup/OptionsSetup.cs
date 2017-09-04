#region Usings

using System.Collections.Generic;
using System.IO;
using NaroSetup.Pages.AutoSave;
using NaroSetup.Pages.Metrics;
using NaroSetup.Pages.Occ;
using NaroSetup.Pages.ReportBug;
using NaroSetup.Pages.SketchHinter;
using NaroSetup.Pages.Solver;
using NaroSetup.Pages.Updater;
using NaroSetup.Pages.Welcome;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSetup
{
    /// <summary>
    ///   Description of OptionsManager.
    /// </summary>
    public class OptionsSetup
    {
        #region Delegates

        public delegate void OnUpdatedValue();

        #endregion

        private readonly SortedDictionary<string, OptionsItem> _items;
        private readonly SortedDictionary<string, Section> _sections;

        public OnUpdatedValue UpdatedValue;
        private OptionsItem _currentItem;
        private OptionsWindow _view;

        static OptionsSetup()
        {
            Instance = new OptionsSetup();
        }

        private OptionsSetup()
        {
            _items = new SortedDictionary<string, OptionsItem>();
            Document = new Document();
            _sections = new SortedDictionary<string, Section>();

            Document.Changed += OnCommit;
            Document.Transact();

            Register(new WelcomeOptionsItem());

            Register(new OccOptionsItem());

            Register(new MetricOptionsItem());
            Register(new ReportBugOptionsItem());
            //Register(new RenderingOptionsItem());
            Register(new SolverOptionsItem());
            Register(new AutoSaveOptionsItem());
            Register(new MetricOptionsItem());
            Register(new UpdateOptionsItem());
            Register(new SletchHinterOptionsItem());
            Document.Commit("Added default sections");

            LoadOptions(OptionsWindow.OptionsFile);
        }

        internal static OptionsSetup Instance { get; private set; }

        public Document Document { get; private set; }

        public void Refresh()
        {
            if (UpdatedValue != null)
                UpdatedValue();
        }

        private void OnCommit()
        {
            UpdateSections();
            if (UpdatedValue != null)
                UpdatedValue();
        }

        private void UpdateSections()
        {
            foreach (var item in _items.Values)
            {
                item.Data = GetSection(item.Name);
                item.OnUpdateData();
            }
        }

        public void Register(OptionsItem item)
        {
            _items[item.Name] = item;
            if (_sections.ContainsKey(item.Name)) return;
            var section = new Section(item.Name, Document);
            item.Data = section;
            _sections[item.Name] = section;
        }

        public void LoadOptions(string fileName)
        {
            var loaded = false;
            if (File.Exists(fileName))
            {
                try
                {
                    loaded = Document.LoadFromXml(fileName);
                }
                catch
                {
                    loaded = false;
                }
            }
            if (!loaded)
            {
                Document.Transact();
                foreach (var item in _items.Values)
                {
                    item.Data = GetSection(item.Name);
                    item.DefaultValues();
                }
                Document.Commit("Store default options");
                SaveOptions(fileName);
            }
            RebuildSections();
            if (UpdatedValue != null) UpdatedValue();
            Document.Transact();
        }

        public void SaveOptions(string fileName)
        {
            Document.SaveToXml(fileName);
        }

        private void RebuildSections()
        {
            _sections.Clear();
            foreach (var nodeSection in Document.Root.Children.Values)
            {
                var section = new Section(nodeSection, Document);
                ConnectToSection(section);
            }
        }

        public Section UpdateSectionNode(string sectionName)
        {
            foreach (var child in Document.Root.Children.Values)
            {
                if (child.Set<StringInterpreter>().Value != sectionName) continue;
                var resultSection = new Section(child, Document);
                ConnectToSection(resultSection);
                return resultSection;
            }
            var result = Document.Root.AddNewChild();
            var interpreter = result.Set<StringInterpreter>();
            interpreter.Value = sectionName;
            var section = new Section(result, Document);
            ConnectToSection(section);
            return section;
        }

        private void ConnectToSection(Section resultSection)
        {
            _sections[resultSection.Name] = resultSection;
        }

        public void CleanupView()
        {
            _view = null;
        }

        public void ShowOptions(string sectionName)
        {
            if (_view == null)
            {
                _view = new OptionsWindow();
                _view.BuildSections(_items.Values);
            }
            var item = GetItem(sectionName);
            if (item == null)
            {
                var firstSection = _items.Keys.GetEnumerator().Current;
                if (firstSection != null) if (_items.ContainsKey(firstSection)) item = _items[firstSection];
            }
            if (item != null)
            {
                _view.SetHeader(item.Title, item.Description);
                PopulateView(item);
            }
            _view.Show();
            _view.Focus();
            _view.ShowInTaskbar = false;
            _currentItem = item;
        }

        public void SetDefaultOptions()
        {
            var item = _currentItem;
            item.Data.Node.RemoveAllChildren();
            item.DefaultValues();
            Instance.ShowOptions(item.Name);
        }

        private OptionsItem GetItem(string sectionName)
        {
            return _items.ContainsKey(sectionName) ? _items[sectionName] : null;
        }

        private void PopulateView(OptionsItem item)
        {
            item.Data = GetSection(item.Name);
            _view.PopulateChildView(item);
            item.OnUpdateData();
        }

        private Section GetSection(string name)
        {
            if (!_sections.ContainsKey(name))
            {
                var node = Document.Root.AddNewChild();
                node.Set<StringInterpreter>().Value = name;
                RebuildSections();
            }
            return _sections[name];
        }

        public void Commit(string changedOptionsValue)
        {
            Document.Commit(changedOptionsValue);
            Document.Transact();
            if (UpdatedValue != null)
                UpdatedValue();
        }
    }
}