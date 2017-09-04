#region Usings
using Naro.Infrastructure.Library.Qos;
using Naro.PartModeling;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroSetup;
using NaroSketchAdapter.Common;
using PartModellingLogic;
using ShapeFunctions.Functions.Naro;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TestsShared
{
    public static class TestUtils
    {
        public static Document DefaultsSetup()
        {
            DefaultInterpreters.Setup();
            AttributeInterpreterFactory.Register<ActionGraphInterpreter>();
            var actionsGraph = new ActionsGraph();
            actionsGraph.Register(new FunctionFactoryInput());
            actionsGraph.Register(new OptionsSetupInput());
            DefaultFunctions.Setup(actionsGraph);
            var constraintsFunctionsSetup = new DefaultConstraintFunctions();
            constraintsFunctionsSetup.Setup(actionsGraph);

            QosCreate();

            var document = new Document();
            document.Transact();
            document.Root.Set<ActionGraphInterpreter>().ActionsGraph = actionsGraph;
            document.Root.Set<DocumentContextInterpreter>().Document = document;
            document.Commit("document setup");
            return document;
        }

        public static NodeBuilder Point(Document document, Node sketchNode, Point3D point)
        {
            var pointBuilder = new NodeBuilder(document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = point;
            pointBuilder.ExecuteFunction();
            return pointBuilder;
        }

        public static NodeBuilder Circle(Document document, Node sketchNode, Point3D center, double radius)
        {
            var pointBuilder = Point(document, sketchNode, center);
            var circle = new NodeBuilder(document, FunctionNames.Circle);
            circle[0].Reference = pointBuilder.Node;
            circle[1].Real = radius;
            circle.ExecuteFunction();
            return circle;
        }

        public static NodeBuilder Arc(Document document, Node sketchNode, Point3D center, Point3D start, Point3D end)
        {
            var pointBuilder1 = Point(document, sketchNode, center);
            var pointBuilder2 = Point(document, sketchNode, start);
            var pointBuilder3 = Point(document, sketchNode, end);
            var arc = new NodeBuilder(document, FunctionNames.Arc);
            arc[0].Reference = pointBuilder1.Node;
            arc[1].Reference = pointBuilder2.Node;
            arc[2].Reference = pointBuilder3.Node;
            arc.ExecuteFunction();
            return arc;
        }

        public static NodeBuilder Line(Document document, Node sketchNode, Point3D point1, Point3D point2)
        {
            var point1Builder = Point(document, sketchNode, point1);
            var point2Builder = Point(document, sketchNode, point2);
            var lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = point1Builder.Node;
            lineBuilder[1].Reference = point2Builder.Node;
            lineBuilder.ExecuteFunction();
            return lineBuilder;
        }

        public static void BuildRectangle(Document document, Node sketchNode, Point3D point1, Point3D point2, Point3D point3, Point3D point4)
        {
            var point1Builder = Point(document, sketchNode, point1);
            var point2Builder = Point(document, sketchNode, point2);
            var point3Builder = Point(document, sketchNode, point3);
            var point4Builder = Point(document, sketchNode, point4);
            var lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = point1Builder.Node;
            lineBuilder[1].Reference = point2Builder.Node;
            lineBuilder.ExecuteFunction();
            lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = point2Builder.Node;
            lineBuilder[1].Reference = point3Builder.Node;
            lineBuilder.ExecuteFunction();
            lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = point3Builder.Node;
            lineBuilder[1].Reference = point4Builder.Node;
            lineBuilder.ExecuteFunction();
            lineBuilder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            lineBuilder[0].Reference = point4Builder.Node;
            lineBuilder[1].Reference = point1Builder.Node;
            lineBuilder.ExecuteFunction();
        }

        private static void QosCreate()
        {
            QosFactory.Instance.Create(QosNames.PointMatchLock, 120,
                                       "Point Matching works too slow! Do you want to disable it?").Payload += () => { };
            QosFactory.Instance.Create(QosNames.EdgeMatchLock, 120,
                                       "Edge Matching works too slow! Do you want to disable it?").Payload += () => { };
            QosFactory.Instance.Create(QosNames.EdgeContinuationMatchLock, 120,
                                       "Edge Continuation Matching works too slow! Do you want to disable it?").Payload
                += () => { };
            QosFactory.Instance.Create(QosNames.PlaneMatchLock, 120,
                                       "Plane Matching works too slow! Do you want to disable it?").Payload += () => { };
            QosFactory.Instance.Create(QosNames.ParallelLineLock, 120,
                                       "Parallel Line Matching works too slow! Do you want to disable it?").Payload +=
                () => { };
            QosFactory.Instance.Create(QosNames.VerticalLineMatchLock, 120,
                                       "Vertical Line Matching works too slow! Do you want to disable it?").Payload +=
                () => { };
            QosFactory.Instance.Create(QosNames.HorizontalLineMatchLock, 120,
                                       "Horizontal Line Matching works too slow! Do you want to disable it?").Payload +=
                () => { };
            QosFactory.Instance.Create(QosNames.EdgeIntersectionLock, 120,
                                       "Edge Intersection precomputation works too slow! Do you want to disable it?").
                Payload += () => { };
        }
    }
}