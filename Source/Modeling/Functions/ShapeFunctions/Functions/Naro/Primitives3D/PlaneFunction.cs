#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class PlaneFunction : FunctionBase
    {
        public PlaneFunction() : base(FunctionNames.Plane)
        {
            // points defining visible rectangle
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var edge1 = new BRepBuilderAPIMakeEdge(Dependency[0].TransformedPoint3D.GpPnt, Dependency[1].TransformedPoint3D.GpPnt).Edge;
            var edge2 = new BRepBuilderAPIMakeEdge(Dependency[1].TransformedPoint3D.GpPnt, Dependency[2].TransformedPoint3D.GpPnt).Edge;
            var edge3 = new BRepBuilderAPIMakeEdge(Dependency[2].TransformedPoint3D.GpPnt, Dependency[3].TransformedPoint3D.GpPnt).Edge;
            var edge4 = new BRepBuilderAPIMakeEdge(Dependency[3].TransformedPoint3D.GpPnt, Dependency[0].TransformedPoint3D.GpPnt).Edge;

            var mkWire = new BRepBuilderAPIMakeWire();
            mkWire.Add(edge1);
            mkWire.Add(edge2);
            mkWire.Add(edge3);
            mkWire.Add(edge4);
            TopoDSFace faceProfile = null;
            if (mkWire.IsDone)
            {
                var wireProfile = mkWire.Wire;
                if (!wireProfile.IsNull)
                {
                    faceProfile = new BRepBuilderAPIMakeFace(wireProfile, false).Face;
                   
                }
            }

            Shape = faceProfile;

            return true;
        }
    }
}