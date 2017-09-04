#region Usings

using System.Collections.Generic;
using System.Drawing;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.AppUtils;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    public abstract class SplineBasedAction : DrawingLiveShape
    {
        protected int DefinedPointCount;
        protected int EditedPointIndex;
        protected List<Point3D> SplineControlPoints;

        protected SplineBasedAction(string modifierName) : base(modifierName)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
            SplineControlPoints = new List<Point3D>();
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var coordinate = data.Get<Point3D>();
            if (EditedPointIndex != -1)
            {
                SplineControlPoints[EditedPointIndex] = coordinate;
                PreviewSpinePath();
                EditedPointIndex = -1;
            }
            else
                AddToPointList(coordinate);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            DefinedPointCount = 0;
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.PointAsked);
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Suspend);
            var fastAccessTools = new SplineFastAccessTools(ActionsGraph);
            RibbonPanel.Children.Add(fastAccessTools);
            Document.Transact();

            Points.Add(new Point3D());
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.Resume);
        }

        private NodeBuilder SetSplineBuilder(ICollection<Point3D> pointList)
        {
            var builder = new NodeBuilder(Document, FunctionNames.SplinePath);
            builder[0].Integer = pointList.Count;
            var i = 0;
            foreach (var point3D in pointList)
            {
                builder.Node.Get<FunctionInterpreter>().Dependency.AddAttributeType(InterpreterNames.Point3D);
                builder[i + 1].TransformedPoint3D = point3D;
                i++;
            }

            return builder;
        }

        protected NodeBuilder BuildSplineLogicalPoints(bool drawHandlers)
        {
            RegenerateSplinePointList();
            var pointList = SplineControlPoints.ToArray();
            var builder = SetSplineBuilder(pointList);
            builder.ExecuteFunction();
            if (!drawHandlers) return builder;
            DrawMarkerLine(pointList[0], pointList[1], Color.Black);
            DrawMarkerLine(pointList[2], pointList[3], Color.Black);
            for (var i = 1; i < (pointList.Length - 1)/3; i++)
            {
                DrawMarkerLine(pointList[i*3 + 0], pointList[i*3 + 1], Color.Black);
                DrawMarkerLine(pointList[i*3 + 2], pointList[i*3 + 3]);
            }
            return builder;
        }

        private void RegenerateSplinePointList()
        {
            GenerateHandlerPointList();
        }

        private void DrawMarkerLine(Point3D firstPoint, Point3D lastPoint)
        {
            DrawDottedLine(firstPoint, lastPoint, Color.Black);
        }

        private void DrawMarkerLine(Point3D firstPoint, Point3D lastPoint, Color color)
        {
            DrawDottedLine(firstPoint, lastPoint, color);
        }

        private void DrawDottedLine(Point3D first, Point3D second, Color color)
        {
            var lineBuilder = new NodeBuilder(Document, FunctionNames.DottedLine);
            lineBuilder[0].TransformedPoint3D = first;
            lineBuilder[1].TransformedPoint3D = second;
            lineBuilder.ExecuteFunction();
            lineBuilder.Color = color;
        }

        protected abstract void GenerateHandlerPointList();

        protected void PreviewSpinePath()
        {
            var size = Points.Count;
            InitSession();
            DrawMarkerBox(Points[Points.Count - 1], 0.01);
            if (size < 2)
                return;
            switch (size)
            {
                case 2:
                    DrawLine(Points[0], Points[1]);
                    return;
            }
            BuildSplineLogicalPoints(true);
        }

        protected int HandleEditingPoints(Mouse3DPosition mouseData)
        {
            var zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*2.0;
            var coordinate = mouseData.Point;
            var pos = 0;
            foreach (var point in SplineControlPoints)
            {
                pos++;
                if (pos >= DefinedPointCount) return -1;
                if (coordinate.Distance(point) >= zoom) continue;
                return pos - 1;
            }
            return -1;
        }

        protected bool MouseMoveHandled(Mouse3DPosition mouseData)
        {
            var handled = false;
            if (EditedPointIndex != -1)
            {
                handled = true;
                SplineControlPoints[EditedPointIndex] = mouseData.Point;
                PreviewSpinePath();
            }
            else if (HandleEditingPoints(mouseData) != -1)
            {
                handled = true;
                PreviewSpinePath();
                ShowHint("Drag to move");
            }
            return handled;
        }

        protected void UpdateControlPointSize(int count)
        {
            while (SplineControlPoints.Count < count)
                SplineControlPoints.Add(new Point3D());
            while (SplineControlPoints.Count > count)
                SplineControlPoints.RemoveAt(SplineControlPoints.Count - 1);
        }
    }
}