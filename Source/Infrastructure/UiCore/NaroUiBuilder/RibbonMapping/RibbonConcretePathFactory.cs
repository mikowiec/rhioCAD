#region Usings

using System.Windows;
using Microsoft.Windows.Controls.Ribbon;

#endregion

namespace NaroUiBuilder.RibbonMapping
{
    public class RibbonConcretePathFactory : ConcretePathFactory
    {
        public RibbonConcretePathFactory(Ribbon parentControl)
        {
            RibbonControl = parentControl;

            Control = RibbonControl;
        }

        private Ribbon RibbonControl { get; set; }

        public override void UpdateUi()
        {
            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                if (folder.Factory == null)
                    folder.Factory = new RibbonTabConcretePathFactory();
            }
        }

        public override void AddChildrenToParent()
        {
            var path = Path;
            var pos = 0;
            RibbonControl.SelectedTabChanged += OnTabChanged;
            foreach (var folder in path.Folders.Values)
            {
                var childControl = folder.Factory.Control;
                RibbonControl.Tabs.Insert(pos, (RibbonTab) childControl);
                pos++;
            }
        }

        private void OnTabChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var tab = (RibbonTab) e.NewValue;
            var childItem = (RibbonTabConcretePathFactory) Path.Folders[tab.Label].Factory;
            childItem.AttachToParent();
        }
    }
}