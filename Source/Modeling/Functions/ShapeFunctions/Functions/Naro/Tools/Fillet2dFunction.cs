#region Usings

using System;
using System.Collections.Generic;
using log4net;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepFilletAPI;
using NaroCppCore.Occ.BRepTools;
using NaroCppCore.Occ.ChFi2d;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    internal class Fillet2DFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Fillet2DFunction));

        public Fillet2DFunction() : base(FunctionNames.Fillet2D)
        {
            // Reference shape - list of wires
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
            // Fillet radius
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Operation type: 2 fillet2D or 3 chamfer2D
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            var filletNodes = Dependency[0].ReferenceList;
            if ((filletNodes == null) || (filletNodes.Count <= 0))
            {
                return false;
            }

            var radius = Dependency[1].Real;
            var operationType = Dependency[2].Integer;

            TopoDSShape resultShape;
            // Test if all shape are pointing to the same node
            // (ex: they are all edges of the same shape)
            var sameParentNodes = NodeUtils.SameParentNodes(filletNodes);

            if (sameParentNodes)
            {
                // Apply fillet on edges of a Face
                resultShape = ApplyFilletOnFace(filletNodes, radius, operationType);
            }
            else
            {
                // Try applying a Fillet on wires
                resultShape = ApplyFilletOnWires(filletNodes, radius, operationType);
            }

            if (resultShape == null)
            {
                return false;
            }

            // Hide the nodes that fillet/chamfer is applied on
            foreach (var filletNode in filletNodes)
            {
                var node = filletNode.Node;
                NodeUtils.Hide(node);
                // If all shapes are pointing to the same node there is no need to go through
                // all shapes to hide the node they point at
                if (sameParentNodes)
                    break;
            }

            // Set the new shape
            Shape = resultShape;

            return true;
        }

        /// <summary>
        ///   Apply fillet on a list of wires. The common endpoints of wires are considered the fillet vertexes.
        /// </summary>
        private static TopoDSWire ApplyFilletOnWires(IEnumerable<SceneSelectedEntity> filletNodes, double radius,
                                                        int filletChamferType)
        {
            // This method processes only fillet2D and chamfer2D operations
            if ((filletChamferType != (int) FilletChamferTypes.SimpleFillet2D) &&
                (filletChamferType != (int) FilletChamferTypes.SimpleChamfer2D))
                return null;

            try
            {
                // Make a face fom the wires
                var wires = new List<SceneSelectedEntity>();
                foreach (var node in filletNodes)
                    wires.Add(node);
                var face = MakeFaceFunction.ComposeWires(wires, true);

                if ((face == null) || (face.IsNull))
                    return null;

                var fillet = new BRepFilletAPIMakeFillet2d();
                // Initialize a fillet with the face made from the 2 wires
                fillet.Init(face);

                // Fillet the common vertexes
                Node previousNode = null;
                foreach (var node in filletNodes)
                {
                    if (previousNode != null)
                    {
                        var wire1 = previousNode.Get<NamedShapeInterpreter>().Shape;
                        var wire2 = node.Node.Get<NamedShapeInterpreter>().Shape;
                        var listOfCommonVertex = GeomUtils.CommonVertexes(wire1, wire2);
                        if (listOfCommonVertex.Count >= 1)
                        {
                            foreach (var vertex in listOfCommonVertex)
                            {
                                if (filletChamferType == (int) FilletChamferTypes.SimpleFillet2D)
                                {
                                    // If the operation is a fillet
                                    fillet.AddFillet(vertex, radius);
                                }
                                else
                                {
                                    // Map all edges to faces
                                    var map = new TopToolsIndexedDataMapOfShapeListOfShape(1);
                                    TopExp.MapShapesAndAncestors(wire1, TopAbsShapeEnum.TopAbs_VERTEX,
                                                                   TopAbsShapeEnum.TopAbs_EDGE, map);

                                    // Locate an ancestor face
                                    for (var i = 1; i <= map.Extent; i++)
                                    {
                                        var localVertex = TopoDS.Vertex(map.FindKey(i));
                                        if (!vertex.IsSame(localVertex)) continue;
                                        // We found an ancestor edge
                                        var edge = TopoDS.Edge(map.FindFromIndex(i).First);
                                        // Add the vertex and edge on the chamfer algorithm
                                        //fillet.AddChamfer(TopoDS.Edge(edge), TopoDS.Edge(edge2), radius, radius);
                                        fillet.AddChamfer(TopoDS.Edge(edge), vertex, radius,
                                                          GeomUtils.DegreesToRadians(45));
                                    }
                                }
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                    previousNode = node.Node;
                }

                // Test if the operation succeeded
                if (fillet.Status != ChFi2dConstructionError.ChFi2d_IsDone)
                    return null;

                var shape = fillet.Shape;
                if ((shape == null) || (shape.IsNull))
                    return null;

                var aMap = new TopToolsIndexedMapOfShape(1);
                TopExp.MapShapes(fillet.Shape, TopAbsShapeEnum.TopAbs_WIRE, aMap);
                if (aMap.Extent != 1)
                    return null;

                var newWire = new BRepBuilderAPIMakeWire();
                var ex = new BRepToolsWireExplorer(TopoDS.Wire(aMap.FindKey(1)));
                for (; ex.More; ex.Next())
                    newWire.Add(ex.Current);

                return newWire.Wire;
            }
            catch (Exception ex)
            {
                Log.Error("Apply Fillet2D error: " + ex.Message);
            }

            return null;
        }

        /// <summary>
        ///   Applies fillet on the edges of a Face generated from a wire.
        /// </summary>
        private static TopoDSFace ApplyFilletOnFace(IList<SceneSelectedEntity> filletNodes, double radius,
                                                       int filletChamferType)
        {
            // This method processes only fillet2D and chamfer2D operations
            if ((filletChamferType != (int) FilletChamferTypes.SimpleFillet2D) &&
                (filletChamferType != (int) FilletChamferTypes.SimpleChamfer2D))
            {
                return null;
            }

            // There should be at least two edges to apply fillet on them
            if (filletNodes.Count < 2)
            {
                return null;
            }

            // Check that the list contains only edges
            foreach (var node in filletNodes)
            {
                if (node.ShapeType != TopAbsShapeEnum.TopAbs_EDGE)
                {
                    return null;
                }
            }

            try
            {
                var fillet = new BRepFilletAPIMakeFillet2d();
                // Initialize a fillet with the parent face of the edges
                var face = TopoDS.Face(filletNodes[0].Node.Get<TopoDsShapeInterpreter>().Shape);
                fillet.Init(face);

                // Fillet the common vertexes
                SceneSelectedEntity previousNode = null;
                foreach (var node in filletNodes)
                {
                    if (previousNode != null)
                    {
                        AddFaceFilletVertex(face, filletChamferType, radius, previousNode, node, fillet);
                    }
                    previousNode = node;
                }
                // Add also the last and first edges if they have a common node in the case there are more than 2 edges
                if ((previousNode != null) && (filletNodes.Count > 2))
                {
                    AddFaceFilletVertex(face, filletChamferType, radius, previousNode, filletNodes[0], fillet);
                }

                // Test if the operation succeeded
                if (fillet.Status != ChFi2dConstructionError.ChFi2d_IsDone)
                {
                    return null;
                }

                var shape = fillet.Shape;
                if ((shape == null) || (shape.IsNull))
                {
                    return null;
                }

                return shape.ShapeType == TopAbsShapeEnum.TopAbs_FACE ? TopoDS.Face(shape) : null;
            }
            catch (Exception ex)
            {
                Log.Info("Apply Fillet2D error: " + ex.Message);
            }

            return null;
        }

        private static void AddFaceFilletVertex(TopoDSShape face, int filletChamferType, double radius,
                                                SceneSelectedEntity firstEntity, SceneSelectedEntity secondEntity,
                                                BRepFilletAPIMakeFillet2d fillet)
        {
            var firstWire = GeomUtils.ExtractShapeType(face, firstEntity.ShapeType, firstEntity.ShapeCount);
            var secondWire = GeomUtils.ExtractShapeType(face, secondEntity.ShapeType, secondEntity.ShapeCount);
            var listOfCommonVertex = GeomUtils.CommonVertexes(firstWire, secondWire);
            if (listOfCommonVertex.Count >= 1)
            {
                // If operation type is fillet
                if (filletChamferType == (int) FilletChamferTypes.SimpleFillet2D)
                {
                    foreach (var vertex in listOfCommonVertex)
                    {
                        fillet.AddFillet(vertex, radius);
                    }
                }
                else
                {
                    // If operation type is chamfer
                    fillet.AddChamfer(TopoDS.Edge(firstWire), listOfCommonVertex[0], radius,
                                      GeomUtils.DegreesToRadians(45));
                }
            }
            else
            {
                return;
            }

            return;
        }
    }
}