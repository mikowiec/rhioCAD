#region Usings

using System.Windows.Controls;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroUiBuilder.RibbonMapping;

#endregion

namespace NaroUiBuilder
{
    public class UiBuilder
    {
        public readonly AbstractFactoryPath Factory;
        private ActionsGraph _actionGraph;

        public UiBuilder(ActionsGraph actionsGraph)
        {
            ActionsGraph = actionsGraph;
            Factory = new AbstractFactoryPath();
        }

        public ActionsGraph ActionsGraph
        {
            get
            {
                return
                    _actionGraph[InputNames.CurrentDocumentInput].GetData(NotificationNames.GetContainer).Get
                        <ActionsGraph>();
            }
            private set { _actionGraph = value; }
        }

        private void AddControl(string path, UiMappingItem mappingItem)
        {
            Factory.RegisterPath(path, new UiMappingConcretePathFactory(mappingItem));
        }

        public Control GetItemAtPath(string path)
        {
            var pathElement = Factory.GetPathElement(path);
            return pathElement.Factory.Control;
        }

        public void AddRibbonButton(string path, RibbonSplitButtonMapping buttonMapping)
        {
            buttonMapping.SetUiBuilder(this);
            AddControl(path, new UiMappingItem {Control = buttonMapping});
        }

        public void AddRibbonButton(string path, RibbonButtonMapping buttonMapping)
        {
            buttonMapping.SetUiBuilder(this);
            AddControl(path, new UiMappingItem {Control = buttonMapping});
        }

        public void AddMapping(string path, IControllerUiMapping buttonMapping)
        {
            buttonMapping.SetUiBuilder(this);
            AddControl(path, new UiMappingItem {Control = buttonMapping.GetControl()});
        }

        public void BuildUi()
        {
            Factory.BuildUi();
        }
    }
}