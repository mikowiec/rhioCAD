#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Precision;
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
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.NodeBuilderUtilsTests
{
    [TestFixture]
    public class NodeBuilderUtilsTests
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
        public void GetArcAnglesTest()
        {
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Transact();

            var arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 3, 0), new Point3D(8, 3, 0),
                                           new Point3D(4, 7, 0));

            Assert.AreEqual(NodeBuilderUtils.GetStartAngle(arcBuilder), 0);
            Assert.AreEqual(NodeBuilderUtils.GetEndAngle(arcBuilder), 90);
            Assert.AreEqual(NodeBuilderUtils.GetInternalAngle(arcBuilder), 90);

            // s >0, e > 0, s < e
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                           new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) - 30) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) - 150) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");

            // s >0, e > 0, s > e
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, 2, 0), new Point3D(7.464101, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) - 150) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) - 30) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");

            // s < 0, e < 0, s > e
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0),
                                           new Point3D(0.535898, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) + 30) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) + 150) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");

            // s < 0, e < 0, s < e
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, -2, 0), new Point3D(7.464101, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) + 150) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) + 30) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");

            // s > 0, e < 0 
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                           new Point3D(7.464101, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) - 30) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) + 30) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 300) < 0.00001, "Incorrect internal angle");

            // s < 0, e > 0
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0), new Point3D(7.464101, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) + 30) < 0.00001, "Incorrect start angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) - 30) < 0.00001, "Incorrect end angle");
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 60) < 0.00001, "Incorrect internal angle");
        }

        [Test]
        public void SetArcInternalAngleBothPositiveTest()
        {
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Transact();

            // s >0, e > 0, s > e
            var arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, 2, 0),
                                           new Point3D(7.464101, 2, 0));
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            var endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 4) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, 2, 0),
                                           new Point3D(7.464101, 2, 0));
            
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 180);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, 4, 0),
                                          new Point3D(7.464101, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 300) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            // s >0, e > 0, s < e

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0), new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 4) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0), new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 180);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, 4, 0), new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 60) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);
        }

        [Test]
        public void SetArcInternalAngleBothNegativeTest()
        {
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Transact();

            // s < 0, e < 0, s > e
            var arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0), 
                                new Point3D(0.535898, -2, 0));
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            var endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 180);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0),
                                new Point3D(0.535898, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 4) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0),
                                new Point3D(0.535898, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0),
                               new Point3D(0.535898, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 300) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            // s < 0, e < 0, s < e

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, -2, 0), new Point3D(7.464101, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 4) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(0.535898, -2, 0), new Point3D(7.464101, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 120) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 180);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0), new Point3D(7.464101, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 60) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);
        }

        [Test]
        public void SetArcInternalAngleOneNegativeOnePositiveTest()
        {
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Transact();

            // s > 0, e < 0
            var arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                new Point3D(4, -4, 0));
            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            var endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 180);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                new Point3D(4, -4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                new Point3D(4, -4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 240) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 120);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            // s < 0, e > 0

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0), new Point3D(4, 4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 180) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 120);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0), new Point3D(4, 4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 180) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 240);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y - 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0), new Point3D(4, 4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 180) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 60);

            Assert.IsTrue(Math.Abs(endPoint.X - 7.464101) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);

            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(4, -4, 0), new Point3D(4, 4, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetInternalAngle(arcBuilder) - 180) < 0.00001, "Incorrect internal angle");
            endPoint = NodeBuilderUtils.SetInternalAngle(arcBuilder, 300);

            Assert.IsTrue(Math.Abs(endPoint.X - 0.535898) < 0.00001);
            Assert.IsTrue(Math.Abs(endPoint.Y + 2) < 0.00001);
        }

        [Test]
        public void SetArcAnglesTest()
        {
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Transact();

            // set start angle value, s > 0
            var arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                           new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) - 30) < 0.00001, "Incorrect start angle");
            var newPoint = NodeBuilderUtils.PositionForAngle(arcBuilder, arcBuilder[0].RefTransformedPoint3D,
                                                             arcBuilder[1].RefTransformedPoint3D, 90);
            Assert.IsTrue(Math.Abs(newPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(newPoint.Y - 4) < 0.00001);

            // set end angle value, e > 0
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                           new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) - 150) < 0.00001, "Incorrect start angle");
            newPoint = NodeBuilderUtils.PositionForAngle(arcBuilder, arcBuilder[0].RefTransformedPoint3D,
                                                             arcBuilder[2].RefTransformedPoint3D, 90);
            Assert.IsTrue(Math.Abs(newPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(newPoint.Y - 4) < 0.00001);

            // set start angle value, s < 0
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, -2, 0),
                                           new Point3D(0.535898, 2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetStartAngle(arcBuilder) + 30) < 0.00001, "Incorrect start angle");
            newPoint = NodeBuilderUtils.PositionForAngle(arcBuilder, arcBuilder[0].RefTransformedPoint3D,
                                                             arcBuilder[1].RefTransformedPoint3D, -90);
            Assert.IsTrue(Math.Abs(newPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(newPoint.Y + 4) < 0.00001);

            // set end angle value, e < 0
            arcBuilder = TestUtils.Arc(_document, sketchNode, new Point3D(4, 0, 0), new Point3D(7.464101, 2, 0),
                                           new Point3D(0.535898, -2, 0));

            Assert.IsTrue(Math.Abs(NodeBuilderUtils.GetEndAngle(arcBuilder) + 150) < 0.00001, "Incorrect start angle");
            newPoint = NodeBuilderUtils.PositionForAngle(arcBuilder, arcBuilder[0].RefTransformedPoint3D,
                                                             arcBuilder[2].RefTransformedPoint3D, -90);
            Assert.IsTrue(Math.Abs(newPoint.X - 4) < 0.00001);
            Assert.IsTrue(Math.Abs(newPoint.Y + 4) < 0.00001);
        }

    }
}