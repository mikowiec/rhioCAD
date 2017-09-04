#region Usings

using System.Collections.Generic;
using System.Drawing;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;

using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    internal class MirrorEntireScenePipe : ViewBasedPipe
    {
        private readonly Document _mirrorDocument;
        private readonly List<AISShape> _mirrorShapeList;
        private readonly double _range;
        private AISInteractiveContext _context;
        private Document _document;

        public MirrorEntireScenePipe()
            : base(InputNames.MirrorEntireScenePipe)
        {
            _mirrorDocument = new Document();
            _mirrorShapeList = new List<AISShape>();
            _range = 2000;
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.Context, SourceContextHandler);
            DependsOn(InputNames.Document, SourceDocumentHandler);
        }

        private void GetCacheItem(int index, gpTrsf mirrorTransform)
        {
            var node = _document.Root.Children[index];
            var builder = new NodeBuilder(node);
            MirrorBuilder(builder, mirrorTransform);
        }

        private void MirrorBuilder(NodeBuilder builder, gpTrsf mirrorTransform)
        {
            if (builder.Visibility == ObjectVisibility.Hidden)
                return;
            var sourceShape = builder.Shape;
            if (sourceShape == null)
                return;
            var aisShape = AddToContext(builder, sourceShape, mirrorTransform);
            _mirrorShapeList.Add(aisShape);
        }

        private AISShape AddToContext(NodeBuilder builder, TopoDSShape sourceShape, gpTrsf mirrorTransform)
        {
            var shape = new BRepBuilderAPITransform(sourceShape, mirrorTransform, true).Shape;
            var aisShape = new AISShape(shape);
            _context.Display(aisShape, false);
            _context.SetTransparency(aisShape, 0.8, false);
            ApplyColor(builder, aisShape);
            return aisShape;
        }

        private void ApplyColor(NodeBuilder builder, AISInteractiveObject aisShape)
        {
            var parent = builder.Node;
            var col = Color.DarkTurquoise;
            var colorInterpreter = parent.Get<DrawingAttributesInterpreter>();
            if (colorInterpreter.HasColorSet)
                col = colorInterpreter.Color;
            var color = ShapeUtils.GetOccColor(col);
            _context.SetColor(aisShape, color, false);
        }

        private void MirrorAllShapes(NodeBuilder liveShape)
        {
            var bounding = ComputeEnclosingBoundingBox();
            if (liveShape.LastExecute)
                bounding = CombineBoundingBoxWithShape(liveShape, bounding);

            _mirrorDocument.Undo();
            _mirrorDocument.Transact();
            var floorRectangle = BuildFloor(bounding);

            var plane = ShapeUtils.ExtractPlaneFromFaceShape(floorRectangle.Shape);
            var mirrorTransform = ShapeUtils.ExtractPlaneMirrorTransform(plane);

            ClearMirrors();
            if (liveShape.LastExecute)
                MirrorBuilder(liveShape, mirrorTransform);
            foreach (var shapeNode in _document.Root.Children.Values)
                GetCacheItem(shapeNode.Index, mirrorTransform);

            ViewRedraw();
        }

        private void ClearMirrors()
        {
            foreach (var ocaisShape in _mirrorShapeList)
                _context.Remove(ocaisShape, false);
        }

        private ShapeBoundBox ComputeEnclosingBoundingBox()
        {
            var bounding = new ShapeBoundBox();
            foreach (var shapeNode in _document.Root.Children.Values)
            {
                var builder = new NodeBuilder(shapeNode);
                bounding = CombineBoundingBoxWithShape(builder, bounding);
            }
            return bounding;
        }

        private static ShapeBoundBox CombineBoundingBoxWithShape(NodeBuilder builder, ShapeBoundBox bounding)
        {
            var shapeBoundBox = builder.BoundingBox;
            if (shapeBoundBox != null)
                bounding = bounding.Combine(shapeBoundBox);
            return bounding;
        }

        private NodeBuilder BuildFloor(ShapeBoundBox bounding)
        {
            var floorRectangle = new NodeBuilder(_mirrorDocument, FunctionNames.Rectangle);
            var startFloorPoint = new Point3D(bounding.Coordinate.X - _range,
                                              bounding.Coordinate.Y - _range,
                                              bounding.Coordinate.Z);
            var dir = new gpDir(0, 0, 1);
            var endFloorPoint = new Point3D(
                bounding.Coordinate.X + bounding.Dimensions.X + _range,
                bounding.Coordinate.Y + bounding.Dimensions.Y + _range,
                bounding.Coordinate.Z);

            floorRectangle[0].Axis3D = new Axis(new gpAx1(startFloorPoint.GpPnt, dir));
            floorRectangle[1].TransformedPoint3D = endFloorPoint;

            floorRectangle.Color = Color.White;
            floorRectangle.Transparency = 0.8;
            floorRectangle.ExecuteFunction();
            _mirrorDocument.Commit("tranparent floor");
            return floorRectangle;
        }

        private void SourceContextHandler(DataPackage data)
        {
            _context = data.Get<AISInteractiveContext>();
            _mirrorDocument.Root.Set<DocumentContextInterpreter>().Context = _context;
        }

        private void SourceDocumentHandler(DataPackage data)
        {
            _document = data.Get<Document>();
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.RefreshView:
                    MirrorAllShapes(dataPackage.Get<NodeBuilder>());
                    break;
            }
        }
    }
}