using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NaroCAD.SolverModule.Interface.Geometry;
using Naro.Infrastructure.Library.Algo;
using NaroSketchAdapter.Factory;
using TreeData.NaroData;
using OccCode;
using NaroSketchAdapter;
using TreeData.AttributeInterpreter;

namespace NaroTestSuite.SolverTests
{
   public class SolverTestsUtils
    {
       public static List<Point3D> GetIntersectionPoints(List<SolverPreviewObject> _solverGeometry, Document _document)
       {
           var edgeSuggestions = new List<SolverGeometricObject>();
           var intersections = new List<Point3D>();
           for (int i = 0; i < _solverGeometry.Count; i++)
           {
               if (_solverGeometry[i] is SolverEdgeTwoPointsResult)
               {
                   var nb = TreeUtils.AddLineToNode(_document, (_solverGeometry[i]).Point, ((SolverEdgeTwoPointsResult)_solverGeometry[i]).SecondPoint);
                   var suggestion = SolverConstraintFactory.Instance.ExtractGeometry(nb.Node);
                   if (suggestion == null) continue;
                   edgeSuggestions.Add(suggestion);
               }
           }

           foreach (var geomObj in edgeSuggestions)
           {
               if (geomObj == null) continue;
               var edges = GeomUtils.ExtractEdges(geomObj.Builder.Shape);
               geomObj.Edges.Add(new SolverEdge(edges[0]));
           }

           // we have more than one solution - move the point to the intersection
           if (edgeSuggestions.Count >= 2)
           {
               intersections = SolverExtractLogic.GetIntersectionsPointList(edgeSuggestions);
           }
           return intersections;
       }
    }
}
