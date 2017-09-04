#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using log4net;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class RevolveFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (RevolveFunction));

        public RevolveFunction()
            : base(FunctionNames.Revolve)
        {
            // Shape to revolve
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Shape considered revolve axis
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Angle
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var axis = Dependency[1].ReferedShape;
            var angle = Dependency[2].Real/180.0*Math.PI;
            var revolvedNode = Dependency[0].ReferenceBuilder.Node;
            TopoDSShape originalShape = Dependency[0].ReferedShape;
            var sketchShapes = new List<Node>();
            var nodesOnSketch = new List<Node>();
            var sketchNode = NodeBuilderUtils.FindSketchNode(revolvedNode);
            var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
            nodesOnSketch.AddRange(NodeUtils.GetSketchNodes(sketchNode, document, true));
            if (revolvedNode.Get<FunctionInterpreter>().Name == FunctionNames.Sketch)
            {
                var face = revolvedNode.Children[2].Get<MeshTopoShapeInterpreter>().Shape;
                originalShape = AutoGroupLogic.RebuildFaces(face);
            }
            else
            {
                foreach (var node in nodesOnSketch)
                {
                    if (node.Get<FunctionInterpreter>().Name != FunctionNames.Point && node.Index != Dependency[1].ReferenceBuilder.Node.Index)
                        sketchShapes.Add(node);
                }
            }
          
            if(sketchShapes.Count > 0)
            {
                var shapes = new List<TopoDSShape>();
                foreach(var node in sketchShapes)
                {
                    var nb = new NodeBuilder(node);
                    var tempShape = MakeRevolve(axis, nb.Shape, angle);
                    if(tempShape!= null)
                        shapes.Add(tempShape);
                }

                TopoDSShape finalShape = null;
                if (shapes.Count > 0)
                {
                    finalShape = shapes[0];
                    for (int i = 1; i < shapes.Count; i++)
                    {
                        if (shapes[i] == null)
                            continue;
                        var sew = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
                        sew.Add(finalShape);
                        sew.Add(shapes[i]);
                        var messg = new MessageProgressIndicator();
                        sew.Perform(messg);

                        finalShape = sew.SewedShape;
                    }
                    Shape = finalShape;
                    foreach (var node in nodesOnSketch)
                        NodeUtils.Hide(node);
                    return true;
                }
            }
            if (originalShape == null)
            {
                return false;
            }

            Shape = MakeRevolve(axis, originalShape, angle);
            if (Shape == null) return false;

            // Hide the referenece shape
            //NodeUtils.Hide(Dependency[0].Reference);
            foreach (var node in nodesOnSketch)
                NodeUtils.Hide(node);

            return true;
        }

        private static TopoDSShape MakeRevolve(TopoDSShape axis, TopoDSShape shape, double angle)
        {
            try
            {
                var ax = GeomUtils.ExtractAxis(axis);
                if (ax == null)
                    return null;
                var value = new BRepPrimAPIMakeRevol(shape, ax, angle, false).Shape;
                return value;
            }
            catch (Exception ex)
            {
                Log.Error("Error on making revolve: " + ex.Message);
                return null;
            }
        }
    }
}