#region Usings

using System;
using System.Diagnostics;
using Naro.Infrastructure.Library.Algo;
using Naro.PartModeling;
using NaroConstants.Enums;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroSetup;
using NUnit.Framework;
using OccCode;

using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters.Layers;
using ShapeFunctionsInterface.Utils;
using TestsShared;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.OccNoViewTests
{
    [TestFixture]
    public class SaveToXmlTest
    {
        private Document _document;
        private ActionsGraph _actionsGraph;

        private void DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            _actionsGraph = new ActionsGraph();
            _actionsGraph.Register(new FunctionFactoryInput());
            _actionsGraph.Register(new OptionsSetupInput());
            DefaultFunctions.Setup(_actionsGraph);
        }

        [TestFixtureSetUp]
        public void Init()
        {
            DefaultsSetup();

            _document = new Document();
            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
            _document.Transact();
        }

        [Test]
        public void CreateXmlDocument()
        {
            DefaultInterpreters.Setup();
            var watch = new Stopwatch();
            watch.Start();

            _document.Root.Set<LayerContainerInterpreter>();
            _document.Root.Set<ReferenceListInterpreter>();

            var root = _document.Root;
             _document.Transact();
            var sketchCreator = new SketchCreator(_document, false);
            var sketchNode = sketchCreator.BuildSketchNode();
            _document.Commit("Added sketch");
            _document.Transact();
          
            var lineNode = TestUtils.Line(_document, sketchNode, new Point3D(0, 0, 100), new Point3D(1000, 0, 0));
            root.AddChild(lineNode.Node.Index);

            //Sphere is created on one clild.
            var sphereNode = TestShapes.CreateSphere(_document, new Point3D(100, 100, 100), 500);
            root.AddChild(sphereNode.Index);

            var cylinderNode = TestShapes.CreateCylinder(_document,
                                                         new gpAx1(new gpPnt(0, 0, 0),
                                                                      new gpDir(100, 100, 100)),
                                                         400, 600, GeomUtils.DegreesToRadians(360));
            root.AddChild(cylinderNode.Index);

            //var extrudeNode = TestShapes.CreateExtrude(_document, new SceneSelectedEntity(rectNode), -1000);
            //root.AddChild(extrudeNode.Index);

            var ellipseNode1 = TreeUtils.AddEllipseToNode(_document,
                                                          new Point3D(36.8453973968897, -539.199867895986, 100),
                                                          new Point3D(36.8453973968897, -462.199867895986, 100),
                                                          new Point3D(59.8453973968897, -465.119998354144, 100));
            root.AddChild(ellipseNode1.Index);

            var ellipseNode2 = TreeUtils.AddEllipseToNode(_document,
                                                          new Point3D(100, -540.334763318557, 47.2315752446135),
                                                          new Point3D(100, -500.428650277867, 49.9705790751447),
                                                          new Point3D(100, -533.349512728947, 34.6804312289804));
            root.AddChild(ellipseNode2.Index);

            var ellipseNode3 = TreeUtils.AddEllipseToNode(_document, new Point3D(50, -1000, 10),
                                                          new Point3D(90, -1000, 50),
                                                          new Point3D(97.8698501204491, -1000, 31));
            root.AddChild(ellipseNode3.Index);

            var circleNode = TreeUtils.AddCircleToNode(_document,
                                                           new Point3D(45.4376831054688, -380.445983886719, 100), 40);
            root.AddChild(circleNode.Index);

            watch.Stop();
            var ticks = watch.ElapsedMilliseconds;

            watch.Reset();
            watch.Start();
            var cutNode1 = TestShapes.CreateExtrude(_document, new SceneSelectedEntity(ellipseNode1), 100);
            root.AddChild(cutNode1.Index);

            var cutNode2 = TestShapes.CreateExtrude(_document, new SceneSelectedEntity(ellipseNode2), 100);
            root.AddChild(cutNode2.Index);

            var cutNode3 = TestShapes.CreateCut(_document, ellipseNode3, 100, CutTypes.ThroughAll);
            root.AddChild(cutNode3.Index);

            watch.Stop();
            var cutSeconds = watch.ElapsedMilliseconds;

            _document.Root.Set<StringInterpreter>().Value = "New Part";

            _document.Commit("testmethod");
            _document.SaveToXml("test.naroxml");
            _document = new Document();
            _document.LoadFromXml("test.naroxml");
            Console.WriteLine(@"elapsed ticks:{0}", (ticks + cutSeconds));
            Console.WriteLine(@"elapsed cut ticks:{0}", cutSeconds);
        }
    }
}