#region Usings

using Microsoft.Windows.Controls.Ribbon;

#endregion

namespace NaroUiBuilder.RibbonMapping
{
    public class RibbonTabConcretePathFactory : ConcretePathFactory
    {
        private bool _attached;
        private RibbonTab RibbonTabControl { get; set; }

        public override void UpdateUi()
        {
            RibbonTabControl = new RibbonTab {Label = Path.Name};
            Control = RibbonTabControl;

            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                if (folder.Factory == null)
                    folder.Factory = new RibbonGroupConcretePathFactory();
            }
        }

        public override void AddChildrenToParent()
        {
        }

        public void AttachToParent()
        {
            if (_attached) return;
            _attached = true;
            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                var childControl = folder.Factory.Control;
                RibbonTabControl.Groups.Add((RibbonGroup) childControl);
            }
        }
    }
}