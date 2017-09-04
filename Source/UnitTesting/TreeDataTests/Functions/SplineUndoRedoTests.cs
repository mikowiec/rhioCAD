#region Usings

using NaroConstants.Names;
using NUnit.Framework;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeDataTests.Functions
{
    [TestFixture]
    public class SplineUndoRedoTests
    {
        private Document _document;
        private NodeBuilder _splineBuilder;

        private void AddPointToSpline(Point3D point)
        {
            _splineBuilder.Node.Get<FunctionInterpreter>().Dependency.AddAttributeType(InterpreterNames.Point3D);
            _splineBuilder[_splineBuilder.Count - 1].TransformedPoint3D = point;
        }

        [Test]
        public void SplineUndoRedoTest()
        {
            _document = TestUtils.DefaultsSetup();
            _document.Transact();
            _splineBuilder = new NodeBuilder(_document, FunctionNames.Spline);

            AddPointToSpline(new Point3D(0, 0, 0));
            AddPointToSpline(new Point3D(1, 0, 0));
            AddPointToSpline(new Point3D(2, 0, 0));
            AddPointToSpline(new Point3D(3, 0, 0));
            var result = _splineBuilder.ExecuteFunction();
            Assert.IsTrue(result);
            _document.Commit("Spline drawn");
            _document.Undo();
            _document.Redo();
            _splineBuilder = new NodeBuilder(_document.Root[0]);
            result = _splineBuilder.Node.Get<FunctionInterpreter>().Execute();
            Assert.IsTrue(result);
        }
    }
}