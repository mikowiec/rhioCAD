#region Usings

using Microsoft.Windows.Controls.Ribbon;

#endregion

namespace NaroUiBuilder.RibbonMapping
{
    public class RibbonGroupConcretePathFactory : ConcretePathFactory
    {
        private RibbonGroup RibbonGroupControl { get; set; }

        public override void UpdateUi()
        {
            var command = new RibbonCommand {LabelTitle = Path.Name};
            RibbonGroupControl = new RibbonGroup {Command = command};
            Control = RibbonGroupControl;

            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                if (folder.Factory == null)
                    folder.Factory = new RibbonGroupConcretePathFactory();
            }
        }

        public override void AddChildrenToParent()
        {
            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                var childControl = folder.Factory.Control;
                RibbonGroupControl.Controls.Add((IRibbonControl) childControl);
            }
        }
    }
}