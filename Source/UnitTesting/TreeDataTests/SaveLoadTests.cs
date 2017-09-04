#region Usings

using System;
using Naro.PartModeling;
using NaroConstants.Names;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests
{
    [TestFixture]
    public class SaveLoadTests
    {
        [Test]
        public void LoadComplexShape()
        {
            var document = TestUtils.DefaultsSetup();

            document.LoadFromXml("final.naroxml");
            var startTime = Environment.TickCount;
            document.Revert();
            var endTime = Environment.TickCount;
            var diff = endTime - startTime;
            Assert.IsTrue(diff < 25, "Operation of transact should take much less time! Took: " + diff);
        }

        [Test]
        public void TwoCircles()
        {
            var document = TestUtils.DefaultsSetup();

            var sketchCreator = new SketchCreator(document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            document.Transact();
            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = new Point3D();
            pointBuilder.ExecuteFunction();
            var circleBuilder = new NodeBuilder(document, FunctionNames.Circle);
            circleBuilder[0].Reference = pointBuilder.Node;
            circleBuilder[1].Real = 20;
            circleBuilder.ExecuteFunction();
            //document.Commit("Draw first circle");

            //document.Transact();
            circleBuilder = new NodeBuilder(document, FunctionNames.Circle);
            circleBuilder[0].Reference = pointBuilder.Node;
            circleBuilder[1].Real = 10;
            circleBuilder.ExecuteFunction();
            document.Commit("Draw circles");

            const string fileName = "two_circles.naroxml";
            document.SaveToXml(fileName);
            var actionGraph = document.Root.Set<ActionGraphInterpreter>().ActionsGraph;
            document = new Document();
            document.Root.Set<ActionGraphInterpreter>().ActionsGraph = actionGraph;
            document.LoadFromXml(fileName);

            Assert.AreEqual(4, document.Root.Children.Count);
        }
    }
}