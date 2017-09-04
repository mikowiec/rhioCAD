#region Usings

using MetaActionFakesInterface;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionTests.Actions
{
    [TestFixture]
    public class PointTransformationTests : MetaActionsTestBase
    {
        private readonly Point3D _testedFirstPoint = new Point3D(100, 200, 0);

        [Test]
        public void PointToolTransformationTest()
        {
            ShapeBuildHelper.BuildTestPointUsingClicks(Setup);
            Assert.AreEqual(2, Setup.Document.Root.Children.Count);
            var nodeBuilder = new NodeBuilder(Setup.Document.Root.Children[1]);
            
            Assert.AreEqual(nodeBuilder[1].TransformedPoint3D.IsEqual(_testedFirstPoint), true,
                            "Invalid first point coordinate");
        }
    }
}