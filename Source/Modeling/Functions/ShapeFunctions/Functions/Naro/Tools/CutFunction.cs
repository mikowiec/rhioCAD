#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.BOPTools;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using log4net;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Enums;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class CutFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (CutFunction));

        public CutFunction() : base(FunctionNames.Cut)
        {
            // Reference shape which cuts through other shapes
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Cut height
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Cut type
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // List with the objects already affected by the Cut
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
        }

        public override bool Execute()
        {
            // Get the reference nodes to see if Cut was applied or it is the first time
            var cutShapes = Dependency[3].ReferenceList;
            if (cutShapes == null)
                return false;
            var rootNode = Parent.Root;
            // Get the Cut dependencies (cutting shape, cut depth and cut type)
            var cuttingShape = Dependency[0].ReferedShape;
            var sketchNode = Dependency[0].ReferenceBuilder.Node;
            var faces = AutoGroupLogic.BuildAutoFaces(sketchNode, rootNode.Get<DocumentContextInterpreter>().Document);
            var depth = Dependency[1].Real;
            var cutType = (CutTypes) Dependency[2].Integer;

            cuttingShape = faces.First(); // firstFace.Shape;
            // Test the cutting shape
            if (cuttingShape == null || cuttingShape.IsNull)
                return false;

            var dir = GeomUtils.ExtractDirection(cuttingShape) ??
                      sketchNode.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis.Direction;

            // Build a list with the cutting prisms used to Cut the objects
            var cuttingPrisms = new List<TopoDSShape>();
           
            var depthM = cutType == CutTypes.ToDepth ? depth : 7000;
            if (Math.Abs(depthM) < Precision.Confusion)
                depthM = 0.1;
            foreach (var face in faces)
            {
                TopoDSShape cutPrismShape = null;
                var translationVector = new gpVec(dir);
                translationVector.Multiply(-1 * depthM / 2);
                var transformation = new gpTrsf();
                transformation.SetTranslation(translationVector);
                var brepTrans = new BRepBuilderAPITransform(face, transformation, false);
                var translatedShape = brepTrans.Shape;
                var translatedFace = translatedShape;

                // Describe the height through a vector
                var vector = new gpVec(dir);
                vector.Multiply(depthM);

                // Make the prism
                cutPrismShape = new BRepPrimAPIMakePrism(translatedFace, vector, false, true).Shape;
              
                cuttingPrisms.Add(cutPrismShape);
            }
            if (cuttingPrisms.Count == 0)
                return false;
            var document = rootNode.Get<DocumentContextInterpreter>().Document;
            var shapeList = new List<int>();
            if(Dependency[3].ReferenceList.Count >0)
            {
                shapeList.AddRange(Dependency[3].ReferenceList.Select(sse => sse.Node.Index));
            }
            else
            {
                shapeList.AddRange(NodeUtils.GetDocumentSolids(document));
                shapeList.Remove(Parent.Index);
            }
            TopoDSShape resShape = null;
            foreach (var cuttingPrism in cuttingPrisms)
            {
                // If the Cut is executed first time
                if (cutShapes.Count <= 0 || resShape == null)
                {
                    // Put back the shapes
                    // Cut them again
                    var cutModifiedNodes = new List<SceneSelectedEntity>();
                    resShape = CutThroughAll(rootNode, cuttingPrism, cutModifiedNodes, shapeList);
                    Dependency[3].ReferenceList = cutModifiedNodes;
                    cutShapes = Dependency[3].ReferenceList;
                }
                else
                {
                    // Execute Cut on the shapes from ReferenceList
                    resShape = CutThroughShape(resShape, cuttingPrism);
                }
            }

            if (resShape == null)
                return false;

            // Show the new Cut shape
            Shape = resShape;

            return true;
        }

        /// <summary>
        ///   Cuts through all childs of the node with the TopoDS_Shape passed as parameter.
        ///   It returns a compund made from the affected shapes
        /// </summary>
        /// <param name = "root"></param>
        /// <param name = "cutPrismShape"></param>
        /// <param name = "affectedNodes"></param>
        /// <param name = "shapeList"></param>
        private static TopoDSShape CutThroughAll(Node root, TopoDSShape cutPrismShape,
                                                    ICollection<SceneSelectedEntity> affectedNodes,
                                                    IEnumerable<int> shapeList)
        {
            var compoundShape = new TopoDSCompound();
            var shapeBuilder = new BRepBuilder();
            shapeBuilder.MakeCompound(compoundShape);
            var resShape = (TopoDSShape) compoundShape;

            foreach (var childNodeIndex in shapeList)
            {
                var childNode = new NodeBuilder(root[childNodeIndex]);

                var topoShape = childNode.Shape;
                if (topoShape == null) continue;
                BRepAlgoAPICut cut;
                var filler = new BOPToolsDSFiller();
                try
                {
                    filler.SetShapes(topoShape, cutPrismShape);
                    if (!filler.IsDone)
                        continue;
                    filler.Perform();
                    cut = new BRepAlgoAPICut(topoShape, cutPrismShape, filler, true);
                    if (!cut.IsDone)
                        continue;
                    // Check if the shape was altered by the Cut
                    //if ((cut.HasGenerated == false) && (cut.HasModified == false))
                    //    continue;
                }
                catch (Exception)
                {
                    continue;
                }

                TopoDSShape shapeCut = null;
                try
                {
                    shapeCut = cut.Shape;
                }
                catch (Exception)
                {
                    Log.Info("Exception on create cut shape");
                }

                if ((shapeCut == null) || (shapeCut.IsNull)) continue;
                // If Cut succeeded hide the original shape
                NodeUtils.Hide(childNode.Node);
                // Show the new shape as a new Node
                shapeBuilder.Add(resShape, shapeCut);
                // Add the affceted node into the affectedNodes list
                affectedNodes.Add(new SceneSelectedEntity(childNode.Node));
            }

            return resShape;
        }

        /// <summary>
        ///   Cuts through all childs of the node with the TopoDS_Shape passed as parameter.
        ///   It returns a compund made from the affected shapes
        /// </summary>
        /// <param name = "nodes"></param>
        /// <param name = "cutPrismShape"></param>
        private static TopoDSShape CutThroughAll(IEnumerable<SceneSelectedEntity> nodes, TopoDSShape cutPrismShape)
        {
            var compoundShape = new TopoDSCompound();
            var shapeBuilder = new BRepBuilder();
            shapeBuilder.MakeCompound(compoundShape);
            var resShape = (TopoDSShape) compoundShape;

            foreach (var cutShape in nodes)
            {
                var childNode = cutShape.Node;
                // Try to Cut through the object
                var topoShape = childNode.Get<NamedShapeInterpreter>().Shape;
                if (topoShape == null) continue;
                var cut = new BRepAlgoAPICut(topoShape, cutPrismShape);
                // Check if the shape was altered by the Cut
                if ((cut.HasGenerated == false) && (cut.HasModified == false))
                    continue;

                TopoDSShape shapeCut = null;
                try
                {
                    shapeCut = cut.Shape;
                }
                catch (Exception)
                {
                    Log.Info("Exception on create cut shape");
                }

                if ((shapeCut != null) && (!shapeCut.IsNull))
                    // Show the new shape as a new Node
                    shapeBuilder.Add(resShape, shapeCut);
            }

            return resShape;
        }

        /// <summary>
        ///   Cuts through all childs of the node with the TopoDS_Shape passed as parameter.
        ///   It returns a compund made from the affected shapes
        /// </summary>
        /// <param name = "nodes"></param>
        /// <param name = "cutPrismShape"></param>
        private static TopoDSShape CutThroughShape(TopoDSShape shapeToCut, TopoDSShape cutPrismShape)
        {
            var cut = new BRepAlgoAPICut(shapeToCut, cutPrismShape);
            // Check if the shape was altered by the Cut
            //if ((cut.HasGenerated == false) && (cut.HasModified == false))
            //    return null;
            if (cut.Shape == null || GeomUtils.GetSolidVolume(cut.Shape) < Precision.Confusion)
                return null;

            TopoDSShape shapeCut = null;
            try
            {
                shapeCut = cut.Shape;
            }
            catch (Exception)
            {
                Log.Info("Exception on create cut shape");
            }
            return shapeCut;
        }
    }
}