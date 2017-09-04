#region Usings

using System.Collections.Generic;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;

using TreeData.AttributeInterpreter;

#endregion

namespace NaroCAD.SolverModule.Interface
{
    public interface IRuleSet
    {
        SortedDictionary<string, IRuleBase> Rules { get; set; }
        List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView, Point3D coordinate);

        List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView, Point3D currentPoint,
                                                              Point3D initialPosition);
    }
}