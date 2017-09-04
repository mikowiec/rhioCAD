namespace NaroUiBuilder
{
    public class AbstractFactoryPath
    {
        private readonly NaroUiPathFolder _root;

        public AbstractFactoryPath()
        {
            _root = new NaroUiPathFolder(string.Empty);
        }

        public void RegisterPath(string path, ConcretePathFactory pathFactory)
        {
            var splittedPath = path.Split('/', '.');
            var parent = _root;
            foreach (var word in splittedPath)
                parent = parent.AddFolder(word);
            parent.Factory = pathFactory;
            pathFactory.SetupPath(parent);
        }

        public NaroUiPathFolder GetPathElement(string path)
        {
            return _root.GetPathElement(path);
        }

        public void BuildUi()
        {
            _root.BuildUi();
        }
    }
}