#region Usings

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NaroConstants.Names;
using NaroSketchAdapter;
using NaroSketchAdapter.Views;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using SketchHinter.Algorithms;
using SketchHinter.Algorithms.Line;
using SketchHinter.Algorithms.LineOnLine;
using SketchHinter.Algorithms.PointOnLine;
using SketchHinter.Primitives;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace SketchHinter
{
    public class Hinter2D
    {
        private readonly Document _document;
        private readonly SketchHinterOptions _options;
        private readonly Node _sketchNode;
        private readonly Dictionary<string, string> _textureMapper;
        private List<SketchHinterAlgorithmBase> _algorithms;
        private ConstraintDocumentHelper _constraintMapper;

        private Sketch3DTo2DTranslator _coordinateTranslator;
        private SortedDictionary<string, HinterShapeCreatorBase> _hinterShapeCreators;

        public Hinter2D(Node sketchNode, Document document, SketchHinterOptions options)
        {
            _sketchNode = sketchNode;
            _document = document;
            _options = options;
            _textureMapper = new Dictionary<string, string>();

            MapTextures();
            InitializeFields();
        }

        public SortedDictionary<int, HinterShapeBase> HinterShapes { get; private set; }

        public Document Document
        {
            get { return _document; }
        }

        public Node SketchNode
        {
            get { return _sketchNode; }
        }

        private void MapTextures()
        {
            //MapTexture(Constraint2DNames.ParallelFunction, "horizontal_constraint");
            //MapTexture(Constraint2DNames.PerpendicularFunction, "perpendicular_constraint");
        }

        private void MapTexture(string function, string textureName)
        {
            _textureMapper[function] = @"Pics\" + textureName + ".bmp";
        }

        private void InitializeFields()
        {
            _hinterShapeCreators = new SortedDictionary<string, HinterShapeCreatorBase>();
            HinterShapes = new SortedDictionary<int, HinterShapeBase>();
            _algorithms = new List<SketchHinterAlgorithmBase>();
            var nodeBuilder = new NodeBuilder(_sketchNode);
            _coordinateTranslator = new Sketch3DTo2DTranslator(nodeBuilder[0].Axis3D);

            _constraintMapper = new ConstraintDocumentHelper(_document, _sketchNode);

            Register(FunctionNames.LineTwoPoints, new LineHinterCreatorShape());
            Register(FunctionNames.Point, new PointHinterCreatorShape());
            Populate();

            AddAlgorithm<LineHorizontalAlgorithm>();
            AddAlgorithm<LineVerticalAlgorithm>();
            AddAlgorithm<LineParallelAlgorithm>();
            AddAlgorithm<LinePerpendicularAlgorithm>();
            AddAlgorithm<PointOnLineAlgorithm>();
        }

        private void AddAlgorithm<T>() where T : SketchHinterAlgorithmBase, new()
        {
            var algoInstance = new T();
            AddAlgorithm(algoInstance);
        }

        private void AddAlgorithm(SketchHinterAlgorithmBase algorithm)
        {
            _algorithms.Add(algorithm);
            algorithm.Setup(_coordinateTranslator, _options, _constraintMapper, this);
            algorithm.OnRegister();
        }

        private void Register(string functionName, HinterShapeCreatorBase hinterShapeCreator)
        {
            _hinterShapeCreators[functionName] = hinterShapeCreator;
        }

        public void Populate()
        {
            _document.Root.Get<DocumentContextInterpreter>().ShapesGraph.Update();
            var sketchNode = new List<int> {_sketchNode.Index};
             var dci =  _document.Root.Get<DocumentContextInterpreter>();
            var shapeGraph = dci.ShapesGraph;

            var relatedShapes = GetRelatedNodes(sketchNode, shapeGraph);

            foreach (var index in relatedShapes)//_document.Root.ChildrenList)
            {
                var node = _document.Root[index];
                if (node.Get<FunctionInterpreter>() == null)
                    continue;
                var builder = new NodeBuilder(node);
                var shape = GetHinterShape(builder);
                if (shape != null)
                    HinterShapes[builder.Node.Index] = shape;
            }
            foreach (var algorithm in _algorithms)
            {
                algorithm.OnPopulate();
            }
        }

        private static IEnumerable<int> GetReferrencedByNodes(IEnumerable<int> shapeNodes, ShapeGraph shapeGraph)
        {
            var fromMap = new List<int>();
            foreach (var sourceNode in shapeNodes)
            {
                List<int> value;
                if (!shapeGraph.ReferrencedBy.TryGetValue(sourceNode, out value)) continue;
                fromMap.AddRange(value);
            }
            return fromMap;
        }

        private List<int> GetRelatedNodes(IEnumerable<int> shapeList, ShapeGraph shapeGraph)
        {
            var relatedNodes = new List<int>();
            var referingNodes = new List<int>();
            var nextLevel = new List<int>();
            var processed = new List<int>();

            referingNodes.AddRange(GetReferrencedByNodes(shapeList, shapeGraph));
            nextLevel.AddRange(referingNodes);

            while (nextLevel.Count > 0 && !nextLevel.Contains(0))
            {
                foreach (var node in nextLevel)
                {
                    if (!relatedNodes.Contains(node) && !shapeList.Contains(node))
                        relatedNodes.Add(node);
                }

                referingNodes.Clear();
                referingNodes.AddRange(GetReferrencedByNodes(nextLevel, shapeGraph).Where(p => p > 0));

                nextLevel.Clear();
                nextLevel.AddRange(referingNodes.Distinct());

                nextLevel.RemoveAll(processed.Contains);
                processed.AddRange(nextLevel);
            }
            return relatedNodes;
        }

        private HinterShapeBase GetHinterShape(NodeBuilder builder)
        {
            HinterShapeCreatorBase creator;
            HinterShapeBase shape = null;
            if (_hinterShapeCreators.TryGetValue(builder.FunctionName, out creator)) shape = creator.Create(builder);
            return shape;
        }

        public List<SketchHinterAlgorithmBase> ApplyAlgorithms(NodeBuilder builder)
        {
            var result = new List<SketchHinterAlgorithmBase>();
            var hinterShape = GetHinterShape(builder);

            foreach (var algorithm in _algorithms)
            {
                algorithm.constraintNodes.Clear();
                if (algorithm.Apply(hinterShape))
                    result.Add(algorithm);
            }
            return result;
        }

        public void SetOrigin(Point3D point3D)
        {
            _constraintMapper.SetOrigin(point3D);
        }

        public void Preview(Document previewDocument)
        {
            var graph = _document.Root.Get<DocumentContextInterpreter>().ShapesGraph;
            graph.Update();
            previewDocument.Transact();
            foreach (var shape in HinterShapes)
            {
                var node = shape.Value.Builder.Node;
                var referencesList = graph.GetReferredByNodes(node);
                FindKnownItems(referencesList);
                if (referencesList.Count == 0)
                    continue;
                PreviewConstraints(previewDocument, shape, referencesList, 2);
            }
        }

        private void PreviewConstraints(Document previewDocument, KeyValuePair<int, HinterShapeBase> shape,
                                        List<Node> referencesList, double rectangleSize)
        {
            var size = shape.Value.Size;
            var count = referencesList.Count;
            var midPoint = new Point3D(size.MiddleX, size.MiddleY, 0);
            var startPoint = new Point3D(size.MiddleX - rectangleSize*count/2.0, midPoint.Y - rectangleSize/2, 0);
            startPoint = startPoint.AddCoordinate(new Point3D(0, -rectangleSize*1.5, 0));
            var i = 0;
            foreach (var node in referencesList)
            {
                var builder = new NodeBuilder(node);
                var texture = _textureMapper[builder.FunctionName];
                var topLeftPoint = startPoint.AddCoordinate(new Point3D(rectangleSize*i*1.5, 0, 0));

                BuildPreviewRectangle(previewDocument, topLeftPoint, texture, rectangleSize, 0.3);
                i++;
            }
        }

        private static void BuildPreviewRectangle(Document previewDocument, Point3D topLeftPoint, string textureName,
                                                  double rectangleSize, double transparency)
        {
            var rectangle = new NodeBuilder(previewDocument, FunctionNames.ThreePointsRectangle);
            rectangle[0].TransformedPoint3D = topLeftPoint;
            rectangle[1].TransformedPoint3D = topLeftPoint.AddCoordinate(new Point3D(rectangleSize, 0, 0));
            rectangle[2].TransformedPoint3D = topLeftPoint.AddCoordinate(new Point3D(rectangleSize, rectangleSize, 0));
            rectangle.Visibility = ObjectVisibility.Hidden;
            rectangle.ExecuteFunction();

            var textureBuilder = new NodeBuilder(previewDocument, FunctionNames.TexturedShape);
            textureBuilder[0].Reference = rectangle.Node;
            textureBuilder[1].Text = textureName;
            textureBuilder.Transparency = transparency;
            textureBuilder.ExecuteFunction();
        }

        private void FindKnownItems(List<Node> referencesList)
        {
            var constraintList = new List<Node>();
            foreach (var node in referencesList)
            {
                var builder = new NodeBuilder(node);
                if (_textureMapper.ContainsKey(builder.FunctionName))
                    constraintList.Add(node);
            }
            referencesList.Clear();
            referencesList.AddRange(constraintList);
        }
    }
}