#region Usings

using System;
using System.Threading;
using ModellingToolsPlugin;
using ModellingToolsPlugin.Booleans;
using ModellingToolsPlugin.Features;
using ModellingToolsPlugin.Selection;
using ModellingToolsPlugin.Sketch;
using ModellingToolsPlugin.Solid;
using ModellingToolsPlugin.Tools;
using NaroConstants.Names;
using NaroUiBuilder;
using NUnit.Framework;
using PluginTests.Common;

#endregion

namespace PluginTests.ModellingToolsPluginTest
{
    [TestFixture]
    public class ModifierRegisterTest : ModifierRegisterBase
    {
        private readonly ModifierRegister _sut = new ModifierRegister();

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void RegisterNullArgument()
        {
            _sut.Register(null);
        }

        [Test]
        public void RegisterUi()
        {
            Assert.AreEqual(ApartmentState.STA, Thread.CurrentThread.GetApartmentState());

            var actionsGraph = Setup.ActionGraph;
            Assert.IsNotNull(actionsGraph);
            var uiBuilderInput = actionsGraph[InputNames.UiBuilderInput];
            var dataPackage = uiBuilderInput.GetData(NotificationNames.GetValue);
            Assert.IsNotNull(dataPackage);
            var uiBuilder = dataPackage.Get<UiBuilder>();
            Assert.IsNotNull(uiBuilder);

            _sut.Register(actionsGraph);

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Cursor", typeof (CursorToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Point", typeof (PointToolButton));
            //TODO: test extra buttons
            //CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Rectangle", typeof(RectangleToolButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/RectangleTools", typeof (RectangleToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Line", typeof (LineToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Spline", typeof (SplineToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Circle", typeof (CircleToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Arc", typeof (ArcToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Sketch/Dimension", typeof (DimensionToolButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Solid", typeof (SolidsToolsGroup));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Selection/Selection", typeof (SelectionToolsSplitButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Gizmos/GizmoNone", typeof (GizmoTypeNoneButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Gizmos/GizmoTranslate", typeof (GizmoTypeTranslateButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Gizmos/GizmoRotate", typeof (GizmoTypeRotateButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Gizmos/GizmoScale", typeof (GizmoTypeScaleButton));


            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Extrude", typeof (ExtrudeToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Cut", typeof (CutToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Pipe", typeof (PipeToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Revolve", typeof (RevolveToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Fillet", typeof (ChamferFilletToolsSplitButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/Sew", typeof (SewToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Features/AngleDraft", typeof (AngleDraftToolButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Boolean/Fuse", typeof (FuseToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Boolean/Intersect", typeof (IntersectToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Boolean/Substract", typeof (SubstractToolButton));

            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/Translate", typeof (TranslateToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/Copy", typeof (CopyToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/RotateAxis", typeof (RotateAroundAxisButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/CircularPattern", typeof (CircularPatternButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/ArrayPattern", typeof (ArrayPatternButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/Offset2D", typeof (Offset2DToolButton));
            CheckRibbonButton(uiBuilder, "Ribbon/Modelling/Tools/Mirror", typeof (MirrorToolsSplitButton));
        }
    }
}