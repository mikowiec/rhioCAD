#region Usings

using System.Windows.Controls;

#endregion

namespace NaroUiBuilder
{
    public abstract class ConcretePathFactory
    {
        protected NaroUiPathFolder Path { get; private set; }
        public Control Control { get; protected set; }

        public void SetupPath(NaroUiPathFolder path)
        {
            Path = path;
        }

        public abstract void UpdateUi();

        public abstract void AddChildrenToParent();
    }
}