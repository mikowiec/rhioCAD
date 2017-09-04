#region Usings

using MetaActionsInterface;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Views;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;
using NaroSetup;
using PartModellingLogic.Inputs.Naro.Factories;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingUi.Layout;
using ShapeFunctionsInterface.Functions;
using TestBuilderPlugin.View;
using WpfPropertyGrid.Layers;
using WpfPropertyGrid.UI;

#endregion

namespace NaroAppDocumentCore
{
    internal class DefaultAppInputs
    {
        public DefaultAppInputs(ActionsGraph actionsGraph)
        {
            ActionGraph = actionsGraph;
        }

        private ActionsGraph ActionGraph { get; set; }

        public void InitializeInputs(ViewInfo viewInfo, ITreeViewControl treeView, PropertyGridView wpfPropertyView,
                                     CommandLineView commandLineView, LayerView layerView, IHelpView helpView,
                                     BooView booView)
        {
            ActionGraph.Register(new NodeSelectInput());
            ActionGraph.Register(new UiElementsItem(treeView, wpfPropertyView, layerView, helpView, booView));
            ActionGraph.Register(new ViewInfoInput(viewInfo));
            ActionGraph.Register(new CommandLineInput(commandLineView));
            ActionGraph.Register(new RestrictedPlaneInput());
            ActionGraph.Register(new ClipboardManager());
            ActionGraph.Register(new CommandLinePrePusherInput());
            ActionGraph.Register(new DescriptorsFactoryInput());
            ActionGraph.Register(new FunctionFactoryInput());
            ActionGraph.Register(new OptionsSetupInput());
            ActionGraph.Register(new UiBuilderInput());
            ActionGraph.Register(new CurrentDocumentInput());
            ActionGraph.Register(new GlobalCapabilitiesInput());
        }
    }
}