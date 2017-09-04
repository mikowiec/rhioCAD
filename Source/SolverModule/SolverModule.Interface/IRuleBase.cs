#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;
using System.Collections;
using TreeData.AttributeInterpreter;
using System.Collections.Generic;

#endregion

namespace NaroCAD.SolverModule.Interface
{
    public abstract class IRuleBase
    {
        public bool Enabled { get; set; }

        public virtual List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            return null;
        }

        public virtual SolverPreviewObject InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D currentPoint,
                                                                       Point3D initialPosition)
        {
            return null;
        }
    }
}