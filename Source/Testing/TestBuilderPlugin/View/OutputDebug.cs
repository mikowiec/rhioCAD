#region Usings

using System;
using System.Windows.Forms;
using TreeData.NaroData;

#endregion

namespace TestBuilderPlugin.View
{
    public partial class OutputDebug : Form
    {
        #region Private singleton constructor

        public OutputDebug()
        {
            InitializeComponent();
        }

        #endregion

        #region Singleton SingletonInstance Property

        #endregion

        #region Public methods

        public void SetupDocument(Document document)
        {
            UpdateDocumentEvents(document);
        }

        private void RefreshTree()
        {
            PopulateTreeNodes();
        }

        #endregion

        #region Methods

        private void UpdateDocumentEvents(Document document)
        {
            UnregisterDocumentNotification();
            _document = document;
            if (_document != null)
                _document.Changed += DocumentRefreshNotification;
            DocumentRefreshNotification();
        }

        private void UnregisterDocumentNotification()
        {
            if (_document == null) return;
            _document.Changed -= DocumentRefreshNotification;
            _document = null;
        }

        private void DocumentRefreshNotification()
        {
            PopulateTreeNodes();
        }

        private void PopulateTreeNodes()
        {
            ObjectsTreeList.BeginUpdate();
            ObjectsTreeList.Nodes.Clear();
            _documentTreeScanner.PopulateTreeNodes(_document.Root, ObjectsTreeList.Nodes);
            ObjectsTreeList.ExpandAll();
            ObjectsTreeList.EndUpdate();
        }

        private void RefreshBtnClick(object sender, EventArgs e)
        {
            RefreshTree();
        }

        #endregion

        #region Data members

        private readonly DocumentTreeScanner _documentTreeScanner = new DocumentTreeScanner();
        private Document _document;

        #endregion

        private void OutputDebugFormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterDocumentNotification();
        }
    }
}