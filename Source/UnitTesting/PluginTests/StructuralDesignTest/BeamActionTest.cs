#region Usings

using MetaActionFakesInterface;
using MetaActionsInterface;
using NaroCAD.Plugin.Structural.Design;
using NaroConstants.Names;
using NaroPipes.Constants;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PluginTests.StructuralDesignTest
{
    [TestFixture]
    public class BeamActionTest : MetaActionsTestBase
    {
        private readonly Point3D _point1 = new Point3D(0, 500, 0);
        private readonly Point3D _point2 = new Point3D(1000, 500, 0);

        private static void BuildPoint(Document document, Point3D point3D)
        {
            var builder = new NodeBuilder(document, FunctionNames.Point);
            builder[0].TransformedPoint3D = point3D;
            builder.ExecuteFunction();
        }

        [Test]
        public void BeamActionReference()
        {
            var actionsGraph = Setup.ActionGraph;
            var modifierRegister = new ModifierRegister();
            modifierRegister.Register(actionsGraph);

            Setup.Document.Transact();
            BuildPoint(Setup.Document, _point1);
            BuildPoint(Setup.Document, _point2);
            Setup.Document.Commit("Draw initial shapes");

            Setup.SwitchUserAction(ModifierNames.None);

            Assert.AreEqual(2, Setup.Document.Root.Children.Count, "The first two shapes aren't drawn");

            Setup.SwitchUserAction(Constant.ActionBeam);
            var container = ((MetaActionContainer) Setup.ActionGraph.ModifierContainer[Constant.ActionBeam]);
            var dependency = container.Dependency;

            var firstPoint = new SceneSelectedEntity(Setup.Document.Root.Children[0]);
            var secondPoint = new SceneSelectedEntity(Setup.Document.Root.Children[1]);

            dependency.ProposeCandidate(firstPoint);
            container.PushValue(firstPoint);

            dependency.ProposeCandidate(secondPoint);
            container.PushValue(secondPoint);

            Setup.SwitchUserAction(ModifierNames.None);

            Assert.AreEqual(3, Setup.Document.Root.Children.Count);
        }
    }
}