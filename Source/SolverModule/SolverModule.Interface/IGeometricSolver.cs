#region Usings

using System.Collections.Generic;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface
{
    public abstract class GeometricSolver
    {
        public IRuleSet RuleSet { get; set; }
        public virtual List<SolverGeometricObject> Geometry { get; set; }

        public List<SolverGeometricObject> LastGeometry { get; set; }

        public Document Document { get; set; }

        public abstract List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView,
                                                                              Point3D coordinate);

        public abstract List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView,
                                                                              Point3D currentPoint,
                                                                              Point3D initialPosition);

        public abstract void Refresh();
    }
}