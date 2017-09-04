#region Usings

using System;
using NaroConstants.Names;
using NUnit.Framework;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Functions
{
    [TestFixture]
    public class CircularPatternTests
    {
        [Test]
        public void CircularPatternTestWithPivotSet()
        {
            var aPoint = new Point3D(10, 10, 0);
            var axisPoint = new Point3D(10, 0, 0);
            var rotationAxis = new gpAx1(axisPoint.GpPnt, new gpDir(0, 0, 1));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(pointBuilder.ExecuteFunction());
         
            var interpreter = pointBuilder.Node.Get<TransformationInterpreter>();
            interpreter.Pivot = new gpPnt(10, 5, 0);
            interpreter.ApplyGeneralCircularPattern(rotationAxis, 180, 10);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(-10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(-5 - interpreter.Pivot.Y) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Z) < 0.1, "incorrect rotation pivot");
        }

        [Test]
        public void CircularPatternTestWithoutPivotSet()
        {
            var aPoint = new Point3D(10, 10, 0);
            var axisPoint = new Point3D(10, 0, 0);
            var rotationAxis = new gpAx1(axisPoint.GpPnt, new gpDir(0, 0, 1));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(pointBuilder.ExecuteFunction());
          
            var interpreter = pointBuilder.Node.Get<TransformationInterpreter>();
            interpreter.ApplyGeneralCircularPattern(rotationAxis, 180, 10);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(-10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(-10 - interpreter.Pivot.Y) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Z) < 0.1, "incorrect rotation pivot");
        }
    }
}