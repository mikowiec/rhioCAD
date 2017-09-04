#region Usings

using MetaActionsInterface;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using NUnit.Framework;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace MetaActionFakesInterface
{
    public static class ShapeBuildHelper
    {
        private static void BuildTestSpheres(SetupUtils setup)
        {
            var document = setup.Document;
            AddTwoIntersectingSpeherestoDocument(document);
            Assert.AreEqual(document.Root.Children.Count, 3);
        }

        public static void AddTwoIntersectingSpeherestoDocument(Document document)
        {
            document.Transact();
            var firstSphereCenter = new Point3D(100, 100, 100);
            var secondSphereCenter = new Point3D(200, 200, 200);

            const double spheresRadius = (double) 100;

            var transformationPointOne = GeomUtils.BuildTranslation(new Point3D(0, 0, 0), firstSphereCenter);
            var transformationPointTwo = GeomUtils.BuildTranslation(new Point3D(0, 0, 0),
                                                                    secondSphereCenter);
            var firstGpSpherePoint = firstSphereCenter.GpPnt.Transformed(transformationPointOne.Inverted);
            var secondGpSpherePoint = secondSphereCenter.GpPnt.Transformed(transformationPointTwo.Inverted);

            var testSphereBuilder = new NodeBuilder(document, FunctionNames.Sphere);
            testSphereBuilder[0].TransformedPoint3D = new Point3D(firstGpSpherePoint);
            testSphereBuilder[1].Real = spheresRadius;
            testSphereBuilder.Node.Set<TransformationInterpreter>().CurrTransform = transformationPointOne;
            testSphereBuilder.ExecuteFunction();

            testSphereBuilder = new NodeBuilder(document, FunctionNames.Sphere);
            testSphereBuilder[0].TransformedPoint3D = new Point3D(secondGpSpherePoint);
            testSphereBuilder[1].Real = spheresRadius;
            testSphereBuilder.Node.Set<TransformationInterpreter>().CurrTransform = transformationPointTwo;
            testSphereBuilder.ExecuteFunction();
            document.Commit("Added spheres");
        }

        public static void BuildMetaActionTestBoolAdd(SetupUtils setup)
        {
            BuildTestSpheres(setup);

            setup.SwitchUserMetaAction(ModifierNames.BooleanAdd);

            // Push two points on meta action and check that it works correctly

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.BooleanAdd]);
            var dependency = container.Dependency;

            var firstSphere = new SceneSelectedEntity(setup.Document.Root.Children[1]);
            var secondSphere = new SceneSelectedEntity(setup.Document.Root.Children[2]);

            dependency.Steps[2].Integer = 1;
            dependency.Steps[2].IsDefaultValue = true;

            dependency.ProposeCandidate(firstSphere);
            container.PushValue(firstSphere);

            dependency.ProposeCandidate(secondSphere);
            container.PushValue(secondSphere);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestBoolIntersect(SetupUtils setup)
        {
            BuildTestSpheres(setup);

            setup.SwitchUserMetaAction(ModifierNames.BooleanIntersect);

            // Push two points on meta action and check that it works correctly

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.BooleanIntersect]);
            var dependency = container.Dependency;


            var firstSphere = new SceneSelectedEntity(setup.Document.Root.Children[1]);
            var secondSphere = new SceneSelectedEntity(setup.Document.Root.Children[2]);

            dependency.Steps[2].Integer = 2;
            dependency.Steps[2].IsDefaultValue = true;

            dependency.ProposeCandidate(firstSphere);
            container.PushValue(firstSphere);

            dependency.ProposeCandidate(secondSphere);
            container.PushValue(secondSphere);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestBoolCut(SetupUtils setup)
        {
            BuildTestSpheres(setup);

            setup.SwitchUserMetaAction(ModifierNames.BooleanSubstract);

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.BooleanSubstract]);
            var dependency = container.Dependency;


            var firstSphere = new SceneSelectedEntity(setup.Document.Root.Children[1]);
            var secondSphere = new SceneSelectedEntity(setup.Document.Root.Children[2]);

            dependency.Steps[2].Integer = 0;
            dependency.Steps[2].IsDefaultValue = true;

            dependency.ProposeCandidate(firstSphere);
            container.PushValue(firstSphere);

            dependency.ProposeCandidate(secondSphere);
            container.PushValue(secondSphere);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestBox(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Box);

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.Box]);
            var dependency = container.Dependency;

            var axis = new gpAx1(new gpPnt(100, 100, 100), new gpDir(0, 0, 1));

            dependency.ProposeCandidate(axis);
            container.PushValue(axis);

            var secondPoint = new Point3D(200, 200, 100);
            dependency.ProposeCandidate(secondPoint);
            container.PushValue(secondPoint);

            dependency.ProposeCandidate((double) 200);
            container.PushValue((double) 200);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestFourLinesRectangle(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.FourLinesRectangle);

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);

            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestThreePointsRectangle(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.ThreePointsRectangle);

            setup.MouseInput.MouseDown(0, 100, 1, false, false);
            setup.MouseInput.MouseUp(0, 100, false, false);

            setup.MouseInput.MouseDown(100, 0, 1, false, false);
            setup.MouseInput.MouseUp(100, 0, false, false);

            setup.MouseInput.MouseDown(300, 200, 1, false, false);
            setup.MouseInput.MouseUp(300, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }


        public static void BuildTestCSEArc(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.ArcCenterStartEnd);

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);

            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);

            setup.MouseInput.MouseDown(0, 200, 1, false, false);
            setup.MouseInput.MouseUp(0, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestSERArc(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.ArcStartEndRadius);

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);

            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);

            setup.MouseInput.MouseDown(0, 200, 1, false, false);
            setup.MouseInput.MouseUp(0, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestCircleUsingClicks(SetupUtils setup)
        {
            setup.SwitchUserAction(ModifierNames.DrawCircle);

            // Push two points on meta action and check that it works correctly

            setup.MouseInput.MouseDown(100, 200, 1, false, false);
            setup.MouseInput.MouseUp(100, 200, false, false);

            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestPointUsingClicks(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Point3D);

            setup.MouseInput.MouseDown(100, 200, 1, false, false);
            setup.MouseInput.MouseUp(100, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestCone(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Cone);

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.Cone]);
            var dependency = container.Dependency;

            var axis = new gpAx1(new gpPnt(100, 100, 100), new gpDir(0, 0, 1));

            dependency.ProposeCandidate(axis);
            container.PushValue(axis);

            // we only add two values because the others are defaults and are automatically added
            dependency.ProposeCandidate((double) 10);
            container.PushValue((double) 10);

            dependency.ProposeCandidate((double) 20);
            container.PushValue((double) 20);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestCylinder(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Cylinder);

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.Cylinder]);
            var dependency = container.Dependency;

            var axis = new gpAx1(new gpPnt(100, 100, 100), new gpDir(0, 0, 1));

            dependency.ProposeCandidate(axis);
            container.PushValue(axis);

            dependency.ProposeCandidate((double) 100);
            container.PushValue((double) 100);

            dependency.ProposeCandidate((double) 200);
            container.PushValue((double) 200);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestEllipseUsingClicks(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Ellipse);

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);

            setup.MouseInput.MouseDown(200, 100, 1, false, false);
            setup.MouseInput.MouseUp(200, 100, false, false);

            setup.MouseInput.MouseDown(100, 50, 1, false, false);
            setup.MouseInput.MouseUp(100, 50, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildTestLineUsingClicks(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Line3D);

            // Push two points on meta action and check that it works correctly

            setup.MouseInput.MouseDown(100, 100, 1, false, false);
            setup.MouseInput.MouseUp(100, 100, false, false);

            setup.MouseInput.MouseDown(200, 200, 1, false, false);
            setup.MouseInput.MouseUp(200, 200, false, false);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestSphere(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Sphere);

            // Push two points on meta action and check that it works correctly

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.Sphere]);
            var dependency = container.Dependency;

            var center = new Point3D(100, 100, 100);
            dependency.ProposeCandidate(center);
            container.PushValue(center);

            dependency.ProposeCandidate((double) 200);
            container.PushValue((double) 200);

            setup.SwitchUserAction(ModifierNames.None);
        }

        public static void BuildMetaActionTestTorus(SetupUtils setup)
        {
            setup.SwitchUserMetaAction(ModifierNames.Torus);

            // Push two points on meta action and check that it works correctly

            var container = ((MetaActionContainer) setup.ActionGraph.ModifierContainer[ModifierNames.Torus]);
            var dependency = container.Dependency;

            var axis = new gpAx1(new gpPnt(100, 100, 100), new gpDir(0, 0, 1));

            dependency.ProposeCandidate(axis);
            container.PushValue(axis);

            dependency.ProposeCandidate((double) 100);
            container.PushValue((double) 100);

            dependency.ProposeCandidate((double) 200);
            container.PushValue((double) 200);

            setup.SwitchUserAction(ModifierNames.None);
        }
    }
}