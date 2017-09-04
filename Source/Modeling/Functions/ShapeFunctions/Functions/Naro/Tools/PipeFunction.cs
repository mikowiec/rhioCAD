#region Usings

using System;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using log4net;
using NaroConstants.Names;

using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class PipeFunction : FunctionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PipeFunction));

        public PipeFunction()
            : base(FunctionNames.Pipe)
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

            var profileLocation = profile.Location();
            var profileTranslation = new gpTrsf();
            profileTranslation.TranslationPart = (profileLocation.Transformation.TranslationPart.Reversed);

            var newProfileLocation = new TopLocLocation(profileTranslation);
            profile.Move(newProfileLocation);
            path.Move(newProfileLocation);

            var finalShape = MakeEvolve(path, profile);

            profile.Move(newProfileLocation.Inverted);
            path.Move(newProfileLocation.Inverted);

            Shape = finalShape;
            if (Shape == null) return false;

            return true;
        }

        private static TopoDSShape MakeEvolve(TopoDSShape path, TopoDSShape profile)
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