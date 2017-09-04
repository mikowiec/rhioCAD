#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroRedo : DocumentActionBase
    {
        private AISInteractiveContext _context;

        public NaroRedo() : base(ModifierNames.Redo)
        {
            DependsOn(InputNames.Context, OnContext);
        }

        private void OnContext(DataPackage data)
        {
            _context = data.Get<AISInteractiveContext>();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            // Close all loacal contexts to draw on the Neutral Point
            _context.CloseAllContexts(false);

            Document.Redo();
            var activeSketch = Document.Root.Get<DocumentContextInterpreter>().ActiveSketch;
            if (activeSketch == -1)
            {
                NodeUtils.RebuildDocumentFaces(Document);
            }
            var solidsNodes = NodeUtils.GetSolidsNodes(Document);
            foreach (var node in solidsNodes)
            {
                var nb = new NodeBuilder(node);
                nb.ExecuteFunction();
            }
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }
    }
}