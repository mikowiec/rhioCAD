#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;
using OccCode;

using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.GeomHelperTests
{
    [TestFixture]
    public class GeomHelperTests
    {
        #region Setup/Teardown

        [SetUp]
        public void SetupTest()
        {
            DefaultsSetup();

            _document = new Document();
            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
            _document.Root.Set<DocumentContextInterpreter>();
            var documentInput = new DocumentInput(_document);
            _actionsGraph.Register(documentInput);
            documentInput.OnConnect();
            _document =
                _actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();
            _sketchCreator = new SketchCreator(_document);
            _sketchCreator.BuildSketchNode();
            _document.Transact();
        }

        [TearDown]
        public void TestModificationsCleanup()
        {
            _document = null;
        }

        #endregion

        private void DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            _actionsGraph = new ActionsGraph();
            _actionsGraph.Register(new FunctionFactoryInput());
            _actionsGraph.Register(new OptionsSetupInput());
            DefaultFunctions.Setup(_actionsGraph);
        }

        private Document _document;
        private SketchCreator _sketchCreator;
        private ActionsGraph _actionsGraph;

        [Test]
        public void BuilderLineTrimTest()
        {
            var nodeBuilder1 = BuildLine(new Point3D(0, 0, 0), new Point3D(5, 5, 0));
            var nodeBuilder2 = BuildLine(new Point3D(2, 0, 0), new Point3D(2, 5, 0));

            var clickPoint = new Point3D(4, 4, 0);

            // Get some edges from Nodes
            var node2Edges = GeomUtils.ExtractEdges(nodeBuilder2.Shape);
            Assert.IsTrue(node2Edges.Count > 0, "invalid shape tested");
            var node1Edges = GeomUtils.ExtractEdges(nodeBuilder1.Shape);
            Assert.IsTrue(node1Edges.Count > 0, "invalid shape tested");

            // Make trimming using edges
            var trimmingEdges = new List<TopoDSEdge> {node2Edges[0]};
            var trimmedEdges = GeomUtils.TrimGenericShape(trimmingEdges, node1Edges[0], clickPoint);
            Assert.IsTrue(trimmedEdges != null, "Trimming solutions not found");
            var trimmedCurves = trimmedEdges.Select(edge => new BRepAdaptorCurve(edge)).ToList();

            var firstPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].FirstParameter));
            var lastPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].LastParameter));
            Assert.IsTrue(firstPoint.IsEqual(new Point3D(0, 0, 0)), "invalid trimming point");
            Assert.IsTrue(lastPoint.IsEqual(new Point3D(2, 2, 0)), "invalid trimming point");
        }

        private NodeBuilder BuildLine(Point3D point0, Point3D point1)
        {
            var builder = _sketchCreator.CreateBuilder(FunctionNames.LineTwoPoints);

            builder[0].Reference = GetPointNode(point0);
            builder[1].Reference = GetPointNode(point1);
            builder.ExecuteFunction();
            Assert.IsTrue(builder.LastExecute, "failed building the first line");
            return builder;
        }

        private Node GetPointNode(Point3D point)
        {
            return _sketchCreator.GetPoint(point).Node;
        }

        [Test]
        public void CircleMultiLineTrimTest()
        {
            var wireCircle =
                OccShapeCreatorCode.CreateWireCircle(new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1)), 2);
            var circleEdges = GeomUtils.ExtractEdges(wireCircle);
            var edge1 = new BRepBuilderAPIMakeEdge(new gpPnt(-3, 0, 0), new gpPnt(3, 0, 0)).Edge;
            var edge2 = new BRepBuilderAPIMakeEdge(new gpPnt(0, -3, 0), new gpPnt(0, 3, 0)).Edge;
            Assert.IsTrue(circleEdges.Count > 0, "invalid circle edges");
            var clickPoint = new Point3D(2, 0, 0);

            var trimmingEdges = new List<TopoDSEdge> {edge1, edge2};
            var trimmedEdges = GeomUtils.TrimGenericShape(trimmingEdges, circleEdges[0], clickPoint);
            Assert.IsTrue(trimmedEdges.Count == 1, "Incorrect number of trim solutions");
            var trimmedCurve = new BRepAdaptorCurve(trimmedEdges[0]);

            var firstPoint = new Point3D(trimmedCurve.Value(trimmedCurve.FirstParameter));
            var lastPoint = new Point3D(trimmedCurve.Value(trimmedCurve.LastParameter));
            Assert.IsTrue(firstPoint.IsEqual(new Point3D(0, 2, 0)), "invalid trimming point");
            Assert.IsTrue(lastPoint.IsEqual(new Point3D(2, 0, 0)), "invalid trimming point");
        }

        [Test]
        public void ExtractEdgesTest()
        {
            var firstPoint = new Point3D(100, 100, 100);
            var secondPoint = new Point3D(200, 200, 200);

            var testRectangleBuilder = new NodeBuilder(_document, FunctionNames.Rectangle);
            testRectangleBuilder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            testRectangleBuilder[1].TransformedPoint3D = new Point3D(secondPoint.GpPnt);
            testRectangleBuilder.ExecuteFunction();

            Assert.AreEqual(GeomUtils.ExtractEdges(testRectangleBuilder.Shape).Count, 4, "Invalid number of edges");
        }

        [Test]
        public void ExtractFacesTest()
        {
            var firstPoint = new Point3D(100, 100, 100);
            var secondPoint = new Point3D(200, 200, 200);

            var testRectangleBuilder = new NodeBuilder(_document, FunctionNames.Rectangle);
            testRectangleBuilder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            testRectangleBuilder[1].TransformedPoint3D = new Point3D(secondPoint.GpPnt);
            testRectangleBuilder.ExecuteFunction();

            Assert.AreEqual(GeomUtils.ExtractFaces(testRectangleBuilder.Shape).Count, 1, "Invalid number of faces");
        }

        [Test]
        public void ExtractShapeTypeTest()
        {
            var firstPoint = new Point3D(100, 100, 100);
            var secondPoint = new Point3D(200, 200, 200);

            var testRectangleBuilder = new NodeBuilder(_document, FunctionNames.Rectangle);
            testRectangleBuilder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            testRectangleBuilder[1].TransformedPoint3D = new Point3D(secondPoint.GpPnt);
            testRectangleBuilder.ExecuteFunction();

            Assert.AreNotEqual(
                GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_VERTEX, 1), null,
                "Invalid shape extracted");
            Assert.AreEqual(
                GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_VERTEX, 5), null,
                "Invalid shape extracted");
            Assert.AreNotEqual(
                GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_EDGE, 1), null,
                "Invalid shape extracted");
            Assert.AreEqual(GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_EDGE, 5),
                            null, "Invalid shape extracted");
            Assert.AreNotEqual(
                GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_WIRE, 1), null,
                "Invalid shape extracted");
            Assert.AreEqual(GeomUtils.ExtractShapeType(testRectangleBuilder.Shape, TopAbsShapeEnum.TopAbs_WIRE, 2),
                            null, "Invalid shape extracted");
        }

        [Test]
        public void ExtractVertexesTest()
        {
            var firstPoint = new Point3D(100, 100, 100);
            var secondPoint = new Point3D(200, 200, 200);

            var testRectangleBuilder = new NodeBuilder(_document, FunctionNames.Rectangle);
            testRectangleBuilder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            testRectangleBuilder[1].TransformedPoint3D = new Point3D(secondPoint.GpPnt);
            testRectangleBuilder.ExecuteFunction();

            Assert.AreEqual(GeomUtils.ExtractVertexes(testRectangleBuilder.Shape).Count, 4, "Invalid number of vertexes");
        }

        [Test]
        public void ExtractWiresTest()
        {
            var firstPoint = new Point3D(100, 100, 100);
            var secondPoint = new Point3D(200, 200, 200);

            var testRectangleBuilder = new NodeBuilder(_document, FunctionNames.Rectangle);
            testRectangleBuilder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            testRectangleBuilder[1].TransformedPoint3D = new Point3D(secondPoint.GpPnt);
            testRectangleBuilder.ExecuteFunction();

            Assert.AreEqual(GeomUtils.ExtractWires(testRectangleBuilder.Shape).Count, 1, "Invalid number of wires");
        }

        [Test]
        public void IntersectionPointTest()
        {
            var edge1 = new BRepBuilderAPIMakeEdge(new gpPnt(0, 0, 0), new gpPnt(5, 5, 0)).Edge;
            var edge2 = new BRepBuilderAPIMakeEdge(new gpPnt(2, 0, 0), new gpPnt(2, 5, 0)).Edge;

            var result = GeomUtils.IntersectionPoints(edge1, edge2);
            Assert.IsTrue(result.Count > 0, "invalid intersection");
            Assert.IsTrue(result[0].IsEqual(new Point3D(2, 2, 0)), "Invalid intersection solution");
        }

        [Test]
        public void LineTrimTest()
        {
            var edge1 = new BRepBuilderAPIMakeEdge(new gpPnt(1, 1, 0), new gpPnt(5, 5, 0)).Edge;
            var edge2 = new BRepBuilderAPIMakeEdge(new gpPnt(2, 0, 0), new gpPnt(2, 5, 0)).Edge;
            var clickPoint = new Point3D(4, 4, 0);

            var trimmingEdges = new List<TopoDSEdge> {edge2};
            var trimmedEdges = GeomUtils.TrimGenericShape(trimmingEdges, edge1, clickPoint);
            Assert.IsTrue(trimmedEdges != null, "Trimming solutions not found");
            var trimmedCurves = trimmedEdges.Select(edge => new BRepAdaptorCurve(edge)).ToList();

            var firstPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].FirstParameter));
            var lastPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].LastParameter));
            Assert.IsTrue(firstPoint.IsEqual(new Point3D(1, 1, 0)), "invalid trimming point");
            Assert.IsTrue(lastPoint.IsEqual(new Point3D(2, 2, 0)), "invalid trimming point");
        }

        [Test]
        public void MultiLineTrimTest()
        {
            var edge1 = new BRepBuilderAPIMakeEdge(new gpPnt(1, 1, 0), new gpPnt(5, 5, 0)).Edge;
            var edge2 = new BRepBuilderAPIMakeEdge(new gpPnt(2, 0, 0), new gpPnt(2, 5, 0)).Edge;
            var edge3 = new BRepBuilderAPIMakeEdge(new gpPnt(4, 0, 0), new gpPnt(4, 5, 0)).Edge;

            var clickPoint = new Point3D(3, 3, 0);

            var trimmingEdges = new List<TopoDSEdge> {edge2, edge3};
            var trimmedEdges = GeomUtils.TrimGenericShape(trimmingEdges, edge1, clickPoint);
            Assert.IsTrue(trimmedEdges != null, "Trimming solutions not found");
            var trimmedCurves = trimmedEdges.Select(edge => new BRepAdaptorCurve(edge)).ToList();

            var firstPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].FirstParameter));
            var lastPoint = new Point3D(trimmedCurves[0].Value(trimmedCurves[0].LastParameter));
            Assert.IsTrue(firstPoint.IsEqual(new Point3D(1, 1, 0)), "invalid trimming point");
            Assert.IsTrue(lastPoint.IsEqual(new Point3D(2, 2, 0)), "invalid trimming point");
            var thirdPoint = new Point3D(trimmedCurves[1].Value(trimmedCurves[1].FirstParameter));
            var fourthPoint = new Point3D(trimmedCurves[1].Value(trimmedCurves[1].LastParameter));
            Assert.IsTrue(thirdPoint.IsEqual(new Point3D(4, 4, 0)), "invalid trimming point");
            Assert.IsTrue(fourthPoint.IsEqual(new Point3D(5, 5, 0)), "invalid trimming point");
        }

        [Test]
        public void UParameterTest()
        {
            var edge = new BRepBuilderAPIMakeEdge(new gpPnt(1, 1, 0), new gpPnt(5, 5, 0)).Edge;
            var curve = new BRepAdaptorCurve(edge);

            var location = new TopLocLocation(GeomUtils.BuildTranslation(new Point3D(0, 0, 0), new Point3D(1, 1, 0)));
            Assert.IsTrue(
                Math.Abs(GeomUtils.UParameter(curve, location, new Point3D(1, 1, 0)).Value - curve.FirstParameter) <
                0.1, "invalid first parameter");
            Assert.IsTrue(
                Math.Abs(GeomUtils.UParameter(curve, location, new Point3D(5, 5, 0)).Value - curve.LastParameter) <
                0.1, "invalid last parameter");
        }
    }
}