#region Usings

using System.Collections.Generic;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Rules
{
    public sealed class RuleSet : IRuleSet
    {
        public RuleSet()
        {
            Rules = new SortedDictionary<string, IRuleBase>();
        }

        #region IRuleSet Members

        public SortedDictionary<string, IRuleBase> Rules { get; set; }

        public List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView, Point3D coordinate)
        {
            var result = new List<SolverPreviewObject>();
            foreach (var rule in Rules.Values)
            {
                if (!rule.Enabled) continue;
                var solverResult = rule.InterestingShapeAroundPoint(planeOfTheView, coordinate);
                if (solverResult != null)
                    result.AddRange(solverResult);
            }
            return result;
        }

        public List<SolverPreviewObject> GetInterestingCloseGeometry(gpPln planeOfTheView, Point3D currentPoint,
                                                                     Point3D initialPosition)
        {
            var result = new List<SolverPreviewObject>();

            foreach (var rule in Rules.Values)
            {
                if (!rule.Enabled) continue;

                var solveResult = rule.InterestingShapeAroundPoint(planeOfTheView, currentPoint);
                if (solveResult != null)
                {
                    //log.Debug("GetInterestingCloseGeometry - add single magic point");
                    result.AddRange(solveResult);
                }

                var solveResultInitial = rule.InterestingShapeAroundPoint(planeOfTheView, currentPoint, initialPosition);

                if (solveResultInitial == null) continue;
                result.Add(solveResultInitial);
            }

            return result;
        }

        #endregion
    }
}