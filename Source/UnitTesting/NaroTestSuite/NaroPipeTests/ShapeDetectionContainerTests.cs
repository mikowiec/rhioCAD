#region Usings

using System.Collections.Generic;
using Moq;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;

using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.NaroPipeTests
{
    [TestFixture]
    public class ShapeDetectionContainerTests
    {
        private Document _document;
        private NodeBuilder _lineBuilder;
        private ActionsGraph _actionsGraph;

        #region Setup/Teardown

        [SetUp]
        public void ConfigureTestEnvironment()
        {
            DefaultsSetup();
            _document = new Document();
            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
            _document.Transact();

            _lineBuilder = new NodeBuilder(_document, FunctionNames.Box);
            _lineBuilder[0].Axis3D = new Axis(new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1)));
            _lineBuilder[1].TransformedPoint3D = new Point3D(100, 100, 100);
            _lineBuilder[2].Real = -100;
            Assert.IsTrue(_lineBuilder.ExecuteFunction(), "Failed to create the test line");
        }

        [TearDown]
        public void TestModificationsCleanup()
        {
            _document = null;
        }

        private void DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            _actionsGraph = new ActionsGraph();
            _actionsGraph.Register(new FunctionFactoryInput());
            _actionsGraph.Register(new OptionsSetupInput());
            DefaultFunctions.Setup(_actionsGraph);
        }

        #endregion

        [Test]
        public void DetectShapeTest()
        {
            //var solidSelectedEntity = new SceneSelectedEntity(_testBoxBuilder.Node) { ShapeType = TopAbsShapeEnum.TopAbs_SOLID };
            //var mock = new Mock<GeomUtilsWrapper>();
            //var selectedShapes = new List<SceneSelectedEntity> { solidSelectedEntity };
            //mock.Setup(geomUtils =>
            //           GeomUtilsWrapper.IdentifySelectedNodes(_document.Root)).Returns(selectedShapes);

            //var selectionContainer = new SelectionContainer(mock.Object) { Document = _document };
            //selectionContainer.SwitchSelectionMode(TopAbsShapeEnum.TopAbs_SOLID);
            //selectionContainer.BuildSelections(new Mouse3DPosition(new Point3D(50, 0, 50), new gpAx1(), true, false,
            //                                                       false, 150, 150));
            //Assert.IsTrue(selectionContainer.Entities.Count == 1, "invalid number of solid detected shapes");
            //Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_SOLID].Count == 1,
            //              "invalid number of solid detected shapes");
            //Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_FACE].Count == 1,
            //              "invalid number of face detected shapes");
        }
    }
}
