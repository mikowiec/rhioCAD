#region Usings

using System.Collections.Generic;
using System.Linq;
using NaroConstants.Names;
using NaroSketchAdapter.Views;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
#endregion

namespace NaroSketchSolveTests.ConstraintsSolver
{
    [TestFixture]
    public class ConstraintHighLevelMapperTests
    {
        private static List<string> GetAppliedFunctions(IEnumerable<Node> result)
        {
            return result.Select(node => new NodeBuilder(node).FunctionName).ToList();
        }

        [Test]
        public void AppliedConstraintsMappingTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var pointLinker = sketch.PointLinker;
            var line = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 1, 0), new Point3D(3, 1.5, 0));
            var line2 = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 3, 0), new Point3D(3, 2.5, 0));

            const string constraintFunctionName = Constraint2DNames.ParallelFunction;
            var constraintBuilder = new NodeBuilder(document, constraintFunctionName);
            constraintBuilder[0].Reference = line.Node;
            constraintBuilder[1].Reference = line2.Node;
            document.Commit("Draw");
            var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
            var selection = new List<Node> {line.Node, line2.Node};
            var condition = constraintMapper.IsApplied(selection, constraintFunctionName);
            Assert.IsTrue(condition);
        }


        [Test]
        public void ApplyConstraintTest()
        {
            var document = TestUtils.DefaultsSetup();
            var sketch = new SketchCreator(document);
            var sketchNode = sketch.BuildSketchNode();
            document.Transact();

            var pointLinker = sketch.PointLinker;
            var line = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 1, 0), new Point3D(3, 1.5, 0));
            var line2 = ConstraintUtils.BuildLine(document, pointLinker, new Point3D(1, 3, 0), new Point3D(3, 2.5, 0));


            document.Commit("Draw");
            var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
            var result = constraintMapper.ApplyConstraint(new List<Node> {line.Node, line2.Node},
                                                          Constraint2DNames.ParallelFunction);

            Assert.IsTrue(result.LastExecute);
        }

        [Test]
        public void CheckAppliedConstraintTest()
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
            var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
            var result = constraintMapper.CheckAppliedConstraints(new List<Node> {line.Node, line2.Node});
            var appliedFunctions = GetAppliedFunctions(result);
            Assert.IsTrue(appliedFunctions.Contains(Constraint2DNames.ParallelFunction));
        }

        [Test]
        public void ConstraintAccessibleMappingTest()
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
            var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
            var result = constraintMapper.GetPossibleConstraints(new List<Node> {line.Node, line2.Node});
            Assert.IsTrue(result.Contains(Constraint2DNames.ParallelFunction));
            Assert.IsTrue(result.Contains(Constraint2DNames.PerpendicularFunction));
        }

        [Test]
        public void RemoveConstraintTest()
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
            var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
            constraintMapper.Remove(line.Node, line2.Node, Constraint2DNames.ParallelFunction);

            document.Commit("Draw");

            var result = constraintMapper.CheckAppliedConstraints(new List<Node> {line.Node, line2.Node});

            Assert.IsTrue(result.Count == 0);
        }
    }
}