#region Usings

using System.Collections.Generic;
using Moq;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;
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
    public class SelectionContainerTests
    {
        #region Setup/Teardown

        [SetUp]
        public void ConfigureTestEnvironment()
        {
            DefaultsSetup();
            _document = new Document();
            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
            _document.Transact();

            _testBoxBuilder = new NodeBuilder(_document, FunctionNames.Box);
            _testBoxBuilder[0].Axis3D = new Axis(new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1)));
            _testBoxBuilder[1].TransformedPoint3D = new Point3D(100, 100, 100);
            _testBoxBuilder[2].Real = -100;
            Assert.IsTrue(_testBoxBuilder.ExecuteFunction(), "Failed to create the test box");
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
        private NodeBuilder _testBoxBuilder;
        private ActionsGraph _actionsGraph;

      /*
        //[Test]
        //public void BuildSelectionsSolidSelectionNoShiftTest()
        //{
        //    var solidSelectedEntity = new SceneSelectedEntity(_testBoxBuilder.Node)
        //                                  {ShapeType = TopAbsShapeEnum.TopAbs_SOLID};
        //    var mock = new Mock<GeomUtilsWrapper>();
        //    var selectedShapes = new List<SceneSelectedEntity> {solidSelectedEntity};
        //    mock.Setup(geomUtils =>
        //               GeomUtilsWrapper.IdentifySelectedNodes(_document.Root)).Returns(selectedShapes);

        //    var selectionContainer = new SelectionContainer(mock.Object) {Document = _document};
        //    selectionContainer.SwitchSelectionMode(TopAbsShapeEnum.TopAbs_SOLID);
        //    selectionContainer.BuildSelections(new Mouse3DPosition(new Point3D(50, 0, 50), new gpAx1(), true, false,
        //                                                           false, 150, 150));
        //    Assert.IsTrue(selectionContainer.Entities.Count == 1, "invalid number of solid detected shapes");
        //    Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_SOLID].Count == 1,
        //                  "invalid number of solid detected shapes");
        //    Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_FACE].Count == 1,
        //                  "invalid number of face detected shapes");
        }*/

        [Test]
        public void SelectionContainerInitTest()
        {
            var geomUtils = new GeomUtilsWrapper();
            var selectionContainer = new SelectionContainer(geomUtils);
            Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_VERTEX] != null,
                          "selection container vertex list not initialized properly");
            Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_EDGE] != null,
                          "selection container edge list not initialized properly");
            Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_FACE] != null,
                          "selection container face list not initialized properly");
            Assert.IsTrue(selectionContainer[TopAbsShapeEnum.TopAbs_SOLID] != null,
                          "selection container solid list not initialized properly");
        }

        [Test]
        public void SwitchSelectionModeTest()
        {
            var geomUtils = new GeomUtilsWrapper();
            var selectionContainer = new SelectionContainer(geomUtils);
            selectionContainer.SwitchSelectionMode(TopAbsShapeEnum.TopAbs_FACE);
            Assert.IsTrue(selectionContainer.CurrentSelectionMode == TopAbsShapeEnum.TopAbs_FACE,
                          "switch selection mode not working");
        }
    }
}