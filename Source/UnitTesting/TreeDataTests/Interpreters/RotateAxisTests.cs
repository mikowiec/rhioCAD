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
    public class RotateAxisTests
    {
        [Test]
        public void RotationAroundAxisWithPivotSetAndPivotCheck()
        {
            var aPoint = new Point3D(10, 10, 0);
            var axisPoint = new Point3D(10, 0, 0);
            var rotationAxis = new gpAx1(axisPoint.GpPnt, new gpDir(0, 0, 1));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());

            var interpreter = builder.Node.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.Pivot = new gpPnt(5, 5, 0);
            interpreter.RotateAroundAxis(rotationAxis, 90);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(0 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(0 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(0 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");

            Assert.IsTrue(Math.Abs(5 - interpreter.Pivot.X) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(-5 - interpreter.Pivot.Y) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(0 - interpreter.Pivot.Z) < 0.1, "incorrect rotation pivot");
        }

        [Test]
        public void RotationAroundAxisWithoutPivotSet()
        {
           
            var aPoint = new Point3D(10, 10, 0);
            var axisPoint = new Point3D(10, 0, 0);
            var rotationAxis = new gpAx1(axisPoint.GpPnt, new gpDir(0, 0, 1));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
           
         
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());

            var interpreter = builder.Node.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.RotateAroundAxis(rotationAxis, 90);
            builder.ExecuteFunction();
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(0 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation");
        }

        [Test]
        public void Rotation30AroundOx()
        {
            var rotationAxis =gp.OX;

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var interpreter = sketchNode.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.RotateAroundAxis(rotationAxis, 30);
            var nb = new NodeBuilder(sketchNode);
            nb.ExecuteFunction();

            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.5 - interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.5 - interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translation");
        }

        [Test]
        public void Rotation30AroundOxAndTranslate()
        {
            var rotationAxis = gp.OX;

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var interpreter = sketchNode.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.RotateAroundAxis(rotationAxis, 30);
            var nb = new NodeBuilder(sketchNode);
            nb.ExecuteFunction();

            interpreter.TranslateWith(new Point3D(10, 0, 0));

            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.5 - interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.5 - interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(10-interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translation");
        }


        [Test]
        public void MultiplyRotation()
        {
            var rotationAxis = gp.OX;

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();

            var interpreter = sketchNode.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.RotateAroundAxis(rotationAxis, 10);
            interpreter.RotateAroundAxis(rotationAxis, 20);
            var nb = new NodeBuilder(sketchNode);
            nb.ExecuteFunction();

            // the two rotations are equaivalent with one 30 rotation
            Assert.IsTrue(Math.Abs(1 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.5 - interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.5 - interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.86 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect translation");
            Assert.IsTrue(Math.Abs(interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect translation");
        }

        [Test]
        public void RotationAroundRandomAxisAndPivotCheck()
        {
            var aPoint = new Point3D(0, 10, 10);
            var axisPoint = new Point3D(0, 0, 0);
            var rotationAxis = new gpAx1(axisPoint.GpPnt, new gpDir(1, 1, 1));

            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].Reference = sketchNode;
            builder[1].TransformedPoint3D = aPoint;
            Assert.IsTrue(builder.ExecuteFunction());

            var interpreter = builder.Node.Set<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();
            interpreter.RotateAroundAxis(rotationAxis, 151.263);
            document.Commit("rotations done");

            Assert.IsTrue(Math.Abs(-0.2 - interpreter.CurrTransform.Value(1, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.34 - interpreter.CurrTransform.Value(1, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.9 - interpreter.CurrTransform.Value(1, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.9 - interpreter.CurrTransform.Value(2, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.2 - interpreter.CurrTransform.Value(2, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.34 - interpreter.CurrTransform.Value(2, 3)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.34 - interpreter.CurrTransform.Value(3, 1)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(0.9 - interpreter.CurrTransform.Value(3, 2)) < 0.1, "incorrect rotation");
            Assert.IsTrue(Math.Abs(-0.2 - interpreter.CurrTransform.Value(3, 3)) < 0.1, "incorrect rotation");

            Assert.IsTrue(Math.Abs(12.5 - interpreter.CurrTransform.Value(1, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(0.96 - interpreter.CurrTransform.Value(2, 4)) < 0.1, "incorrect rotation base point");
            Assert.IsTrue(Math.Abs(6.51 - interpreter.CurrTransform.Value(3, 4)) < 0.1, "incorrect rotation base point");

            Assert.IsTrue(Math.Abs(12.5 - interpreter.Pivot.X) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(0.96 - interpreter.Pivot.Y) < 0.1, "incorrect rotation pivot");
            Assert.IsTrue(Math.Abs(6.51 - interpreter.Pivot.Z) < 0.1, "incorrect rotation pivot");
        }
    }
}