#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NUnit.Framework;

using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.ImportExportStep
{
    [TestFixture]
    internal class ImportExportStepTests
    {
        [Test]
        public void ImportExportRectangleTest()
        {
            var document = TestUtils.DefaultsSetup();
            document.Transact();
            var builder = new NodeBuilder(document, FunctionNames.Rectangle);
            builder[0].Axis3D = new Axis(new gpAx1());
            document.Commit("Drawn rectangle");
        }
    }
}