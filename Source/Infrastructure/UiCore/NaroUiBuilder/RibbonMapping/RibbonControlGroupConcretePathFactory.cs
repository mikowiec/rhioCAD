#region Usings

using Microsoft.Windows.Controls.Ribbon;

#endregion

namespace NaroUiBuilder.RibbonMapping
{
    public class RibbonControlGroupConcretePathFactory : ConcretePathFactory
    {
        private RibbonControlGroup _ribbonControl;

        public override void UpdateUi()
        {
            _ribbonControl = new RibbonControlGroup {Height = 33};
            Control = _ribbonControl;
        }

        public override void AddChildrenToParent()
        {
            var path = Path;
            foreach (var folder in path.Folders.Values)
            {
                var childControl = folder.Factory.Control;
                _ribbonControl.Controls.Add((IRibbonControl) childControl);
            }
        }
    }
}