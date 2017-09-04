#region Usings

using System;
using System.Collections.Generic;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepCheck;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class MakeFaceFunction : FunctionBase
    {
        public MakeFaceFunction() : base(FunctionNames.Face)
        {
            // List with the grouped objects
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
        }

        public override bool Execute()
        {
            // Get the list with the shapes to be grouped
            var cutShapes = Dependency[0].ReferenceList;
            if (cutShapes == null)
                return false;

            // Disable the notifications
            var referenceInterpreter = Dependency[0].Node.Get<ReferenceListInterpreter>();
            if (referenceInterpreter != null)
            {
                referenceInterpreter.Disable();
            }

            // Generate a Face, also check for validity
            var face = ComposeWires(cutShapes, true);
            var operationResult = false;
            if (face != null)
            {
                operationResult = true;
                Shape = face;

                // Hide the references
                foreach (var cutShape in cutShapes)
                {
                    // Hide the reference shape
                    var node = cutShape.Node;
                    NodeUtils.Hide(node);
                    node.Set<TreeViewVisibilityInterpreter>();
                }
            }

            // Reactivate the reference shape notification
            if (referenceInterpreter != null)
            {
                referenceInterpreter.Enable();
            }

            return operationResult;
        }

        private static List<Node> alreadyDone = new List<Node>();
        private static Dictionary<int, TopoDSFace> processedfaces = new Dictionary<int, TopoDSFace>();

        public static TopoDSFace ComposeWires(List<SceneSelectedEntity> cutShapes, bool skipFaceValidityCheck)
        {
            if (cutShapes.Count > 0)
            {
                alreadyDone.Add(cutShapes[0].Node);
                var mkWire = new BRepBuilderAPIMakeWire();
                foreach (var cutShape in cutShapes)
                {
                    var node = cutShape.Node;
                    var shape = node.Get<TopoDsShapeInterpreter>().Shape;
                    if (shape == null)
                        break;
                    if (shape.ShapeType != TopAbsShapeEnum.TopAbs_WIRE) continue;
                    var wire = TopoDS.Wire(shape);
                    mkWire.Add(wire);
                }

                if (mkWire.IsDone)
                {
                    // If the wire generation succeeded generate a Face from it
                    var wireProfile = mkWire.Wire;
                    if (!wireProfile.IsNull)
                    {
                        var faceProfile = new BRepBuilderAPIMakeFace(wireProfile, true).Face;
                        if (!faceProfile.IsNull)
                        {
                            // The face is generated not checking if it is a valid face
                            if (skipFaceValidityCheck)
                                return faceProfile;

                            // Check if it is a valid shape
                            var analyzer = new BRepCheckAnalyzer(faceProfile, true);
                            if (analyzer.IsValid())
                                return faceProfile;
                        }
                    }
                }
            }

            return null;
        }
    }
}