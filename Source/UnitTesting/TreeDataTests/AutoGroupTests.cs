#region Usings
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class AutoGroupTests //: MetaActionsTestBase
    {
        [Test]
        public void GetSketchNodeTest()
        {
            var document = TestUtils.DefaultsSetup();
            document.Transact();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var line = TestUtils.Line(document, sketchNode, new Point3D(10, 10, 0), new Point3D(10, 0, 0));
            Assert.IsTrue(line.LastExecute);

            var sketchCreator2 = new SketchCreator(document, false);
            var sketchNode2 = sketchCreator2.BuildSketchNode();

            var circle = TestUtils.Circle(document, sketchNode2, new Point3D(0, 0, 0), 5);
            Assert.IsTrue(circle.ExecuteFunction());

            var sphereBuilder = new NodeBuilder(document, FunctionNames.Sphere);
            sphereBuilder[0].TransformedPoint3D = new Point3D(10,10,0);
            sphereBuilder[1].Real = 3;
            Assert.IsTrue(sphereBuilder.ExecuteFunction());

            var firstNode = new NodeBuilder(AutoGroupLogic.FindSketchNode(line.Node));
            Assert.AreEqual(firstNode.FunctionName, FunctionNames.Sketch);
            Assert.AreEqual(firstNode.ShapeName, "Sketch-1");

            var secondNode = new NodeBuilder(AutoGroupLogic.FindSketchNode(circle.Node));
            Assert.AreEqual(secondNode.FunctionName, FunctionNames.Sketch);
            Assert.AreEqual(secondNode.ShapeName, "Sketch-2");

            Assert.IsNull(AutoGroupLogic.FindSketchNode(sphereBuilder.Node));
        }
    }
}