#region Usings
using System;
using NaroConstants.Names;
using NaroSketchAdapter;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchSolveTests.ConstraintsSolver
{
    [TestFixture]
    public class SketchAdaptedDocumentTests
    {
        [Test]
        public void HorizontalTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var pointLinker = sketch.PointLinker;

            var line = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(3, 1, 0), new Point3D(4, 2, 0));
            var constraintBuilder = new NodeBuilder(document, Constraint2DNames.HorizontalFunction);
            constraintBuilder[0].Reference = line.Node;

            document.Commit("Draw");
            var docSolverAdapter = new DocumentToSolverAdapter(document, sketchNode);

            docSolverAdapter.ImpactedNodes(line.Node, -1);
            var error = docSolverAdapter.Solve();

            Assert.IsTrue(error == 0, "Invalid horizontal solution");
        }

        [Test]
        public void ParallelTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var pointLinker = sketch.PointLinker;
            var line = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 1, 0), new Point3D(3, 1.5, 0));
            var line2 = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 3, 0), new Point3D(3, 2.5, 0));

            var constraintBuilder = new NodeBuilder(document, Constraint2DNames.ParallelFunction);
            constraintBuilder[0].Reference = line.Node;
            constraintBuilder[1].Reference = line2.Node;
            document.Commit("Draw");
            var docSolverAdapter = new DocumentToSolverAdapter(document, sketchNode);
            docSolverAdapter.ImpactedNodes(line2.Node, -1);
            var error = docSolverAdapter.Solve();

            Assert.IsTrue(error == 0, "Invalid perpendicular solution");
        }

        [Test]
        public void PerpendicularTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var firstPoint = sketch.GetPoint(new Point3D(1, 1, 0));
            var secondPoint = sketch.GetPoint(new Point3D(4, 1, 0));
            var thirdPoint = sketch.GetPoint(new Point3D(5, 3, 0));

            var line = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line[0].Reference = firstPoint.Node;
            line[1].Reference = secondPoint.Node;
            line.ExecuteFunction();

            var line2 = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line2[0].Reference = secondPoint.Node;
            line2[1].Reference = thirdPoint.Node;
            line2.ExecuteFunction();

            var constraintBuilder = new NodeBuilder(document, Constraint2DNames.PerpendicularFunction);
            constraintBuilder[0].Reference = line.Node;
            constraintBuilder[1].Reference = line2.Node;
            document.Commit("Draw");
           
            var docSolverAdapter = new DocumentToSolverAdapter(document, sketchNode);
            docSolverAdapter.ImpactedNodes(firstPoint.Node, firstPoint.Node.Index);
            var error = docSolverAdapter.Solve();

            Assert.IsTrue(error == 0, "Invalid perpendicular solution");
        }

        [Test]
        public void PointOnPointTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var firstPoint = sketch.GetPoint(new Point3D(3, 1, 0));
            var secondPoint = sketch.GetPoint(new Point3D(4, 2, 0));
            document.Commit("Draw");
            var constraintBuilder = new NodeBuilder(document, Constraint2DNames.PointOnPointFunction);
            constraintBuilder[0].Reference = firstPoint.Node;
            constraintBuilder[1].Reference = secondPoint.Node;
            
            var docSolverAdapter = new DocumentToSolverAdapter(document, sketchNode);

            docSolverAdapter.ImpactedNodes(firstPoint.Node, -1);

            docSolverAdapter.Solve();

            firstPoint = new NodeBuilder(firstPoint.Node);
            secondPoint = new NodeBuilder(secondPoint.Node);
            Assert.IsTrue(Math.Abs(firstPoint[1].TransformedPoint3D.X - secondPoint[1].TransformedPoint3D.X) < 0.01,
                          "invalid x axis values");
            Assert.IsTrue(Math.Abs(firstPoint[1].TransformedPoint3D.Y - secondPoint[1].TransformedPoint3D.Y) < 0.01,
                          "invalid y axis values");
        }
    }
}