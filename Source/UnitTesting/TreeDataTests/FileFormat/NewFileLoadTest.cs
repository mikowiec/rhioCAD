#region Usings

using System;
using Naro.PartModeling;
using NaroConstants.Names;
using NaroSetup;
using NUnit.Framework;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;

#endregion

namespace TreeDataTests.FileFormat
{
    [TestFixture]
    public class NewFileLoadTest
    {
        [Test]
        public void TryLoadNewFile()
        {
            try
            {
                var document = TestUtils.DefaultsSetup();

                const string startDir = @"..\..\bin\Debug\";
                document.LoadFromXml(startDir + @"NewFile.naroxml");

                document.Transact();
                var sketchCreator = new SketchCreator(document, false);
                var sketchNode = sketchCreator.BuildSketchNode();


                var builder = new NodeBuilder(document, FunctionNames.Point);
                builder[0].Reference = sketchNode;
                builder[1].TransformedPoint3D = new Point3D(0,10,10);
                Assert.IsTrue(builder.ExecuteFunction());
                document.Commit(@"Check consistency");
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Failed to load NewFile.naroxml Did you change the format of file?");
            }
        }

        [Test]
        public void TryLoadOptions()
        {
            try
            {
                var document = TestUtils.DefaultsSetup();
                var actionsGraph = document.Root.Get<ActionGraphInterpreter>().ActionsGraph;
                const string startDir = @"..\..\bin\Debug\";
                const string fileName = startDir + @"options.nxml";
                var optionsSetup = actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
                optionsSetup.LoadOptions(fileName);

                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Failed to load Options. Did you change the format of file?");
            }
        }
    }
}