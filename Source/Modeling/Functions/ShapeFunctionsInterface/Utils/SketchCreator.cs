#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public class SketchCreator
    {
        private readonly Document _document;

        public SketchCreator(Document document)
        {
            AutoCreateSketch = true;
            _document = document;
        }

        public SketchCreator(Document document, bool autoCreateSketch)
        {
            AutoCreateSketch = autoCreateSketch;
            _document = document;
        }

        public bool AutoCreateSketch { get; private set; }
        public Node CurrentSketch
        {
            get
            {
                var root = _document.Root;
                var activeSketch = root.Get<DocumentContextInterpreter>().ActiveSketch;
                if (AutoCreateSketch && activeSketch == -1)
                    return BuildSketchNode();
                return activeSketch == -1 ? null : root[activeSketch];
            }
        }

        public Axis? NormalOnSketch
        {
            get
            {
                var sketchNode = CurrentSketch;
                if (sketchNode == null)
                    return null;
                var nodeBuilder = new NodeBuilder(sketchNode);
                return nodeBuilder[0].Axis3D;
            }
        }

        private DocumentPointLinker _pointLinker;

        public DocumentPointLinker PointLinker
        {
            get { return _pointLinker ?? (_pointLinker = new DocumentPointLinker(_document, CurrentSketch)); }
        }

        public NodeBuilder GetPoint(Point3D coordinate)
        {
            return PointLinker.GetPoint(coordinate);
        }

        public Node BuildSketchNode()
        {
            _document.Transact();

            var nodeBuilder = new NodeBuilder(_document, FunctionNames.Sketch);
            nodeBuilder[0].Axis3D = new Axis(new Point3D(0, 0, 0), new Point3D(0, 0, 1));
            Ensure.IsTrue(nodeBuilder.ExecuteFunction());
            _document.Root.Get<DocumentContextInterpreter>().ActiveSketch = nodeBuilder.Node.Index;
            _document.Commit("Draw sketch");

            return nodeBuilder.Node;
        }

        public Point3D? Project(Point3D point)
        {
            var normalOnSketch = NormalOnSketch;
            if (normalOnSketch == null)
                return null;
            var normalTransformation = CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            var transformedNormal = normalOnSketch.Value.GpAxis.Transformed(normalTransformation);
            var sketchPlane = new gpPln(transformedNormal.Location, transformedNormal.Direction);
            var projectedPoint = GeomUtils.ProjectPointOnPlane(point.GpPnt, sketchPlane, Precision.Confusion);
            return new Point3D(projectedPoint);
        }

        public NodeBuilder CreateBuilder(string functionName)
        {
            return new NodeBuilder(_document, functionName);
        }
    }
}