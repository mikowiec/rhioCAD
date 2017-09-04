#region Usings
using NUnit.Framework;
using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Functions
{
    [TestFixture]
    public class MirrorFunctionTests
    {
        [Test]
        public void CreateAmirroredObjectAroundAPointAndVerifyCoordinates()
        {
            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = TestUtils.Point(document, sketchNode, new Point3D(10, 10, 0));
            Assert.IsTrue(pointBuilder.ExecuteFunction());

            var circle = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 5);
            Assert.IsTrue(circle.ExecuteFunction());

            var mirroredCircle = new NodeBuilder(document, FunctionNames.MirrorPoint);
            mirroredCircle[0].Reference = circle.Node;
            mirroredCircle[1].Reference = pointBuilder.Node;
            Assert.IsTrue(mirroredCircle.ExecuteFunction());

            Assert.AreEqual(document.Root.Children.Count, 7 );

            // mirror node - is removed by the MirrorActionCommon method
            var mirrornode = new NodeBuilder(document.Root[4]);
            Assert.AreEqual(mirrornode.FunctionName, FunctionNames.MirrorPoint);

            var newPoint = new NodeBuilder(document.Root[5]);
            Assert.AreEqual(newPoint.FunctionName, FunctionNames.Point);
            Assert.AreEqual(newPoint.ShapeName, "Point 3 (Copy)");

            var newCircle = new NodeBuilder(document.Root[6]);
            Assert.AreEqual(newCircle.FunctionName, FunctionNames.Circle);
            Assert.AreEqual(newCircle.ShapeName, "Circle 2 (Copy)");
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.X, 20);
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.Y, 20);
            Assert.AreEqual(newCircle[0].RefTransformedPoint3D.Z, 0);
            Assert.AreEqual(newCircle[1].Real, 5);
        }

        [Test]
        public void CreateAmirroredObjectAroundAnAxisAndVerifyCoordinates()
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
        }

        [Test]
        [Ignore("Mirror plane not fixed yet")]
        public void CreateAMirroredPointAroundAPlane()
        {
            var basePoint = new Point3D(5, 10, 10);
            var Point1 = new Point3D(10, 10, 10);
            var Point2 = new Point3D(10, 20, 10);
            var Point3 = new Point3D(10, 20, 20);
            var document = TestUtils.DefaultsSetup();

            document.Transact();
            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].TransformedPoint3D = basePoint;
            Assert.IsTrue(pointBuilder.ExecuteFunction());
            document.Commit("Point drawn");

            document.Transact();
            var rectangleBuilder = new NodeBuilder(document, FunctionNames.ThreePointsRectangle);
            rectangleBuilder[0].TransformedPoint3D = Point1;
            rectangleBuilder[1].TransformedPoint3D = Point2;
            rectangleBuilder[2].TransformedPoint3D = Point3;
            rectangleBuilder.ExecuteFunction();
            document.Commit("Rectangle drawn");

            document.Transact();
            //OCgp_Pln plane = ShapeUtils.ExtractPlaneFromFaceShape(rectangleBuilder.Shape);
            //OCTopoDS_Shape point = pointBuilder.Shape;
            //var mirrorShape = MirrorPlaneFunction.MakeEvolve(plane, point);
            //var mirrorVertex = TopoDS.Vertex(mirrorShape);
            //var extractedPoint = new Point3D(BRepTool.Pnt(mirrorVertex));
            //var mirroredExpectedResult = new Point3D(15, 10, 10);
            //document.Commit("Mirror done");
            //Assert.IsTrue(extractedPoint.IsEqual(mirroredExpectedResult), "Mirrored point has wrong coordinates");
        }

        [Test]
        [Ignore("Mirror plane not fixed yet")]
        public void CreateAMirroredSphereAroundAPlane()
        {
            var basePoint = new Point3D(5, 10, 10);
            var Point1 = new Point3D(10, 10, 10);
            var Point2 = new Point3D(10, 20, 10);
            var Point3 = new Point3D(10, 20, 20);
            var document = TestUtils.DefaultsSetup();

            document.Transact();
            var spereBuilder = new NodeBuilder(document, FunctionNames.Sphere);
            spereBuilder[0].TransformedPoint3D = basePoint;
            spereBuilder[1].Real = 3;
            Assert.IsTrue(spereBuilder.ExecuteFunction());
            document.Commit("Sphere drawn");

            document.Transact();
            var rectangleBuilder = new NodeBuilder(document, FunctionNames.ThreePointsRectangle);
            rectangleBuilder[0].TransformedPoint3D = Point1;
            rectangleBuilder[1].TransformedPoint3D = Point2;
            rectangleBuilder[2].TransformedPoint3D = Point3;
            rectangleBuilder.ExecuteFunction();
            document.Commit("Rectangle drawn");

            document.Transact();
            //OCgp_Pln plane = ShapeUtils.ExtractPlaneFromFaceShape(rectangleBuilder.Shape);
            //OCTopoDS_Shape sphere = spereBuilder.Shape;
            //var mirrorShape = MirrorPlaneFunction.MakeEvolve(plane, sphere);
            //var mirrorVertex = TopoDS.Vertex(mirrorShape);
            //var extractedPoint = new Point3D(BRepTool.Pnt(mirrorVertex));
            //var mirroredExpectedResult = new Point3D(15, 10, 10);
            //document.Commit("Mirror done");
            //Assert.IsTrue(extractedPoint.IsEqual(mirroredExpectedResult), "Mirrored point has wrong coordinates");
        }
    }
}