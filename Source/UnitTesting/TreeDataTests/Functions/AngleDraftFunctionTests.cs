#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NUnit.Framework;
using OccCode;

using ShapeFunctions.Functions.Naro.Tools;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Precision;

#endregion

namespace TreeDataTests.Functions
{
    [TestFixture]
    public class AngleDraftFunctionTests
    {
        private Document _document;
        private NodeBuilder _testBoxBuilder;
        private SceneSelectedEntity _boxRightFace;
        private SceneSelectedEntity _boxBottomFace;

        [TestFixtureSetUp]
        public void ConfigureTestEnvironment()
        {
            _document = TestUtils.DefaultsSetup();
            _document.Root.Set<DocumentContextInterpreter>();

            _testBoxBuilder = new NodeBuilder(_document, FunctionNames.Box1P);
            _testBoxBuilder[0].TransformedPoint3D = new Point3D(0, 0, 0);
            _testBoxBuilder[1].Real = 10;
            _testBoxBuilder[2].Real = 10;
            _testBoxBuilder[3].Real = 10;
            Assert.IsTrue(_testBoxBuilder.ExecuteFunction(), "Failed to create the test box");

            _boxRightFace = new SceneSelectedEntity(_testBoxBuilder.Node)
                                {
                                    ShapeCount = 1,
                                    ShapeType = TopAbsShapeEnum.TopAbs_FACE
                                };

            _boxBottomFace = new SceneSelectedEntity(_testBoxBuilder.Node)
                                 {
                                     ShapeCount = 6,
                                     ShapeType = TopAbsShapeEnum.TopAbs_FACE
                                 };
        }

        [Test]
        public void AngleDraftFunctionTest()
        {
            var angleDraftBuilder = new NodeBuilder(_document, FunctionNames.AngleDraft);
            Assert.IsTrue(angleDraftBuilder.Count == 4, "Invalid number of dependencies");

            angleDraftBuilder[0].ReferenceData = _boxRightFace;
            angleDraftBuilder[1].ReferenceData = _boxBottomFace;
            angleDraftBuilder[2].Axis3D = new Axis(new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 0, 1)));
            angleDraftBuilder[3].Real = 10;

            Assert.IsTrue(angleDraftBuilder.ExecuteFunction(), "Angle draft execution failed");
        }

        [Test]
        public void BuildFaceDraftExecutionTest()
        {
            var box = _testBoxBuilder.Shape;
            var draft = new BRepOffsetAPIDraftAngle(box);
            var basePlane = new gpPln(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
            Assert.IsTrue(AngleDraftFunction.BuildFaceDraft(draft,
                                                            TopoDS.Face(_boxRightFace.TargetShape()),
                                                            new gpDir(0, 0, 1), 10, basePlane),
                          "BuildFaceDraft failed");
        }

        [Test]
        public void VerifyTestData()
        {
            var originPoint = new Point3D(0, 0, 0);
            var topPoint = new Point3D(0, 10, 10);
            var rightFacePlane = GeomUtils.ExtractPlane(_boxRightFace.TargetShape());
            Assert.IsTrue(rightFacePlane.Distance(originPoint.GpPnt) - 10 < Precision.Confusion, "Invalid face");
            Assert.IsTrue(rightFacePlane.Distance(topPoint.GpPnt) - 10 < Precision.Confusion, "Invalid face");

            var topPoint2 = new Point3D(0, 0, 10);
            var topPoint1 = new Point3D(10, 10, 10);
            var bottomFacePlane = GeomUtils.ExtractPlane(_boxBottomFace.TargetShape());
            Assert.IsTrue(10 - bottomFacePlane.Distance(topPoint2.GpPnt) > Precision.Confusion, "Invalid face");
            Assert.IsTrue(10 - bottomFacePlane.Distance(topPoint1.GpPnt) > Precision.Confusion, "Invalid face");
        }
    }
}