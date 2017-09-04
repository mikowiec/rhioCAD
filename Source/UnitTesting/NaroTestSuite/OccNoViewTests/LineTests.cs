#region Usings

using MetaActionFakesInterface;
using NaroPipes.Constants;
using NUnit.Framework;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroTestSuite.OccNoViewTests
{
    [TestFixture]
    public class LineTests : MetaActionsTestBase
    {
        [Test]
        public void ZeroLengthLine()
        {
            Setup.Document.Root.Set<DocumentContextInterpreter>();

            var node = TestShapes.CreateLine(Setup.Document, new Point3D(0, 0, 0), new Point3D(0, 0, 0));

            Assert.AreEqual(null, node.Get<NamedShapeInterpreter>().Shape);
        }
    }
}