#region Usings

using System;
using log4net;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using ShapeFunctionsInterface.Functions;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class EvolvedFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (EvolvedFunction));

        public EvolvedFunction()
            : base(FunctionNames.Evolved)
        {
            // Profile
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Path
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var profile = Dependency[0].ReferedShape;
            var path = Dependency[1].ReferedShape;

            Shape = MakePipe(path, profile);
            if (Shape == null) return false;

            // Hide the referenece shape
            NodeUtils.Hide(Dependency[0].Reference);
            NodeUtils.Hide(Dependency[1].Reference);

            return true;
        }

        private static TopoDSShape MakePipe(TopoDSShape path, TopoDSShape profile)
        {
            try
            {
                var baseEx = new TopExpExplorer();
                baseEx.Init(path, TopAbsShapeEnum.TopAbs_WIRE, TopAbsShapeEnum.TopAbs_SHAPE);
                var spline = TopoDS.Wire(baseEx.Current);
                return new BRepOffsetAPIMakePipe(spline, profile).Shape;
            }
            catch (Exception ex)
            {
                Log.Error("Error on making pipe: " + ex.Message);
                return null;
            }
        }
    }
}