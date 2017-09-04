#region Usings
using NaroConstants.Names;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class DeleteMirrorBaseShapeTests
    {
        [Test]
        public void TestDelete()
        {
            var document = TestUtils.DefaultsSetup();
            document.Transact();
           
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var line = TestUtils.Line(document, sketchNode, new Point3D(10, 10, 0), new Point3D(10, 0, 0));
            Assert.IsTrue(line.ExecuteFunction());

            var circle = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 5);
            Assert.IsTrue(circle.ExecuteFunction());

            var mirroredCircle = new NodeBuilder(document, FunctionNames.MirrorLine);
            mirroredCircle[0].Reference = circle.Node;
            mirroredCircle[1].Reference = line.Node;
            Assert.IsTrue(mirroredCircle.ExecuteFunction());

            Assert.AreEqual(document.Root.Children.Count, 9);

            // mirror node - is removed by the MirrorActionCommon method
            var mirrornode = new NodeBuilder(document.Root[6]);
            Assert.AreEqual(mirrornode.FunctionName, FunctionNames.MirrorLine);

            var newPoint = new NodeBuilder(document.Root[7]);
            Assert.AreEqual(newPoint.FunctionName, FunctionNames.Point);
            Assert.AreEqual(newPoint.ShapeName, "Point 4 (Copy)");

            var newCircle = new NodeBuilder(document.Root[8]);
            Assert.AreEqual(newCircle.FunctionName, FunctionNames.Circle);
            Assert.AreEqual(newCircle.ShapeName, "Circle 2 (Copy)");
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.X, 20);
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.Y, 0);
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.Z, 0);
            Assert.AreEqual(newCircle[1].Real, 5);

            document.Root.Remove(circle.Node.Index);
            Assert.AreEqual(document.Root.Children.Count, 8);
        }
    }
}