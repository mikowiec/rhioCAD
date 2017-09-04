#region Usings

using System;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NUnit.Framework;

using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests.Interpreters
{
    [TestFixture]
    public class Transformations
    {
        private readonly gpPnt _originCoordinate = new gpPnt(0, 0, 0);

        [TestFixtureSetUp]
        public void Init()
        {
            DefaultInterpreters.Setup();
            var actionsGraph = new ActionsGraph();
            actionsGraph.Register(new FunctionFactoryInput());
            DefaultFunctions.Setup(actionsGraph);
        }

        [Test]
        public void Rotation45DegreesOnZTest()
        {
            var node = new Node();
            node.Set<TransformationInterpreter>();
            var interpreter = node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();

            interpreter.Pivot = new gpPnt(100, 100, 0);
            interpreter.Rotate = new gpPnt(0, 0, 45);
            var curTransform = interpreter.CurrTransform;

            var rotatedPoint = _originCoordinate.Transformed(curTransform);
            Assert.IsTrue(Math.Abs(100 - rotatedPoint.X) < 0.1, "incorrect rotation on x axis");
            Assert.IsTrue(Math.Abs(-41.42 - rotatedPoint.Y) < 0.1, "incorrect rotation on y axis");
            Assert.IsTrue(Math.Abs(0 - rotatedPoint.Z) < 0.1, "incorrect rotation on z axis");
        }

        [Test]
        public void TranslationRotation()
        {
            var node = new Node();
            node.Set<TransformationInterpreter>();
            var interpreter = node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();

            interpreter.Translate = new gpPnt(100, 100, 0);
            interpreter.Pivot = new gpPnt(0, 0, 0);
            interpreter.Rotate = new gpPnt(0, 0, 45);
            var curTransform = interpreter.CurrTransform;

            var rotatedPoint = new Point3D(_originCoordinate.Transformed(curTransform));

            Assert.IsTrue(Math.Abs(0 - rotatedPoint.X) < 0.1, "incorrect translation on x axis");
            Assert.IsTrue(Math.Abs(141.42 - rotatedPoint.Y) < 0.1, "incorrect translation on y axis");
            Assert.IsTrue(Math.Abs(rotatedPoint.Z) < 0.1, "incorrect translation on z axis");
            // Check the pivot point
            Assert.IsTrue(Math.Abs(interpreter.Pivot.X) < 0.1, "incorrect pivot on x axis");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Y) < 0.1, "incorrect pivot on y axis");
            Assert.IsTrue(Math.Abs(interpreter.Pivot.Z) < 0.1, "incorrect pivot on z axis");
        }

        [Test]
        public void TranslationTest()
        {
            var node = new Node();
            // Translate from (0, 0, 0) to (100, 100, 100)
            node.Set<TransformationInterpreter>();
            var interpreter = node.Get<TransformationInterpreter>();
            // Disable parent notification
            interpreter.Disable();

            //interpreter.Pivot = new gpPnt(100, 100, 0);
            interpreter.Translate = new gpPnt(100, 100, 100);
            var curTransform = interpreter.CurrTransform;

            var translatedPoint = _originCoordinate.Transformed(curTransform);
            // Check the translation
            Assert.IsTrue(Math.Abs(100 - translatedPoint.X) < 0.1, "incorrect translation on x axis");
            Assert.IsTrue(Math.Abs(100 - translatedPoint.Y) < 0.1, "incorrect translation on y axis");
            Assert.IsTrue(Math.Abs(100 - translatedPoint.Z) < 0.1, "incorrect translation on z axis");
            // Check the pivot point
            Assert.IsTrue(Math.Abs(100 - interpreter.Pivot.X) < 0.1, "incorrect pivot on x axis");
            Assert.IsTrue(Math.Abs(100 - interpreter.Pivot.Y) < 0.1, "incorrect pivot on y axis");
            Assert.IsTrue(Math.Abs(100 - interpreter.Pivot.Z) < 0.1, "incorrect pivot on z axis");
        }
    }
}