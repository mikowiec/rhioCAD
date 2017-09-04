#region Usings

using NaroConstants.Names;
using NUnit.Framework;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.Interpreters
{
    [TestFixture]
    public class TransformationInterpreterTest
    {
        private readonly gpPnt _originCoordinate = new gpPnt(0, 0, 0);

        [Test]
        public void TransformationInterpreterTwoTransformationSetupsTest()
        {
            var testPoint = new Point3D(100, 100, 100);
            var trsf = GeomUtils.BuildTranslation(new Point3D(_originCoordinate), testPoint);
            var trsfInterpreter = new TransformationInterpreter();
            trsfInterpreter.Disable();

            trsfInterpreter.CurrTransform = trsf;

            var translatedPoint = _originCoordinate.Transformed(trsfInterpreter.CurrTransform);
            Assert.AreEqual(translatedPoint.IsEqual(testPoint.GpPnt, Precision.Confusion), true,
                            "Broken transformation interpreter");

            var testPoint2 = new Point3D(200, 200, 200);
            trsf = GeomUtils.BuildTranslation(new Point3D(_originCoordinate), testPoint2);
            trsfInterpreter.CurrTransform = trsf;
            translatedPoint = _originCoordinate.Transformed(trsfInterpreter.CurrTransform);
            Assert.AreEqual(translatedPoint.IsEqual(testPoint2.GpPnt,Precision.Confusion), true,
                            "Broken transformation interpreter at second Trsf set");
        }

        [Test]
        public void TranslatedLineTest()
        {
            var document = TestUtils.DefaultsSetup();
            document.Transact();

            var sketchCreator = new SketchCreator(document);
            var sketchNode = sketchCreator.BuildSketchNode();
            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D();
            pointBuilder.ExecuteFunction();
            var secondPointBuilder = new NodeBuilder(document, FunctionNames.Point);
            secondPointBuilder[0].Reference = sketchNode;
            secondPointBuilder[1].TransformedPoint3D = new Point3D(1,0,0);
            secondPointBuilder.ExecuteFunction();

            var builder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Reference = secondPointBuilder.Node;
            Assert.IsTrue(builder.ExecuteFunction());

            builder.Node.Set<TransformationInterpreter>();
            var interpreter = builder.Node.Get<TransformationInterpreter>();
        
            interpreter.ApplyTranslateWith(new Point3D(10, 0, 0));
            builder.ExecuteFunction();
            Assert.IsTrue(builder[1].RefTransformedPoint3D.IsEqual(new Point3D(1, 0, 0)));
            Assert.IsTrue(builder.Pivot.X- 10 < 0.1, "Incorrect pivot value");
            Assert.IsTrue(builder.Pivot.Y < 0.1, "Incorrect pivot value");
            Assert.IsTrue(builder.Pivot.Z < 0.1, "Incorrect pivot value");

            interpreter.Translate = new gpPnt(-10, 0, 0);

            builder.ExecuteFunction();
            Assert.IsTrue(builder.Pivot.X < 0.1, "Incorrect pivot value");
            Assert.IsTrue(builder.Pivot.Y < 0.1, "Incorrect pivot value");
            Assert.IsTrue(builder.Pivot.Z < 0.1, "Incorrect pivot value");
            document.Commit("moved line");
        }
    }
}