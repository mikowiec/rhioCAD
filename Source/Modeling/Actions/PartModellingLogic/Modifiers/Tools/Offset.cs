#region Usings

using System.Collections.Generic;
using System.Drawing;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.IntTools;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Precision;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class Offset : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Offset));

        private List<SceneSelectedEntity> _selectedNodes = new List<SceneSelectedEntity>();

        public Offset()
            : base(ModifierNames.Offset)
        {
        }

        public override void OnActivate()
        {
            Reset();
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            _selectedNodes = entities;
            if (_selectedNodes.Count == 0)
            {
                BackToNeutralModifier();
            }
        }

        private void Reset()
        {
            // Suspend the face picker
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
        }

        /// <summary>
        ///   Returns 1 if the point is outside te face and -1 is inside or on the face.
        /// </summary>
        /// <param name = "point"></param>
        /// <returns></returns>
        private int GetDirection(gpPnt point)
        {
            var direction = 1;
            if (_selectedNodes[0].ShapeType == TopAbsShapeEnum.TopAbs_FACE)
            {
                var face = TopoDS.Face(_selectedNodes[0].Node.Get<TopoDsShapeInterpreter>().Shape);
                var classifier = new IntToolsContext();
                if (classifier.IsValidPointForFace(point, face, Precision.Confusion))
                {
                    direction = -1;
                }
            }
            return direction;
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            // Start an offset drawing process
            // At mouse down pick the selected edge
            if (!mouseData.MouseDown)
            {
                return;
            }

            AddToPointList(mouseData.Point);


            if (Points.Count == 1)
            {
                Log.Info("Offset - started");
                return;
            }


            Log.Info("Offset - finished");
            var direction = GetDirection(mouseData.Point.GpPnt);
            InitSession();
            var builder = new NodeBuilder(Document, FunctionNames.Offset);
            builder[0].ReferenceList = _selectedNodes;
            builder[1].Real = direction*Points[0].Distance(mouseData.Point);

            // Close all local contexts
            Context.CloseAllContexts(true);

            if (!builder.ExecuteFunction())
            {
                Document.Revert();
                BackToNeutralModifier();
                return;
            }

            // Finish the transaction
            CommitFinal("Apply offset");

            UpdateView();
            AddNodeToTree(builder.Node);

            BackToNeutralModifier();
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (Points.Count == 0)
                return;

            // Check if it is outer or inner offset
            var direction = GetDirection(mouseData.Point.GpPnt);

            InitSession();
            var builder = CreateTemporaryBuilder(FunctionNames.Offset);
            builder[0].ReferenceList = _selectedNodes;
            builder[1].Real = direction*Points[0].Distance(mouseData.Point);
            builder.Color = Color.Red;
            builder.ExecuteFunction();
            UpdateView();
        }
    }
}