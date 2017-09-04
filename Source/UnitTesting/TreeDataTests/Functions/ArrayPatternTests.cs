#region Usings

using System;
using NUnit.Framework;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Functions
{
    [TestFixture]
    public class ArrayPatternTests
    {
        [Test]
        public void CheckDefaultPivotValues()
        {
            var columnAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 1, 0));
            var rowAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(1, 0, 0));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = TestUtils.Point(document, sketchNode, new Point3D(10, 10, 0));
            Assert.IsTrue(pointBuilder.ExecuteFunction());
           
            var interpreter = pointBuilder.Node.Get<TransformationInterpreter>();
            interpreter.ApplyGeneralArrayPattern(rowAxis, columnAxis, 5, 5);
            document.Commit("Array Pattern done");

            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.X) < 0.1, "incorrect array pattern pivot");
            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.Y) < 0.1, "incorrect array pattern  pivot");
            Assert.IsTrue(Math.Abs(0 - interpreter.Pivot.Z) < 0.1, "incorrect array pattern  pivot");
        }

        [Test]
        public void CheckSettedPivotValues()
        {
            var colomnAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 1, 0));
            var rowAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(1, 0, 0));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = TestUtils.Point(document, sketchNode, new Point3D(10, 10, 0));
            Assert.IsTrue(pointBuilder.ExecuteFunction());
           
            var interpreter = pointBuilder.Node.Get<TransformationInterpreter>();
            interpreter.Pivot = new gpPnt(12, 12, 0);
            interpreter.ApplyGeneralArrayPattern(rowAxis, colomnAxis, 5, 5);
            document.Commit("Array Pattern done");

            Assert.IsTrue(Math.Abs(17 - interpreter.Pivot.X) < 0.1, "incorrect array pattern pivot");
            Assert.IsTrue(Math.Abs(17 - interpreter.Pivot.Y) < 0.1, "incorrect array pattern  pivot");
            Assert.IsTrue(Math.Abs(0 - interpreter.Pivot.Z) < 0.1, "incorrect array pattern  pivot");
        }

        [Test]
        public void CheckTranslateValueTest()
        {
            var colomnAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(0, 1, 0));
            var rowAxis = new gpAx1(new gpPnt(0, 0, 0), new gpDir(1, 0, 0));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = TestUtils.Point(document, sketchNode, new Point3D(10, 10, 0));
            Assert.IsTrue(pointBuilder.ExecuteFunction());
           
            var interpreter = pointBuilder.Node.Get<TransformationInterpreter>();
            interpreter.ApplyGeneralArrayPattern(rowAxis, colomnAxis, 5, 5);
            document.Commit("Array Pattern done");

            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(1, 4)) < 0.1,
                          "incorrect array pattern base point");
            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(2, 4)) < 0.1,
                          "incorrect array pattern base point");
            Assert.IsTrue(Math.Abs(0 - interpreter.CurrTransform.Value(3, 4)) < 0.1,
                          "incorrect array pattern base point");
        }
    }
}