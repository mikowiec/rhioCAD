#region Usings

using System;
using System.Collections.Generic;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;
using OccCode;
using PartModellingLogic.Modifiers.Shapes;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.TrimTests
{
    [TestFixture]
    public class TrimTests
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
        public void TrimLineTest()
        {
            var action = new TrimAction();

            var nodeBuilder1 = BuildLine(new Point3D(0, 0, 0), new Point3D(5, 5, 0));
            var nodeBuilder2 = BuildLine(new Point3D(2, 0, 0), new Point3D(2, 5, 0));

            var clickPoint = new Point3D(4, 4, 0);

            var trimmedEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(nodeBuilder1.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var trimmingEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(nodeBuilder2.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var newNodes = action.GetTrimResult(_document, trimmedEntities, clickPoint);

            Assert.AreEqual(newNodes.Count, 1);
            var nb = newNodes[0];
            Assert.AreEqual(nb.FunctionName, FunctionNames.LineTwoPoints);
            Assert.AreEqual(nb.Node.Children.Count, 2);

            var nodeBuilder = new NodeBuilder(nb.Node.Children[1].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.AreEqual(nodeBuilder[1].TransformedPoint3D.IsEqual(new Point3D(0, 0, 0)), true);

            nodeBuilder = new NodeBuilder(nb.Node.Children[2].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.AreEqual(nodeBuilder[1].TransformedPoint3D.IsEqual(new Point3D(2, 2, 0)), true);
        }

        [Test]
        public void TrimCircleTest()
        {
            var action = new TrimAction();

            var nodeBuilder1 = BuildLine(new Point3D(0, 0, 0), new Point3D(5, 5, 0));
            var builder = _sketchCreator.CreateBuilder(FunctionNames.Circle);

            builder[0].Reference = GetPointNode(new Point3D(2,2,0));
            builder[1].Real = 1;
            builder.ExecuteFunction();


            Assert.AreEqual(_document.Root.Children.Count,6);
            var clickPoint = new Point3D(2, 3, 0);

            var trimmedEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(builder.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var trimmingEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(nodeBuilder1.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var newNodes = action.GetTrimResult(_document, trimmedEntities, clickPoint);

            // the resulting arc has the end points on the line (x==y) and the distance between them is the diameter of the circle 

            Assert.AreEqual(newNodes.Count, 1);
            var nb = newNodes[0];
            Assert.AreEqual(nb.FunctionName, FunctionNames.Arc);
            Assert.AreEqual(nb.Node.Children.Count, 3);

            var nodeBuilder = new NodeBuilder(nb.Node.Children[1].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.AreEqual(nodeBuilder[1].TransformedPoint3D.IsEqual(new Point3D(2, 2, 0)), true);

            nodeBuilder = new NodeBuilder(nb.Node.Children[2].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(1.2928, 1.2928, 0)) < 0.001);

            nodeBuilder = new NodeBuilder(nb.Node.Children[3].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(2.7071, 2.7071, 0)) < 0.001);

            Assert.IsTrue((new Point3D(1.2928, 1.2928, 0)).Distance(new Point3D(2.7071, 2.7071, 0)) - 4 < 0.001 );
        }

        [Test]
        public void TrimArcCSETest()
        {
            var action = new TrimAction();

            var nodeBuilder1 = BuildLine(new Point3D(2, 0, 0), new Point3D(2, 5, 0));
            var builder = _sketchCreator.CreateBuilder(FunctionNames.Arc);

            builder[0].Reference = GetPointNode(new Point3D(2, 2, 0));
            builder[1].Reference = GetPointNode(new Point3D(1.2928, 1.2928, 0));
            builder[2].Reference = GetPointNode(new Point3D(2.7071, 2.7071, 0));
            builder.ExecuteFunction();


            Assert.AreEqual(_document.Root.Children.Count, 8);
            var clickPoint = new Point3D(3, 2, 0);

            var trimmedEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(builder.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var trimmingEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(nodeBuilder1.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var newNodes = action.GetTrimResult(_document, trimmedEntities, clickPoint);

            // the resulting arc has the end points on the line (x==y) and the distance between them is the diameter of the circle 

            Assert.AreEqual(newNodes.Count, 1);
            var nb = newNodes[0];
            Assert.AreEqual(nb.FunctionName, FunctionNames.Arc);
            Assert.AreEqual(nb.Node.Children.Count, 3);

            var nodeBuilder = new NodeBuilder(nb.Node.Children[1].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.AreEqual(nodeBuilder[1].TransformedPoint3D.IsEqual(new Point3D(2, 2, 0)), true);

            nodeBuilder = new NodeBuilder(nb.Node.Children[2].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(1.2928, 1.2928, 0)) < 0.001);

            nodeBuilder = new NodeBuilder(nb.Node.Children[3].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(2.0, 1.0, 0)) < 0.001);
        }

        [Test]
        public void TrimArcSERTest()
        {
            var action = new TrimAction();

            var nodeBuilder1 = BuildLine(new Point3D(2, 0, 0), new Point3D(2, 5, 0));
            var builder = _sketchCreator.CreateBuilder(FunctionNames.Arc3P);

            builder[0].Reference = GetPointNode(new Point3D(1.2928, 1.2928, 0));
            builder[1].Reference = GetPointNode(new Point3D(2.7071, 2.7071, 0));
            builder[2].Reference = GetPointNode(new Point3D(3, 2, 0));
            builder.ExecuteFunction();


            Assert.AreEqual(_document.Root.Children.Count, 8);
            var clickPoint = new Point3D(3, 2, 0);

            var trimmedEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(builder.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var trimmingEntities = new List<SceneSelectedEntity>
                                      {
                                          new SceneSelectedEntity(nodeBuilder1.Node)
                                              {ShapeType = TopAbsShapeEnum.TopAbs_WIRE}
                                      };

            var newNodes = action.GetTrimResult(_document, trimmedEntities, clickPoint);

            // the resulting arc has the end points on the line (x==y) and the distance between them is the diameter of the circle 

            Assert.AreEqual(newNodes.Count, 1);
            var nb = newNodes[0];
            Assert.AreEqual(nb.FunctionName, FunctionNames.Arc);
            Assert.AreEqual(nb.Node.Children.Count, 3);

            var nodeBuilder = new NodeBuilder(nb.Node.Children[1].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(2.0, 2.0, 0)) < 0.001);

            nodeBuilder = new NodeBuilder(nb.Node.Children[2].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(2.0, 1.0, 0)) < 0.001);

            nodeBuilder = new NodeBuilder(nb.Node.Children[3].Get<ReferenceInterpreter>().Node);
            Assert.AreEqual(nodeBuilder[1].Name, "Point3D");
            Assert.IsTrue(nodeBuilder[1].TransformedPoint3D.Distance(new Point3D(1.2928, 1.2928, 0)) < 0.001);
        }

        private NodeBuilder BuildLine(Point3D point0, Point3D point1)
        {
            var builder = _sketchCreator.CreateBuilder(FunctionNames.LineTwoPoints);

            builder[0].Reference = GetPointNode(point0);
            builder[1].Reference = GetPointNode(point1);
            builder.ExecuteFunction();
            Assert.IsTrue(builder.LastExecute, "failed building the line");
            return builder;
        }

        private Node GetPointNode(Point3D point)
        {
            return _sketchCreator.GetPoint(point).Node;
        }
    }
}