#region Usings

using MetaActionsInterface;
using Naro.PartModeling;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace SketchHinter
{
    public abstract class SketchBaseAction : DrawingLiveShape
    {
        protected Hinter2D Hinter2D;
        protected Document PreviewDocument;

        protected SketchBaseAction(string modifierName)
            : base(modifierName)
        {
            
        }

        //public override void OnActivate()
        public void SetupHinter(Node sketchNode)
        {
            base.OnActivate();
            PresetPreview();

            //var sketchNode = new SketchCreator(Document).CurrentSketch;

            var options = new SketchHinterOptions
                              {
                                  ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                                  PointRange = 3.0
                              };
            Hinter2D = new Hinter2D(sketchNode, Document, options);
        }

        private void PresetPreview()
        {
            PreviewDocument = new Document();
            var interpreter = PreviewDocument.Root.Get<DocumentContextInterpreter>();
            if (interpreter != null) return;
            interpreter = PreviewDocument.Root.Set<DocumentContextInterpreter>();
            var contextInterpreter = Document.Root.Get<DocumentContextInterpreter>();
            interpreter.Context = contextInterpreter.Context;
            PreviewDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
            interpreter.Document = PreviewDocument;
        }

        public override void OnDeactivate()
        {
            PreviewDocument.Revert();
            PreviewDocument = null;
            UpdateView();
            base.OnDeactivate();
        }
    }
}