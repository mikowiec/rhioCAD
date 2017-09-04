#region Usings

using System.Collections.Generic;
using System.Drawing;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace ShapeFunctionsInterface.Interpreters
{
    public class ContextShapeManager
    {
        public ContextShapeManager()
        {
            ShapeList = new SortedDictionary<int, AISInteractiveObject>();
        }

        public AISInteractiveContext Context { private get; set; }
        public SortedDictionary<int, AISInteractiveObject> ShapeList { get; private set; }

        public IEnumerable<int> ShapeIndexes
        {
            get { return new List<int>(ShapeList.Keys); }
        }

        private static bool ShapeIsInvisible(Node parent)
        {
            var shapeIsInvisible = false;
            var intInterpreter = parent.Set<DrawingAttributesInterpreter>();
            if (intInterpreter.Visibility == ObjectVisibility.Hidden)
            {
                shapeIsInvisible = true;
            }

            var layerInterpreter = parent.Get<LayerVisibilityInterpreter>();
            if (layerInterpreter != null)
            {
                if (!parent.Root.Set<LayerContainerInterpreter>().IsLayerVisible(layerInterpreter.TagIndex))
                    shapeIsInvisible = true;
            }
            return shapeIsInvisible;
        }

        public void RemoveShapeFromContext(Node node)
        {
            AISInteractiveObject interactive;
            var haveInteractive = ShapeList.TryGetValue(node.Index, out interactive);
            if (!haveInteractive) return;
            if (Context != null)
                Context.Remove(interactive, false);
            ShapeList.Remove(node.Index);
        }

        public AISInteractiveObject UpdateNodesInteractive(Node node)
        {
            AISInteractiveObject interactive;
            var haveInteractive = ShapeList.TryGetValue(node.Index, out interactive);
            if (ShapeIsInvisible(node))
            {
                if (haveInteractive)
                    RemoveShapeFromContext(node);
                return null;
            }
            var isShapeBasedInteractive = false;
            var topoDsInterpreter = node.Get<TopoDsShapeInterpreter>();
            if (topoDsInterpreter != null)
            {
                isShapeBasedInteractive = true;
                var topoDsShape = topoDsInterpreter.Shape;
                if (topoDsShape == null)
                {
                    RemoveShapeFromContext(node);
                    return null;
                }

                interactive = UpdateShapeInteractive(node, topoDsShape);
            }
            else
            {
                if (haveInteractive)
                    RemoveShapeFromContext(node);
                var interactiveShapeInterpreter = node.Get<InteractiveShapeInterpreter>();
                //Ensure.IsNotNull(interactiveShapeInterpreter,
                //                 "Your node should have either a TopoDS or an InteractiveShape associated to it");
                if (interactiveShapeInterpreter == null)
                    return null;
                interactive = interactiveShapeInterpreter.Interactive;
                if (interactive == null)
                {
                    RemoveShapeFromContext(node);
                    return null;
                }
                ShapeList[node.Index] = interactive;
            }

            if (Context == null) return null;

            UpdateInteractiveColor(Context, node, interactive, isShapeBasedInteractive);
            UpdateTransparency(Context, node, interactive);
            return interactive;
        }

        private AISInteractiveObject UpdateShapeInteractive(Node node, TopoDSShape topoDsShape)
        {
            AISInteractiveObject interactiveShape;
            var haveInteractiveShape = ShapeList.TryGetValue(node.Index, out interactiveShape);

            if (haveInteractiveShape)
            {
                AISShape shape = interactiveShape.Convert<AISShape>();
                if (shape != null)
                {
                    shape.Set(topoDsShape);
                    interactiveShape.Redisplay(false);
                }
            }
            else
            {
                interactiveShape = new AISShape(topoDsShape);
                ShapeList[node.Index] = interactiveShape;
                if (ShapeUtils.IsPlanarFace(topoDsShape))
                {
                    var drawer = interactiveShape.Attributes;
                    var shadingAspect = drawer.ShadingAspect;
                    var shadingAspectAspect = shadingAspect.Aspect;
                    shadingAspectAspect.EdgeColor = (ShapeUtils.GetOccColor(Color.Black));
                    //shadingAspectAspect.SetEdgeWidth(1);
                    shadingAspectAspect.SetEdgeOn();
                }
            }
            return interactiveShape;
        }

        private static void UpdateTransparency(AISInteractiveContext context, Node parent,
                                               AISInteractiveObject interactive)
        {
            // If the label has transparency information display the object with that transparency
            var value = 0.0;

            if (parent.Get<DrawingAttributesInterpreter>().HasTransparency)
                value = parent.Get<DrawingAttributesInterpreter>().Transparency;

            context.SetTransparency(interactive, value, false);
        }

        private static void UpdateInteractiveColor(AISInteractiveContext context, Node parent,
                                                   AISInteractiveObject interactive, bool setWireAspect)
        {
            var col = Color.DarkTurquoise;
            var colorInterpreter = parent.Get<DrawingAttributesInterpreter>();
            if (colorInterpreter.HasNoColor)
            {
                context.Display(interactive, false);
                return;
            }
            if (colorInterpreter.HasColorSet)
                col = colorInterpreter.Color;
            var color = ShapeUtils.GetOccColor(col);

            var layerContainer = parent.Root.Get<LayerContainerInterpreter>();
            if (layerContainer.UseLayerColors)
            {
                var layerIndex = parent.Get<LayerVisibilityInterpreter>().TagIndex;
                color = ShapeUtils.GetOccColor(layerContainer.LayerColors[layerIndex]);
            }

            context.SetColor(interactive, color, false);
            var drawer = interactive.Attributes;
            if (setWireAspect)
            {
                var wireAspect = drawer.WireAspect;
                wireAspect.SetColor(color.Name());
                wireAspect.Width = (1.5);
                drawer.LineAspect = (new Prs3dLineAspect(QuantityNameOfColor.Quantity_NOC_GRAY70,
                                                            AspectTypeOfLine.Aspect_TOL_DOT, 0.5));
                var pointAspect = drawer.PointAspect;
                pointAspect.SetColor(color.Name());
                pointAspect.Scale = (1);
                context.SetDisplayMode(interactive, (int) colorInterpreter.DisplayMode, false);
            }
            if (colorInterpreter.EnableSelection == false)
            {
                interactive.UnsetSelectionMode();
                interactive.HilightMode = (3);
            }
            context.Display(interactive, false);
        }
    }
}