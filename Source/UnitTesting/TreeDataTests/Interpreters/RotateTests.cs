#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NUnit.Framework;

using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Interpreters
{
    [TestFixture]
    internal class RotateTests
    {
        [Test]
        public void MoreRotationsWithPivotSet()
        {
            var firstPoint = new Point3D(10, 10, 0);
            var secondPoint = new Point3D(20, 20, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].Axis3D = new Axis(new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1)));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Pivot = new gpPnt(15, 15, 0);
            interpreter.Rotate = new gpPnt(0, 0, 45);
            interpreter.Rotate = new gpPnt(0, 45, 0);
            interpreter.Rotate = new gpPnt(45, 0, 0);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(0.49 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.5 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.85 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.14 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.5 - interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.14 - interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.85 - interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.49 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(-5 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");
        }

        [Test]
        public void Rotate()
        {
            var firstPoint = new Point3D(10, 10, 0);
            var secondPoint = new Point3D(20, 20, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].TransformedAxis3D = (new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1)));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Rotate = new gpPnt(0, 0, 45);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.7 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");
        }

        [Test]
        public void RotateFromOrigin()
        {
            var firstPoint = new Point3D(0, 0, 0);
            var secondPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].Axis3D = new Axis(new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1)));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Rotate = new gpPnt(0, 0, 45);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.7 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");
        }

        [Test]
        public void RotateWithPivotSet()
        {
            var firstPoint = new Point3D(0, 0, 0);
            var secondPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].Axis3D = new Axis(new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1)));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Pivot = new gpPnt(5, 5, 0);
            interpreter.Rotate = new gpPnt(0, 0, 45);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.7 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.71 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(5 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(-2 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");
        }
    }
}