#region Usings

using System.Collections.Generic;

#endregion

namespace NaroUiBuilder
{
    public class NaroUiPathFolder
    {
        public readonly Dictionary<string, NaroUiPathFolder> Folders;
        public readonly string Name;

        private ConcretePathFactory _factory;

        public NaroUiPathFolder(string folderName)
        {
            Name = folderName;

            Folders = new Dictionary<string, NaroUiPathFolder>();
        }

        public ConcretePathFactory Factory
        {
            get { return _factory; }
            set
            {
                _factory = value;
                _factory.SetupPath(this);
            }
        }

        public NaroUiPathFolder AddFolder(string folderName)
        {
            if (Folders.ContainsKey(folderName))
                return Folders[folderName];
            var newFolder = new NaroUiPathFolder(folderName);
            Folders[folderName] = newFolder;
            return newFolder;
        }

        private NaroUiPathFolder Get(string child)
        {
            return Folders.ContainsKey(child) ? Folders[child] : null;
        }

        public NaroUiPathFolder GetPathElement(string path)
        {
            var splittedPath = path.Split('/', '.', ' ');
            var parent = this;
            foreach (var word in splittedPath)
            {
                var child = parent.Get(word);
                parent = child ?? parent.AddFolder(word);
            }
            return parent;
        }

        public void BuildUi()
        {
            if (Factory != null)
                Factory.UpdateUi();
            foreach (var uiFolder in Folders.Values)
                uiFolder.BuildUi();
            if (Factory != null)
                Factory.AddChildrenToParent();
        }
    }
}