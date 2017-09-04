using System;
using System.Collections.Generic;
using NUnit.Framework;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Enums;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Utils;
using SketchHinter;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

namespace TreeDataTests
{
    [TestFixture]
    public class ShapeGraphTests
    {

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void PerpendicularLinesTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sh = new ShapeGraph();
            sh.SetDocument(document);

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D(4, 1, 0);
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

           var expectedReferringTo = new SortedDictionary<int, List<int>>
                                         {
                                             {1, new List<int> {0}},
                                             {2, new List<int> {0}},
                                             {3, new List<int> {1, 2}},
                                             {4, new List<int> {0}},
                                             {5, new List<int> {4, 2}},
                                             {6, new List<int> {3, 5}}
                                         };
           foreach (var key in expectedReferringTo.Keys)
           {
               CollectionAssert.AreEquivalent(expectedReferringTo[key], sh.ReferringTo[key]);
           }
            var expectedReferrencedBy = new SortedDictionary<int, List<int>>
                                            {
                                                {0, new List<int> {1, 2, 4}},
                                                {1, new List<int> {3}},
                                                {2, new List<int> {3, 5}},
                                                {3, new List<int> {6}},
                                                {4, new List<int> {5}},
                                                {5, new List<int> {6}}
                                            };
            foreach (var key in expectedReferrencedBy.Keys)
            {
                CollectionAssert.AreEquivalent(expectedReferrencedBy[key], sh.ReferrencedBy[key]);
            }
        }

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void CircleArcTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sh = new ShapeGraph();
            sh.SetDocument(document);

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();

            TestUtils.Circle(document, sketchNode, new Point3D(10, 10, 0), 5);
            TestUtils.Arc(document, sketchNode, new Point3D(0, 0, 0), new Point3D(0, 5, 0),
                                           new Point3D(5, 0, 0));
            
            document.Commit("Drawn circle and arc");
           
            Assert.AreEqual(document.Root.Children.Count, 7);

            var expectedReferringTo = new SortedDictionary<int, List<int>>
                                         {
                                             {1, new List<int> {0}},
                                             {2, new List<int> {1}},
                                             {3, new List<int> {0}},
                                             {4, new List<int> {0}},
                                             {5, new List<int> {0}},
                                             {6, new List<int> {3, 4, 5}}
                                         };
            foreach (var key in expectedReferringTo.Keys)
            {
                CollectionAssert.AreEquivalent(expectedReferringTo[key], sh.ReferringTo[key]);
            }
            var expectedReferrencedBy = new SortedDictionary<int, List<int>>
                                            {
                                                {0, new List<int> {1, 3, 4, 5}},
                                                {1, new List<int> {2}},
                                                {3, new List<int> {6}},
                                                {4, new List<int> {6}},
                                                {5, new List<int> {6}}
                                            };
            foreach (var key in expectedReferrencedBy.Keys)
            {
                CollectionAssert.AreEquivalent(expectedReferrencedBy[key], sh.ReferrencedBy[key]);
            }
        }

        [Test]
        // Draw two parallel lines and delete one of the lines -> constraint should be deleted, as well
        public void CutThroughAllTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sh = new ShapeGraph();
            sh.SetDocument(document);
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
            Assert.AreEqual(volume, 2 * Math.PI * 1000 - Math.PI * 250);
            Assert.AreEqual(document.Root.Children.Count, 10);
            document.Commit("Added cut");
         
            var expectedReferringTo = new SortedDictionary<int, List<int>>
                                         {
                                             {1, new List<int> {0}},
                                             {2, new List<int> {1}},
                                             {3, new List<int> {0}},
                                             {4, new List<int> {3}},
                                             {5, new List<int> {0}},
                                             {7, new List<int> {6}},
                                             {8, new List<int> {7}},
                                             {9, new List<int> {6, 5}}
                                         };
            foreach (var key in expectedReferringTo.Keys)
            {
                CollectionAssert.AreEquivalent(expectedReferringTo[key], sh.ReferringTo[key]);
            }
            var expectedReferrencedBy = new SortedDictionary<int, List<int>>
                                            {
                                                {0, new List<int> {1, 3, 5}},
                                                {1, new List<int> {2}},
                                                {3, new List<int> {4}},
                                                {6, new List<int> {7,9}},
                                                {7, new List<int> {8}}
                                            };
            foreach (var key in expectedReferrencedBy.Keys)
            {
                CollectionAssert.AreEquivalent(expectedReferrencedBy[key], sh.ReferrencedBy[key]);
            }
        }

    }
}
