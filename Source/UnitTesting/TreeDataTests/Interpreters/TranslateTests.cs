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
    internal class TranslateTests
    {
        [Test]
        public void Translate()
        {
            var firstPoint = new Point3D(10, 10, 0);
            var secondPoint = new Point3D(20, 20, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Translate = new gpPnt(15, 10, 0);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.X) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect translate");
        }

        [Test]
        public void TranslateFromOrigin()
        {
            var firstPoint = new Point3D(0, 0, 0);
            var secondPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Translate = new gpPnt(5, 0, 0);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(5 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(5 - interpreter.Pivot.X) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Y) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect translate");
        }

        [Test]
        public void TranslateFromOriginWithPivotSet()
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
            interpreter.Translate = new gpPnt(5, 0, 0);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(5 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(5 - interpreter.Pivot.Y) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect translate");
        }

        [Test]
        public void TranslateWithPivotSet()
        {
            var firstPoint = new Point3D(10, 10, 0);
            var secondPoint = new Point3D(20, 20, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
            builder[1].TransformedPoint3D = secondPoint;

            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Rectangle drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Pivot = new gpPnt(15, 15, 0);
            interpreter.Translate = new gpPnt(15, 10, 0);
            document.Commit("rotation done");

            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(20 - interpreter.Pivot.X) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.Y) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect translate");
        }

        [Test]
        public void TranslateWithPivotSetAfterRotations()
        {
            var firstPoint = new Point3D(10, 10, 0);
            var secondPoint = new Point3D(20, 20, 0);

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].TransformedAxis3D = new gpAx1(firstPoint.GpPnt, new gpDir(0, 0, 1));
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
            interpreter.Translate = new gpPnt(20, 10, -5);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(20 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(-5 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(20 - interpreter.Pivot.X) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.Y) < 0.1, "incorrect translate");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect translate");
        }
    }
}