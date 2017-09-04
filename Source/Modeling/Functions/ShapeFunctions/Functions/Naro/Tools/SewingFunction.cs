#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class SewingFunction : FunctionBase
    {
        public SewingFunction()
            : base(FunctionNames.Sewing)
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

            Shape = MakeSew(path, profile);
            if (Shape == null) return false;

            // Hide the referenece shape
            NodeUtils.Hide(Dependency[0].Reference);
            NodeUtils.Hide(Dependency[1].Reference);

            return true;
        }

        private static TopoDSShape MakeSew(TopoDSShape path, TopoDSShape profile)
        {
            var sewing = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
            sewing.Add(profile);
            sewing.Add(path);
            MessageProgressIndicator messg = new MessageProgressIndicator();
            sewing.Perform(messg);

            return sewing.SewedShape;
        }
    }
}