#region Usings
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NUnit.Framework;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class TransformationTests
    {
        [Test]
        public void TranslateExtrudedSketchTest()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            TestUtils.BuildRectangle(document, sketchNode, new Point3D(1, 1, 0), new Point3D(10,1,0), new Point3D(10,13,0), new Point3D(1,13,0) );
           
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
            Assert.AreEqual(volume,  1080);
            Assert.AreEqual(document.Root.Children.Count, 10);
            var sketchNodeBuilder = new NodeBuilder(document, FunctionNames.Sketch);
            sketchNodeBuilder[0].Axis3D = new Axis(new Point3D(0, 0, 0), new Point3D(0, 0, 1));
            sketchNodeBuilder[2].Reference = extrudeBuilder.Node;
            sketchNodeBuilder[3].Integer = 3;
            sketchNodeBuilder.ExecuteFunction();
            Assert.AreEqual(sketchNodeBuilder.LastExecute, true);
            Assert.AreEqual(document.Root.Children.Count, 11);

            //var circleBuilder = TestUtils.Circle(document, sketchNodeBuilder.Node, new Point3D(2, 13, 8), 5);
            //circleBuilder.ExecuteFunction();
            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D(2, 13, 8);
            pointBuilder.ExecuteFunction();
            var circle = new NodeBuilder(document, FunctionNames.Circle);
            circle[0].Reference = pointBuilder.Node;
            circle[1].Real = 5;
            circle.ExecuteFunction();
            Assert.AreEqual(document.Root.Children.Count, 13);
            document.Commit("Circle drawn");
            document.Transact();
            NodeUtils.Translate3DNode(extrudeBuilder, document, new Point3D(11,1,0));//, new Point3D(1,1,0));

            document.Commit("Translated");
            Assert.AreEqual(pointBuilder[1].TransformedPoint3D, new Point3D(12,13,8));
            document.Transact();
            NodeUtils.Translate3DNode(extrudeBuilder, document, new Point3D(11, 11, 0));//, new Point3D(1, 1, 0));

            Assert.AreEqual(pointBuilder[1].TransformedPoint3D, new Point3D(12, 23, 8));
            
        }

        [Test]
        public void SetTransformationTestTranslationOnZ()
        {
            var originBaseSketch = new gpPnt(1, 1, 0);
            var originSecondSketch = new gpPnt(2, 2, 10);
            var T = new gpTrsf();
            var oldSystemAxis = new gpAx3(originBaseSketch, new gpDir(0, 0, 1));
            var newSystemAxis = new gpAx3(originSecondSketch, new gpDir(0, 0, 1));
            T.SetTransformation(oldSystemAxis, newSystemAxis);
            var secondOriginTransformed = originSecondSketch.Transformed(T);
            Assert.AreEqual(secondOriginTransformed.X, originBaseSketch.X);
            Assert.AreEqual(secondOriginTransformed.Y, originBaseSketch.Y);
            Assert.AreEqual(secondOriginTransformed.Z, originBaseSketch.Z);
            var point = new gpPnt(2, 3, 10).Transformed(T);
            Assert.AreEqual(point.X, 1);
            Assert.AreEqual(point.Y, 2);
            Assert.AreEqual(point.Z, 0);
        }

        [Test]
        public void SetTransformationTestRotationAndTranslation()
        {
            var originBaseSketch = new gpPnt(1, 1, 0);
            var originSecondSketch = new gpPnt(10, 1, 0);
            var T = new gpTrsf();
            var oldSystemAxis = new gpAx3(originBaseSketch, new gpDir(0, 0, 1));
            var newSystemAxis = new gpAx3(originSecondSketch, new gpDir(1, 0, 0));
            T.SetTransformation(oldSystemAxis, newSystemAxis);
           
            var point = new gpPnt(10, 3, 8).Transformed(T);
           
            var translationPart = new gpTrsf();
            translationPart.SetTranslation(new gpPnt(0,0,0), point);
            gpTrsf mult1 = T.Inverted.Multiplied(translationPart);
            var try1 = new gpPnt(0, 0, 0).Transformed(mult1); // ok
            Assert.AreEqual(try1.X, 10);
            Assert.AreEqual(try1.Y, 3);
            Assert.AreEqual(try1.Z, 8);
            gpTrsf mult2 = translationPart.Multiplied(T.Inverted);
            var try2 = new gpPnt(0, 0, 0).Transformed(mult2); // nok
            Assert.AreEqual(try2.X, 17);
            Assert.AreEqual(try2.Y, -3);
            Assert.AreEqual(try2.Z, 1);
        }

        [Test]
        public void SetTransformationTestMultipleTrsf()
        {
            var originBaseSketch = new gpPnt(1, 1, 0);
            var originSecondSketch = new gpPnt(10, 1, 0);
          
            var T = new gpTrsf();
            var oldSystemAxis = new gpAx3(originBaseSketch, new gpDir(0, 0, 1));
            var newSystemAxis = new gpAx3(originSecondSketch, new gpDir(1, 0, 0));
            T.SetTransformation(oldSystemAxis, newSystemAxis);

            var point = new gpPnt(10, 3, 8).Transformed(T);

            var translationPart = new gpTrsf();
            translationPart.SetTranslation(new gpPnt(0, 0, 0), point);
            gpTrsf mult1 = T.Inverted.Multiplied(translationPart);
            var try1 = new gpPnt(0, 0, 0).Transformed(mult1); // ok: transformations needed to obtain global point (10, 3, 8)
            Assert.AreEqual(try1.X, 10);
            Assert.AreEqual(try1.Y, 3);
            Assert.AreEqual(try1.Z, 8);

            //reversed order doesn't work
            gpTrsf mult2 = translationPart.Multiplied(T.Inverted);
            var try2 = new gpPnt(0, 0, 0).Transformed(mult2);
            Assert.AreEqual(try2.X, 17);
            Assert.AreEqual(try2.Y, -3);
            Assert.AreEqual(try2.Z, 1);

            //translate entire 'object'
            var translation1 = new gpTrsf();
            translation1.SetTranslation(new gpPnt(1, 1, 0), new gpPnt(7, 1, 0));
            var multipleTrsfs = translation1.Multiplied(mult1);
            var try11 = new gpPnt(0, 0, 0).Transformed(multipleTrsfs);
            Assert.AreEqual(try11.X, 16);
            Assert.AreEqual(try11.Y, 3);
            Assert.AreEqual(try11.Z, 8);

            //reversed order doesn't work
            var multipleTrsfs2 = mult1.Multiplied(translation1);
            var try12 = new gpPnt(0, 0, 0).Transformed(multipleTrsfs2);
            Assert.AreEqual(try12.X, 10);
            Assert.AreEqual(try12.Y, 3);
            Assert.AreEqual(try12.Z, 14);
        }
    }
}