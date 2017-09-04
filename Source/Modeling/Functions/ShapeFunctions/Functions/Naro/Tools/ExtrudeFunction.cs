#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
using log4net;
using NaroConstants.Enums;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    /// <summary>
    ///   Extrudes a reference shape with a specified height.
    /// </summary>
    public class ExtrudeFunction : FunctionBase
    {
        #region Constructor

        public ExtrudeFunction()
            : base(FunctionNames.Extrude)
        {
            // Reference shape on which extrusion applies
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Extrusion type
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Extrusion height
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        #endregion

        #region Overriden methods

        public override void PreExecute()
        {
            //Dependency[0].ConstraintType = ShapeOperations.Extrudable;
        }

        public override bool Execute()
        {
          //  NodeUtils.UpdateSketches(Dependency[0].ReferenceBuilder.Node, this.Builder);
            
            // Get the extrusion referenece shape, height and extrusion type
            var sketchNode = Dependency[0].ReferenceBuilder.Node;
            if(sketchNode == null)
                return false;
            TopoDSShape face = null;
            if (sketchNode != null)
                face = sketchNode.Children[2].Get<MeshTopoShapeInterpreter>().Shape;
            var rootNode = Parent.Root;
            var shapes = AutoGroupLogic.BuildAutoFaces(sketchNode, rootNode.Get<DocumentContextInterpreter>().Document);// ?? face;
            TopoDSShape finalShape=null;
            if(shapes.Count > 0)
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
            }
            if (finalShape == null)
                finalShape = face;
            var height = Dependency[2].Real;
            var extrusionType = Dependency[1].Integer;

            // Don't allow 0 height
            if (Math.Abs(height) < Precision.Confusion)
            {
                return false;
            }

            // Build the extruded shape
            TopoDSShape resultShape = extrusionType == (int) ExtrusionTypes.MidPlane
                                             ? ExtrudeMidPlane(finalShape, height)
                                             : ExtrudeToDepth(finalShape, height);

            Shape = resultShape;
            
            return true;
        }

        #endregion

        #region Methods

        /// <summary>
        ///   Make an extrusion starting from a shape until a height.
        /// </summary>
        /// <param name = "originalShape"></param>
        /// <param name = "height"></param>
        /// <returns></returns>
        private static TopoDSShape ExtrudeToDepth(TopoDSShape originalShape, double height)
        {
            TopoDSShape prismShape = null;
            // Make the Extrusion
            if (originalShape != null)
            {
                try
                {
                    var face = originalShape;// OCTopoDS.Face(originalShape);

                    // Get the direction
                    var dir = GeomUtils.ExtractDirection(face);
                    
                    if (dir == null)
                    {
                        return null;
                    }
                    if (dir.XYZ.Z < 0)
                        dir.Reverse();
                    // Describe the height through a vector
                    var vector = new gpVec(dir);
                    vector.Multiply(height);

                    // Make the prism
                    return new BRepPrimAPIMakePrism(face, vector, false, true).Shape;
                }
                catch (Exception ex)
                {
                    Log.Error("Error on extrude: " + ex.Message);
                    return null;
                }
            }

            return prismShape;
        }

        /// <summary>
        ///   Make an extrusion starting from a shape until a height.
        /// </summary>
        /// <param name = "originalShape"></param>
        /// <param name = "height"></param>
        /// <returns></returns>
        private static TopoDSShape ExtrudeMidPlane(TopoDSShape originalShape, double height)
        {
            TopoDSShape prismShape = null;
            // Make the Extrusion
            if (originalShape != null)
            {
                try
                {
                    // Get the Face to be extruded
                    var face = originalShape;// OCTopoDS.Face(originalShape);

                    // Get the direction
                    var dir = GeomUtils.ExtractDirection(face);
                    if (dir == null)
                    {
                        return null;
                    }

                    // Build the translated shape
                    var translationVector = new gpVec(dir);
                    translationVector.Multiply(-1*height/2);
                    var transformation = new gpTrsf();
                    transformation.SetTranslation(translationVector);
                    var brepTrans = new BRepBuilderAPITransform(originalShape, transformation, false);
                    var translatedShape = brepTrans.Shape;

                    // Extract the face of the translated shape
                    //baseEx.Init(translatedShape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
                    //baseEx.Next();
                    var translatedFace = translatedShape;// OCTopoDS.Face(translatedShape);

                    // Describe the height through a vector
                    var vector = new gpVec(dir);
                    vector.Multiply(height);

                    // Make the prism
                    prismShape = new BRepPrimAPIMakePrism(translatedFace, vector, false, true).Shape;
                }
                catch (Exception ex)
                {
                    Log.Error("Error on extrude: " + ex.Message);
                    return null;
                }
            }

            return prismShape;
        }

        #endregion

        #region Data members

        private static readonly ILog Log = LogManager.GetLogger(typeof (ExtrudeFunction));

        #endregion
    }
}