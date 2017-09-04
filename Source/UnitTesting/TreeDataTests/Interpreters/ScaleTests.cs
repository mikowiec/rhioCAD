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
    internal class ScaleTests
    {
        [Test]
        public void Scale()
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
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }

        [Test]
        public void ScaleFromOrigin()
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
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }

        [Test]
        public void ScaleFromOriginWithPivotSet()
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
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }

        [Test]
        public void ScaleWithPivotSet()
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
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(20 - interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(20 - interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }

        [Test]
        public void ScaleWithYTranslation()
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
            interpreter.Translate = new gpPnt(10, 15, 0);
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(10 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(20 - interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(25 - interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }

        [Test]
        public void ScaleWithYTranslationAndZRotation()
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
            interpreter.Translate = new gpPnt(10, 15, 0);
            interpreter.Rotate = new gpPnt(0, 0, 45);
            interpreter.Scale = 2;
            document.Commit("scale done");

            Assert.IsTrue(Math.Abs(1.41 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(-1.4 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(1.41 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(1.41 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect scale");
            Assert.IsTrue(Math.Abs(2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect scale");

            Assert.IsTrue(Math.Abs(15 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(13 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect scale base point");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect scale base point");

            Assert.IsTrue(Math.Abs(15 - interpreter.Pivot.X) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(27 - interpreter.Pivot.Y) < 0.1, "incorrect scale pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect scale pivot");
        }
    }
}