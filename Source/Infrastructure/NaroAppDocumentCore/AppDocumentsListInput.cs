#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Interface.Views;
using NaroConstants.Names;
using NaroPipes.Actions;
using PartModellingUi.Layout;
using TestBuilderPlugin.View;
using WpfPropertyGrid.Layers;
using WpfPropertyGrid.UI;

#endregion

namespace NaroAppDocumentCore
{
    public class AppDocumentsListInput : InputBase
    {
        private readonly List<ActionsGraph> _documents;


        public AppDocumentsListInput()
            : base(InputNames.AppDocumentsListInput)
        {
            _documents = new List<ActionsGraph>();
        }

        public void RegisterMainGraph(ViewInfo viewInfo, ITreeViewControl treeView, PropertyGridView wpfPropertyGrid,
                                      CommandLineView commandLineView, LayerView layerView, IHelpView helpView,
                                      BooView booView)
        {
            ActionsGraph = CreateMainGraph(viewInfo, treeView, wpfPropertyGrid, commandLineView, layerView, helpView,
                                           booView);
        }

        public ActionsGraph AddNewChildGraph()
        {
            var childGraph = new ActionsGraph();
            childGraph.Register(new ParentActionGraphInput(ActionsGraph));
            _documents.Add(childGraph);
            return childGraph;
        }

        private ActionsGraph CreateMainGraph(ViewInfo viewInfo, ITreeViewControl treeView,
                                             PropertyGridView wpfPropertyGrid, CommandLineView commandLineView,
                                             LayerView layerView, IHelpView helpView, BooView booView)
        {
            var result = new ActionsGraph();
            ActionsGraph = result;
            result.Register(this);

            var defaultAppInputs = new DefaultAppInputs(ActionsGraph);
            defaultAppInputs.InitializeInputs(viewInfo, treeView, wpfPropertyGrid, commandLineView, layerView, helpView,
                                              booView);

            return result;
        }
    }
}