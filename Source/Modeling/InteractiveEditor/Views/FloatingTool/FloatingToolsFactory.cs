#region Usings

using System.Collections.Generic;
using InteractiveEditor.Views.Tools;
using Naro.Infrastructure.Interface;
using NaroBasicPipes.Inputs;
using NaroPipes.Actions;

#endregion

namespace InteractiveEditor.Views.FloatingTool
{
    internal class FloatingToolsFactory
    {
        private readonly SortedDictionary<string, FloatingToolBase> _tools =
            new SortedDictionary<string, FloatingToolBase>();

        public ViewInfo ViewInfo { get; private set; }

        public void Register(FloatingToolBase tool)
        {
            _tools[tool.Name] = tool;
        }

        public void UpdateViewInfo(ViewInfo viewInfo)
        {
            ViewInfo = viewInfo;
        }

        public void RegisterTools()
        {
            Register(new CutCopyPasteFloatingTool());
            Register(new PropertyGridFloatingTool());
            Register(new SketchFloatingTool());
            Register(new SolidFloatingTool());
            Register(new DimensionFloatingTool());
        }

        public void PopulateView(FloatingWindow window, SelectionContainer entity, ActionsGraph actionsGraph)
        {
            window.ClearTools();
            foreach (var tool in _tools.Values)
            {
                tool.ViewInfo = ViewInfo;
                if (!tool.AcceptEntity(entity))
                    continue;
                window.AddToolsVisualComponent(tool, entity, actionsGraph);
            }
        }
    }
}