#region Usings
using System;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Enums;
using SketchHinter;
using NaroConstants.Names;
using NUnit.Framework;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class DeleteNodeTests
    {
        [Test]
        public void DeleteCircleTest()
        {
            var document = TestUtils.DefaultsSetup();

                  document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D();
            pointBuilder.ExecuteFunction();
            var circleBuilder = new NodeBuilder(document, FunctionNames.Circle);
            circleBuilder[0].Reference = pointBuilder.Node;
            circleBuilder[1].Real = 20;
            circleBuilder.ExecuteFunction();
            //document.Commit("Draw first circle");
            var nodeToDelete = document.Root[2];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            Assert.AreEqual(1, document.Root.Children.Count, "Circle is not deleted");
            Assert.AreEqual(FunctionNames.Sketch, document.Root[0].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name);
        }

        [Test]
        public void DeleteLineTest()
        {
            var document = TestUtils.DefaultsSetup();

            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D();
            var pointBuilder2 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder2[0].Reference = sketchNode;
            pointBuilder2[1].TransformedPoint3D = new Point3D(1,1,0);
            pointBuilder.ExecuteFunction();
            var lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = pointBuilder.Node;
            lineBuilder[1].Reference = pointBuilder2.Node;
            lineBuilder.ExecuteFunction();

            var nodeToDelete = document.Root[3];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            Assert.AreEqual(1, document.Root.Children.Count, "Line is not deleted");
            Assert.AreEqual(FunctionNames.Sketch, document.Root[0].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name);
        }

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void ParallelLinesDeleteLineTest()
        {
            var document = TestUtils.DefaultsSetup();
            
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            
            TestUtils.Line(document, sketchNode, new Point3D(0, 0, 0), new Point3D(1, 1, 0));

            var lineBuilder2 = TestUtils.Line(document, sketchNode, new Point3D(0, 1, 0), new Point3D(1, 2, 0));
            document.Commit("Drawn line");
            document.Transact();
            var options = new SketchHinterOptions
            {
                ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                PointRange = 3.0
            };
            var sketchHinter = new Hinter2D(sketchNode, document, options);
            sketchHinter.Populate();

            sketchHinter.ApplyAlgorithms(lineBuilder2);
            document.Commit("Parallel constraint added");
            document.Transact();
            Assert.AreEqual(document.Root.Children.Count, 8);
            Assert.AreEqual(document.Root[7].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name, Constraint2DNames.ParallelFunction);
        
            var nodeToDelete = document.Root[3];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            Assert.AreEqual(4, document.Root.Children.Count, "Line is not deleted");
        }

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void PerpendicularDeleteLineTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sh = new ShapeGraph();
            sh.SetDocument(document);

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D(4,1,0);
            var pointBuilder2 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder2[0].Reference = sketchNode;
            pointBuilder2[1].TransformedPoint3D = new Point3D(2, 3, 0);
            pointBuilder.ExecuteFunction();
            var lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = pointBuilder.Node;
            lineBuilder[1].Reference = pointBuilder2.Node;
            lineBuilder.ExecuteFunction();

            var pointBuilder3 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder3[0].Reference = sketchNode;
            pointBuilder3[1].TransformedPoint3D = new Point3D(4, 5, 0);
            pointBuilder3.ExecuteFunction();
            var lineBuilder2 = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder2[0].Reference = pointBuilder2.Node;
            lineBuilder2[1].Reference = pointBuilder3.Node;
            lineBuilder2.ExecuteFunction();

            document.Commit("Drawn line");
            document.Transact();
            var options = new SketchHinterOptions
            {
                ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                PointRange = 3.0
            };
            var sketchHinter = new Hinter2D(sketchNode, document, options);
            sketchHinter.Populate();

            sketchHinter.ApplyAlgorithms(lineBuilder2);
            document.Commit("Perpendicular constraint added");
            document.Transact();
            Assert.AreEqual(document.Root.Children.Count, 7);
            Assert.AreEqual(document.Root[6].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name, Constraint2DNames.PerpendicularFunction);

            var nodeToDelete = document.Root[3];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            Assert.AreEqual(4, document.Root.Children.Count, "Line is not deleted");
        }

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void RectangleDeleteLineTest()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D(1,1, 0);
            var pointBuilder2 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder2[0].Reference = sketchNode;
            pointBuilder2[1].TransformedPoint3D = new Point3D(7,1, 0);
            pointBuilder.ExecuteFunction();
            var pointBuilder3 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder3[0].Reference = sketchNode;
            pointBuilder3[1].TransformedPoint3D = new Point3D(7,4, 0);
            pointBuilder3.ExecuteFunction();
            var pointBuilder4 = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder4[0].Reference = sketchNode;
            pointBuilder4[1].TransformedPoint3D = new Point3D(1,4, 0);
            pointBuilder4.ExecuteFunction();
          
            var lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = pointBuilder.Node;
            lineBuilder[1].Reference = pointBuilder2.Node;
            lineBuilder.ExecuteFunction();

         
            var lineBuilder2 = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder2[0].Reference = pointBuilder2.Node;
            lineBuilder2[1].Reference = pointBuilder3.Node;
            lineBuilder2.ExecuteFunction();

            var lineBuilder3 = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder3[0].Reference = pointBuilder3.Node;
            lineBuilder3[1].Reference = pointBuilder4.Node;
            lineBuilder3.ExecuteFunction();

            var lineBuilder4 = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder4[0].Reference = pointBuilder4.Node;
            lineBuilder4[1].Reference = pointBuilder.Node;
            lineBuilder4.ExecuteFunction();
            document.Commit("Drawn line");
            document.Transact();
            var options = new SketchHinterOptions
            {
                ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                PointRange = 3.0
            };
            var sketchHinter = new Hinter2D(sketchNode, document, options);
            sketchHinter.Populate();

            sketchHinter.ApplyAlgorithms(lineBuilder2);
            sketchHinter.ApplyAlgorithms(lineBuilder);
            document.Commit("Perpendicular constraint added");
            document.Transact();
          
            Assert.AreEqual(document.Root.Children.Count, 15);
            var nodeToDelete = document.Root[3];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            Assert.AreEqual(7, document.Root.Children.Count, "Line is not deleted");
        }

        [Test]
        // Draw two parallel lines and delete one of the points -> constraint and line should be deleted, as well
        public void ParallelLinesDeletePointTest()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            TestUtils.Line(document, sketchNode, new Point3D(0, 0, 0), new Point3D(1, 1, 0));

            var lineBuilder2 = TestUtils.Line(document, sketchNode, new Point3D(0, 1, 0), new Point3D(1, 2, 0));
            document.Commit("Drawn line");
            document.Transact();
            var options = new SketchHinterOptions
            {
                ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                PointRange = 3.0
            };
            var sketchHinter = new Hinter2D(sketchNode, document, options);
            sketchHinter.Populate();

            sketchHinter.ApplyAlgorithms(lineBuilder2);
            document.Commit("Parallel constraint added");
            document.Transact();
            Assert.AreEqual(document.Root.Children.Count, 8);
            Assert.AreEqual(document.Root[7].Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name, Constraint2DNames.ParallelFunction);

            var nodeToDelete = document.Root[2];
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            // the other line point remains
            Assert.AreEqual(5, document.Root.Children.Count, "Line is not deleted");
        }

        [Test]
        // Draw two parallel lines and delete one of the points -> constraint and line should be deleted, as well
        public void ExtrudeDeleteBaseTest()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var circleBuilder = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 10);
            TestUtils.Circle(document, sketchNode, new Point3D(20, 20, 0), 10);
            Assert.AreEqual(circleBuilder.LastExecute, true);
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            var extrudeBuilder = new NodeBuilder(document, FunctionNames.Extrude);
            extrudeBuilder[0].Reference = sketchNode;
            extrudeBuilder[1].Integer = 0;
            extrudeBuilder[2].Real = 10;
            extrudeBuilder.ExecuteFunction();
            Assert.AreEqual(extrudeBuilder.LastExecute, true);
            document.Commit("Extrude created");
            document.Transact();
            var volume = GeomUtils.GetSolidVolume(extrudeBuilder.Shape);
            Assert.AreEqual(volume, 2*Math.PI*1000);
            Assert.AreEqual(document.Root.Children.Count, 6);
            var nodeToDelete = document.Root[2];
            
            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            NodeUtils.RebuildAllSketchFaces(document);
            extrudeBuilder.ExecuteFunction();
            volume = GeomUtils.GetSolidVolume(extrudeBuilder.Shape);
            Assert.AreEqual(4, document.Root.Children.Count, "Circle is not deleted");
            Assert.AreEqual(volume, Math.PI * 1000);
        }

        [Test]
        public void CutDeleteBaseTest1()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var circleBuilder = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 10);
            TestUtils.Circle(document, sketchNode, new Point3D(20, 20, 0), 10);
            Assert.AreEqual(circleBuilder.LastExecute, true);
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            var extrudeBuilder = new NodeBuilder(document, FunctionNames.Extrude);
            extrudeBuilder[0].Reference = sketchNode;
            extrudeBuilder[1].Integer = 0;
            extrudeBuilder[2].Real = 10;
            extrudeBuilder.ExecuteFunction();
            Assert.AreEqual(extrudeBuilder.LastExecute, true);
            document.Commit("Extrude created");
            document.Transact();
            var volume = GeomUtils.GetSolidVolume(extrudeBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000);
            Assert.AreEqual(document.Root.Children.Count, 6);

            var sketchNode2 = sketchCreator.BuildSketchNode();
            document.Commit("Added second sketch");
            document.Transact();
            TestUtils.Circle(document, sketchNode2, new Point3D(0, 0, 0), 5);
            sketchNode2.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode2, document);
            document.Commit("Added circle node");
            document.Transact();
            var cutBuilder = new NodeBuilder(document, FunctionNames.Cut);
            cutBuilder[0].Reference = sketchNode2;
            cutBuilder[2].Integer = (int)ExtrusionTypes.MidPlane;
            cutBuilder[1].Real = 10000;
            cutBuilder.ExecuteFunction();
            Assert.AreEqual(cutBuilder.LastExecute, true);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000 - Math.PI* 250);
            Assert.AreEqual(document.Root.Children.Count, 10);
            document.Commit("Added cut");
            document.Transact();
            var nodeToDelete = document.Root[4];

            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            document.Transact();
            NodeUtils.RebuildAllSketchFaces(document);

            extrudeBuilder.ExecuteFunction();
            cutBuilder.ExecuteFunction();
            document.Commit("Finished");
            Assert.IsTrue(cutBuilder.LastExecute);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(8, document.Root.Children.Count, "Circle is not deleted");
            Assert.AreEqual(volume, Math.PI * 1000 - Math.PI * 250);
        }

        [Test]
        [Ignore("Cut through nothing bug causes this to fail")]
        public void CutDeleteBaseTest2()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var circleBuilder = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 10);
            TestUtils.Circle(document, sketchNode, new Point3D(20, 20, 0), 10);
            Assert.AreEqual(circleBuilder.LastExecute, true);
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            var extrudeBuilder = new NodeBuilder(document, FunctionNames.Extrude);
            extrudeBuilder[0].Reference = sketchNode;
            extrudeBuilder[1].Integer = 0;
            extrudeBuilder[2].Real = 10;
            extrudeBuilder.ExecuteFunction();
            Assert.AreEqual(extrudeBuilder.LastExecute, true);
            document.Commit("Extrude created");
            document.Transact();
            var volume = GeomUtils.GetSolidVolume(extrudeBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000);
            Assert.AreEqual(document.Root.Children.Count, 6);

            var sketchNode2 = sketchCreator.BuildSketchNode();
            document.Commit("Second sketch created");
            document.Transact();
            TestUtils.Circle(document, sketchNode2, new Point3D(0, 0, 0), 5);
            sketchNode2.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode2, document);
           
            var cutBuilder = new NodeBuilder(document, FunctionNames.Cut);
            cutBuilder[0].Reference = sketchNode2;
            cutBuilder[2].Integer = (int)ExtrusionTypes.MidPlane;
            cutBuilder[1].Real = 10000;
            cutBuilder.ExecuteFunction();
            Assert.AreEqual(cutBuilder.LastExecute, true);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000 - Math.PI * 250);
            Assert.AreEqual(document.Root.Children.Count, 10);

            var nodeToDelete = document.Root[2];

            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            document.Transact();
            NodeUtils.RebuildAllSketchFaces(document);
            extrudeBuilder.ExecuteFunction();
            cutBuilder.ExecuteFunction();
            document.Commit("Finished");
            Assert.IsTrue(cutBuilder.LastExecute);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(8, document.Root.Children.Count, "Circle is not deleted");
            Assert.AreEqual(volume, Math.PI * 1000);
        }

        [Test]
        [Ignore("Cut with empty sketch bug causes this to fail")]
        public void CutDeleteBaseTest3()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var circleBuilder = TestUtils.Circle(document, sketchNode, new Point3D(0, 0, 0), 10);
            TestUtils.Circle(document, sketchNode, new Point3D(20, 20, 0), 10);
            Assert.AreEqual(circleBuilder.LastExecute, true);
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            var extrudeBuilder = new NodeBuilder(document, FunctionNames.Extrude);
            extrudeBuilder[0].Reference = sketchNode;
            extrudeBuilder[1].Integer = 0;
            extrudeBuilder[2].Real = 10;
            extrudeBuilder.ExecuteFunction();
            Assert.AreEqual(extrudeBuilder.LastExecute, true);
            document.Commit("Extrude created");
            
            var volume = GeomUtils.GetSolidVolume(extrudeBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000);
            Assert.AreEqual(document.Root.Children.Count, 6);

            var sketchNode2 = sketchCreator.BuildSketchNode();
            document.Transact();
            TestUtils.Circle(document, sketchNode2, new Point3D(0, 0, 0), 5);
            sketchNode2.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode2, document);

            var cutBuilder = new NodeBuilder(document, FunctionNames.Cut);
            cutBuilder[0].Reference = sketchNode2;
            cutBuilder[2].Integer = (int)ExtrusionTypes.MidPlane;
            cutBuilder[1].Real = 10000;
            cutBuilder.ExecuteFunction();
            Assert.AreEqual(cutBuilder.LastExecute, true);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(volume, 2 * Math.PI * 1000 - Math.PI * 250);
            Assert.AreEqual(document.Root.Children.Count, 10);

            var nodeToDelete = document.Root[8];

            NodeBuilderUtils.DeleteNode(nodeToDelete, document);
            document.Commit("Deleted");
            document.Transact();
            NodeUtils.RebuildAllSketchFaces(document);
            extrudeBuilder.ExecuteFunction();
            cutBuilder.ExecuteFunction();
            document.Commit("Finished");
            Assert.IsTrue(cutBuilder.LastExecute);
            volume = GeomUtils.GetSolidVolume(cutBuilder.Shape);
            Assert.AreEqual(8, document.Root.Children.Count, "Circle is not deleted");
            Assert.AreEqual(volume, 2* Math.PI * 1000);
        }
    }
}