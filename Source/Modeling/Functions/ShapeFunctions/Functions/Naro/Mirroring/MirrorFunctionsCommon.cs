#region Usings

using System;
using log4net;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Mirroring
{
    public abstract class MirrorFunctionsCommon : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (MirrorLineFunction));

        protected MirrorFunctionsCommon(string name) : base(name)
        {
        }

        protected static TopoDSShape ApplyEvolveOnShape(gpTrsf mirrorTransform, TopoDSShape sourceShape)
        {
            try
            {
                var myBRepTransformation = new BRepBuilderAPITransform(mirrorTransform);
                myBRepTransformation.Perform(sourceShape, true);
                return myBRepTransformation.IsDone ? myBRepTransformation.Shape : null;
            }
            catch (Exception ex)
            {
                Log.Error("Error on making mirror: " + ex.Message);
                return null;
            }
        }
    }
}