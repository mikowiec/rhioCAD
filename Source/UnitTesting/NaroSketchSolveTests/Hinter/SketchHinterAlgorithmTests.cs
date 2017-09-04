#region Usings

using NaroSketchSolveTests.ConstraintsSolver;
using NUnit.Framework;
using OccCode;
using ShapeFunctionsInterface.Utils;
using SketchHinter;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchSolveTests.Hinter
{
    [TestFixture]
    public class SketchHinterAlgorithmTests
    {
        [Test]
        public void ComputeHorizontal()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var pointLinker = sketch.PointLinker;
            var line = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 1, 0), new Point3D(3, 1, 0));
            var options = new SketchHinterOptions
                              {
                                  ParallelAngle = GeomUtils.DegreesToRadians(5.0),
                                  PointRange = 3.0
                              };
            var sketchHinter = new Hinter2D(sketchNode, document, options);
            sketchHinter.Populate();

            var result = sketchHinter.ApplyAlgorithms(line);
            document.Commit("Drawn line");

            Assert.AreEqual(sketchHinter.HinterShapes[line.Node.Index].Builder.Node.Index, line.Node.Index);
            Assert.IsNotEmpty(result);
        }
    }
}