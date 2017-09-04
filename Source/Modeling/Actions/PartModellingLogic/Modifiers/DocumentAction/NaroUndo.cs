#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using NaroCppCore.Occ.AIS;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroUndo : DocumentActionBase
    {
        private AISInteractiveContext _context;

        public NaroUndo() : base(ModifierNames.Undo)
        {
            DependsOn(InputNames.Context);
        }

        protected override void OnReceiveInputData(string inputName, DataPackage data)
        {
            base.OnReceiveInputData(inputName, data);

            switch (inputName)
            {
                case InputNames.Context:
                    _context = data.Get<AISInteractiveContext>();
                    break;
            }
        }

        public override void OnActivate()
        {
            // Close all local contexts to draw on the Neutral Point
            _context.CloseAllContexts(false);
            Document.Undo();
            var activeSketch = Document.Root.Get<DocumentContextInterpreter>().ActiveSketch;
            if (activeSketch == -1)
            {
                NodeUtils.RebuildDocumentFaces(Document);
            }
            var solidsNodes = NodeUtils.GetSolidsNodes(Document);
            foreach(var node in solidsNodes)
            {
                var nb = new NodeBuilder(node);
                nb.ExecuteFunction();
            }
            var visibleNodes = NodeUtils.GetVisibleSketchNodes(Document);
            foreach (var node in visibleNodes)
            {
                var nb = new NodeBuilder(node);
                nb.Visibility = ObjectVisibility.ToBeDisplayed;
                nb.ExecuteFunction();
            }

            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }
    }
}