#region Usings

using MetaActionsInterface;
using NaroCAD.Plugin.Structural.Design.UI;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroUiBuilder;
using PluginInterface;
using PropertyDescriptorsInterface;
using ShapeFunctionsInterface.Functions;
using TreeData.Capabilities;
using TreeData.Utils;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    [NaroRegister]
    public class ModifierRegister
    {
        public void Register(ActionsGraph actionsGraph)
        {
            Ensure.ArgumentNotNull(actionsGraph, "actionsGraph");

            RegisterUi(actionsGraph);
            RegisterAction(actionsGraph);
            RegisterFunction(actionsGraph);

            SetIcon(actionsGraph);

            SetPropertyGrid(actionsGraph);
        }

        private static void RegisterUi(ActionsGraph actionsGraph)
        {
            var uiBuilderInput = actionsGraph[InputNames.UiBuilderInput];
            Ensure.ArgumentNotNull(uiBuilderInput, "uiBuilderInput");
            var dataPackage = uiBuilderInput.GetData(NotificationNames.GetValue);
            Ensure.ArgumentNotNull(dataPackage, "dataPackage");
            var uiBuilder = dataPackage.Get<UiBuilder>();
            Ensure.ArgumentNotNull(uiBuilder, "uiBuilder");

            uiBuilder.AddRibbonButton("Ribbon/Structural/Design/Cursor", new CursorToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Structural/Design/Point", new PointToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Structural/Design/Beam", new BeamToolButton());
        }

        private static void RegisterAction(ActionsGraph actionsGraph)
        {
            var input = actionsGraph[InputNames.ListCommandInput];
            Ensure.ArgumentNotNull(input, "input");
            var dataPackage = input.GetData(NotificationNames.GetValue);
            Ensure.ArgumentNotNull(dataPackage, "dataPackage");
            var commandList = dataPackage.Get<CommandList>();
            Ensure.ArgumentNotNull(commandList, "commandList");

            commandList.Register(Constant.ActionBeam, Constant.CommandLineBeam, new BeamAction());
        }

        private static void RegisterFunction(ActionsGraph actionsGraph)
        {
            var input = actionsGraph.InputContainer[InputNames.FunctionFactoryInput];
            Ensure.ArgumentNotNull(input, "input");
            var dataPackage = input.GetData(NotificationNames.GetValue);
            Ensure.ArgumentNotNull(dataPackage, "dataPackage");
            var functionFactory = dataPackage.Get<IFunctionFactory>();
            Ensure.ArgumentNotNull(functionFactory, "functionFactory");

            functionFactory.Register<BeamFunction>();
        }

        private static void SetIcon(ActionsGraph actionsGraph)
        {
            var capabilitiesInput = actionsGraph[InputNames.GlobalCapabilitiesInput];
            Ensure.ArgumentNotNull(capabilitiesInput, "capabilitiesInput");
            var dataPackage = capabilitiesInput.GetData(NotificationNames.GetValue);
            Ensure.ArgumentNotNull(dataPackage, "dataPackage");
            var globalCapabilites = dataPackage.Get<CapabilitiesCollection>();
            Ensure.ArgumentNotNull(globalCapabilites, "globalCapabilites");

            var shapeConcept = globalCapabilites.AddConcept(Constant.FunctionBeam);
            Ensure.ArgumentNotNull(shapeConcept, "shapeConcept");

            shapeConcept.SetCapability(ShapeCapabilitiesNames.DefaultIcon, Constant.IconPathBeam);
        }

        private static void SetPropertyGrid(ActionsGraph actionsGraph)
        {
            var descriptorsInput = actionsGraph[InputNames.DescriptorsFactoryInput];
            Ensure.ArgumentNotNull(descriptorsInput, "descriptorsInput");
            var dataPackage = descriptorsInput.GetData(NotificationNames.GetValue);
            Ensure.ArgumentNotNull(dataPackage, "dataPackage");
            var descriptorsFactory = dataPackage.Get<DescriptorsFactory>();
            Ensure.ArgumentNotNull(descriptorsFactory, "descriptorsFactory");

            descriptorsFactory.RegisterFunctionTab(Constant.FunctionBeam, new BeamTab(Constant.PropertyGridTitleBeam));
        }
    }
}