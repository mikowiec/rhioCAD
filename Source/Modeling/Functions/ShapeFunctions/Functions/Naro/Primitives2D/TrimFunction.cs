#region Usings

using System;
using System.Collections.Generic;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class TrimFunction : FunctionBase
    {
        public TrimFunction()
            : base(FunctionNames.Trim)
        {
            // Trimming wires
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
            // Wire to be trimmed
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Clicked point
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
           
            var wireToTrim = Dependency[1].ReferenceData;
            //if (wireToTrim.ShapeType() != OCTopAbs_ShapeEnum.TopAbs_WIRE)
            //    return false;
            var trimmingWires = Dependency[0].ReferenceList;
            gpPnt clickPoint;
            try
            {
                clickPoint = Dependency[2].ReferenceBuilder[1].TransformedPoint3D.GpPnt; 
            }
            catch (Exception)
            {
                // trim action is called when other shapes are updated
                return false;
            }

            var profileLocation = wireToTrim.TargetShape().Location();
            var profileTranslation = new gpTrsf();
            var profileTranslationVector = profileLocation.Transformation.TranslationPart.Reversed;
            profileTranslation.TranslationPart = (profileTranslationVector);
            var newProfileLocation = new TopLocLocation(profileTranslation);
            
            foreach (var wire in trimmingWires)
            {
                wire.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation);
            }
            wireToTrim.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation);
            clickPoint.Translate(profileTranslationVector);
           
            var trimmingEdges = new List<TopoDSEdge>();
            foreach (var trimming in trimmingWires)
            {
                //if (trimming.ShapeType != OCTopAbs_ShapeEnum.TopAbs_WIRE)
                //    return false;
                var trimmingE = GeomUtils.ExtractEdges(trimming.TargetShape());
                if (trimmingE.Count > 0)
                    trimmingEdges.AddRange(trimmingE);
            }
            if (trimmingEdges.Count <= 0)
                return false;

            var edgesToTrim = GeomUtils.ExtractEdges(wireToTrim.TargetShape());
            if (edgesToTrim.Count <= 0)
                return false;

            var resultShapes = GeomUtils.TrimGenericShape(trimmingEdges, edgesToTrim[0], new Point3D(clickPoint));
            if (resultShapes.Count <= 0)
                return false;

            var finalWire = new BRepBuilderAPIMakeWire();
            foreach (var edge in resultShapes)
                finalWire.Add(edge);
            /*
            foreach (var wire in trimmingWires)
            {
                wire.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation.Inverted);
            }
            wireToTrim.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation.Inverted);
            clickPoint.Translate(profileTranslationVector.Reversed);
           */
            Shape = finalWire.Wire;

            return true;
        }
    }
}