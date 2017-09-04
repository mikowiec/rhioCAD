#region Usings
using System;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NUnit.Framework;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class ExtrudeTests
    {
        [Test]
        public void ExtrudeSketchTest()
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
        }
    }
}