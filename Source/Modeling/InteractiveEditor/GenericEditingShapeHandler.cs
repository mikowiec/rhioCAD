#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System.Linq;
#endregion

namespace InteractiveEditor
{
    public class GenericEditingShapeHandler
    {
        private readonly Dictionary<Node, int> _handles = new Dictionary<Node, int>();
        protected FunctionDependency Dependency;
        public bool IsDragging { get; set; }
        public int DraggingIndex { get; private set; }
        public Node Node { get; private set; }
        public SceneSelectedEntity SelectedEntity { get; private set; }
        public Document Document { get; set; }


        /// <summary>
        ///   Called when a vertex is dragged.
        /// </summary>
        public virtual void MouseDrag(Mouse3DPosition mouseData)
        {
            if (IsDragging)
                if (Math.Abs(mouseData.Initial2Dx - startX) > 3 || Math.Abs(mouseData.Initial2Dy - startY) > 3)
                UpdatePointPosition(DraggingIndex, mouseData);
        }

        public int startX;
        public int startY;

        public gpPnt previousMousePosition;
        public gpDir initialDirection;
        public int prevFaceCount;
        public TopoDSShape selectedShape;

        /// <summary>
        ///   Called when an dragging operation starts.
        /// </summary>
        public virtual void StartDragging(Node handleNode)
        {
            IsDragging = true;
            DraggingIndex = _handles[handleNode];
        }

        public void StartDragging(SceneSelectedEntity handleNode)
        {
            IsDragging = true;
            if (SelectedEntity.ShapeType == TopAbsShapeEnum.TopAbs_FACE)
            {
                selectedShape = SelectedEntity.TargetShape();
                prevFaceCount = -1;
                initialDirection = GeomUtils.ExtractDirection(SelectedEntity.TargetShape());
                DraggingIndex = 0;// _handles[FunctionNames.AxisHandle];
            }
        }

        /// <summary>
        ///   Called when the dragging operation ends.
        /// </summary>
        public virtual void EndDragging(Mouse3DPosition mouseData)
        {
            if (IsDragging)
            {
                prevFaceCount = -1;
                IsDragging = false;
                Document.Commit("Finished dragging");
                selectedShape = null;
            }
        }

        public virtual void DisplayHandles()
        {
            var noPoints = EditingPointsCount();
            for (var i = 0; i < noPoints; i++)
                DisplayHandle(i, Document);
        }

        public void DisplayHandle(int handleIndex, Document editingDocument)
        {
            var handleType = GetHandleTypeAtIndex(handleIndex);
            var handleOrientation = GetPointLocation(handleIndex);
            if (handleOrientation == null)
                return;
            var length = CoreGlobalPreferencesSingleton.Instance.ZoomLevel;
            var height = 0.3;
            if(handleType == FunctionNames.AxisHandle)
            {
                var solids = new List<string>();
                solids.AddRange(FunctionNames.GetSolids());
                solids.Add(FunctionNames.Extrude);
                solids.Add(FunctionNames.Cut);
                if(Node.Get<FunctionInterpreter>() != null && solids.Contains(Node.Get<FunctionInterpreter>().Name))
                {
                    length *= 10;
                }
                else
                {
                    height /= 10;
                }
            }
            var nodeBuilder = new NodeBuilder(editingDocument, handleType);
            nodeBuilder[0].Axis3D = new Axis(handleOrientation.Axis);
            nodeBuilder[1].Axis3D = new Axis(new gpAx1(handleOrientation.Location, handleOrientation.XDirection));
            nodeBuilder[2].Real = length;
            nodeBuilder[3].Real = height;
            nodeBuilder.Node.Set<TransformationInterpreter>().Translate = new gpPnt();
            nodeBuilder.Color = GetHandleColor(handleIndex);
            if (nodeBuilder.ExecuteFunction())
                _handles[nodeBuilder.Node] = handleIndex;
        }

        public virtual int EditingPointsCount()
        {
            return Dependency.Count;
        }

        public virtual gpAx2 GetPointLocation(int index)
        {
            return GetTranslatedPoint(index);
        }

        public virtual string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.BoxEditingHandle;
        }

        public virtual Color GetHandleColor(int index)
        {
            return Color.Red;
        }

        public virtual void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            UpdateTranslatedPoint(index, vertex.Point);
        }

        public void SetNode(Node shape)
        {
            Node = shape;
            if (Node.Get<FunctionInterpreter>() == null)
                return;
            Dependency = Node.Get<FunctionInterpreter>().Dependency;
        }

        public void SetSelectedEntity(SceneSelectedEntity shape)
        {
            SelectedEntity = shape;
        }

        protected gpAx2 GetTranslatedPoint(int index)
        {
            return NodeUtils.GetTranslatedPoint(Node, index);
        }

        private void UpdateTranslatedPoint(int index, Point3D vertex)
        {
            if (index > Dependency.Count || index < 0)
                return;
            switch (Dependency[index].Name)
            {
                case InterpreterNames.Point3D:
                    Dependency[index].TransformedPoint3D = vertex;
                    break;
                case InterpreterNames.Axis3D:
                    var axis = new gpAx1();
                    axis.Location = (vertex.GpPnt);
                    axis.Direction = (Dependency[index].Axis3D.GpAxis.Direction);
                    Dependency[index].Axis3D = new Axis(axis);
                    break;
            }
            return;
        }
    }
}