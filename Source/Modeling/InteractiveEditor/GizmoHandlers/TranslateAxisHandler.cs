#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Views;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Data;

#endregion

namespace InteractiveEditor.GizmoHandlers
{
    public class TranslateAxisHandler : GenericEditingShapeHandler
    {
        public override int EditingPointsCount()
        {
            return 6;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return index <= 2 ? FunctionNames.AxisHandle : FunctionNames.PlaneHandle;
        }

        public override Color GetHandleColor(int index)
        {
            switch (index)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.DarkGreen;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Red;
                case 4:
                    return Color.DarkGreen;
                case 5:
                    return Color.Blue;
                default:
                    return Color.Red;
            }
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var gizmoOrientation = new gpAx2();
            var nodeBuilder = new NodeBuilder(Node);

            var gravityCenter = GeomUtils.ExtractGravityCenter(nodeBuilder.Shape);

            switch (index)
            {
                case 0:
                    gizmoOrientation.Direction = (gp.OZ.Direction);
                    gizmoOrientation.XDirection = (gp.OX.Direction);
                    break;
                case 1:
                    gizmoOrientation.Direction = (gp.OZ.Direction.Reversed);
                    gizmoOrientation.XDirection = (gp.OY.Direction);
                    break;
                case 2:
                    gizmoOrientation.Direction = (gp.OX.Direction.Reversed);
                    gizmoOrientation.XDirection = (gp.OZ.Direction);
                    break;
                case 3:
                    gizmoOrientation.Direction = (gp.OY.Direction);
                    gizmoOrientation.XDirection = (new gpDir(1, 0, 1));
                    break;
                case 4:
                    gizmoOrientation.Direction = (gp.OZ.Direction);
                    gizmoOrientation.XDirection = (new gpDir(1, 1, 0));
                    break;
                case 5:
                    gizmoOrientation.Direction = (gp.OX.Direction);
                    gizmoOrientation.XDirection = (new gpDir(0, 1, 1));
                    break;
                default:
                    return null;
            }

            gizmoOrientation.Location = (gravityCenter.GpPnt);
            return gizmoOrientation;
        }

        private Point3D GetPointForIndex(Point3D mousePosition, Point3D gravityCenter, int index)
        {
            var newPoint = new Point3D(mousePosition.X, mousePosition.Y, mousePosition.Z);

            switch (index)
            {
                case 0:
                    newPoint.Y = gravityCenter.Y;
                    newPoint.Z = gravityCenter.Z;
                    break;
                case 1:
                    newPoint.X = gravityCenter.X;
                    newPoint.Z = gravityCenter.Z;
                    break;
                case 2:
                    newPoint.Y = gravityCenter.Y;
                    newPoint.X = gravityCenter.X;
                    break;
                case 3:
                    newPoint.Y = gravityCenter.Y;
                    break;
                case 4:
                    newPoint.Z = gravityCenter.Z;
                    break;
                case 5:
                    newPoint.X = gravityCenter.X;
                    break;
            }

            return newPoint;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
           var nodeBuilder = new NodeBuilder(Node);


           if (nodeBuilder.FunctionName == FunctionNames.Trim)
               return;
            var gravityCenter = GeomUtils.ExtractGravityCenter(nodeBuilder.Shape);
            var newPoint = GetPointForIndex(vertex.Point, gravityCenter, index);
            var mouseTranslation = GeomUtils.BuildTranslation((gravityCenter), newPoint);
            var translateValue = newPoint.SubstractCoordinate(gravityCenter);
            var document = Dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document;

            if (! NodeUtils.NodeIsOnSketch(nodeBuilder))
            {
                NodeUtils.Translate3DNode(nodeBuilder, document, translateValue);//, gravityCenter);
            }
            else
            {
                var sketchNode = AutoGroupLogic.FindSketchNode(Node);
                NodeUtils.TranslateSketchNode(nodeBuilder, translateValue, sketchNode);// mouseTranslation);
                
                var constraintMapper = new ConstraintDocumentHelper(document, sketchNode);
                constraintMapper.SetMousePosition(Dependency[0].Reference.Index);
                var error = constraintMapper.ImpactAndSolve(Dependency[0].Node.Get<ReferenceInterpreter>().Node);
            }
        }
    }
}