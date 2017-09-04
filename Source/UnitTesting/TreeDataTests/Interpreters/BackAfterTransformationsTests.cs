#region Usings

using System;
using NaroConstants.Names;
using NUnit.Framework;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Interpreters
{
    [TestFixture]
    public class BackAfterTransformationsTests
    {
        [Test]
        public void BackAfterRotate()
        {
            var aPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            
            var sketchCreator = new SketchCreator(document, false);
            
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Point added.");
            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
           
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");
            interpreter.Rotate = new gpPnt(45, 0, 0);
            document.Commit("Rotate done");

            document.Undo();

            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");
        }

        [Test]
        public void BackAfterRotateTranslateSetPivot()
        {
            var aPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Point drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            interpreter.Rotate = new gpPnt(45, 0, 0);
            document.Commit("Rotate done");

            document.Transact();
            interpreter.Translate = new gpPnt(15, 10, 0);
            document.Commit("Rotate done");

            document.Transact();
            interpreter.Pivot = new gpPnt(15, 10, 0);
            document.Commit("Rotate done");

            document.Undo();
            document.Undo();
            document.Undo();

            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect  pivot");
        }

        [Test]
        public void BackAfterSetPivot()
        {
            var aPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Point drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            interpreter.Pivot = new gpPnt(15, 10, 0);
            document.Commit("Set pivot done");

            document.Undo();

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect  pivot");
        }

        [Test]
        public void BackAfterTranslate()
        {
            var aPoint = new Point3D(10, 10, 0);

            var document = TestUtils.DefaultsSetup();
            
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());
            document.Commit("Point drawn");

            document.Transact();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
            interpreter.Translate = new gpPnt(15, 10, 0);
            document.Commit("Rotate done");

            document.Undo();

            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.X) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(10 - interpreter.Pivot.Y) < 0.1, "incorrect  pivot");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect  pivot");
        }
    }
}