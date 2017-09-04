#region Usings

using System.Drawing;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    public class PointAction : DrawingLiveShape
    {
        public PointAction() : base(ModifierNames.Point3D)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        public override void OnActivate()
        {
            base.OnActivate();

            //var sketchCreator = new SketchCreator(Document, false);
            //if (sketchCreator.CurrentSketch == null)
            //{
            //    BackToNeutralModifier();
            //    return;
            //}

            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.Point3D);
                return;
            }
            var axis = sketchBuilder.NormalOnSketch.Value;
            var trsf = sketchBuilder.CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            axis.Location = new Point3D(axis.Location.GpPnt.Transformed(trsf));
            // Block drawing plane
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
            //Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane,
            //                                          new gpPln(axis.GpAxis.Location,
            //                                                       axis.GpAxis.Direction));
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);

            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            Reset();
        }

        private void Reset()
        {
            Points.Clear();
            ShowHint(ModelingResources.PointStep1);
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var text = (string) data.Data;
            if (text.Contains(","))
            {
                var coordinate = new Point3D();
                CoordinateParser.ParsePointValue(text, coordinate);
                AddNewPoint(coordinate);
                return;
            }
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            AddNewPoint(mouseData.Point);
        }

        public override void OnDeactivate()
        {
            InitAnimateSession();
            Reset();

            // Unblock drawing plane
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);

            base.OnDeactivate();
        }

        private void AddNewPoint(Point3D coordinate)
        {
            InitSession();
            var sketchCreator = new SketchCreator(Document, false);
            var builder = GetSketchNode(Document, coordinate, sketchCreator.CurrentSketch);

            AddNodeToTree(builder.Node);
            CommitFinal("Added point to scene");
            UpdateView();
            Reset();
        }
    }
}