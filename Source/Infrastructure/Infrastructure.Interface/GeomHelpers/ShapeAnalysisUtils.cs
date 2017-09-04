#region Usings

using log4net;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepTools;
using NaroCppCore.Occ.ShapeAnalysis;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using OccCode;


#endregion

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public class ShapeAnalysisUtils
    {
        public static void DumpShapeInfo(ILog log, TopoDSShape shape)
        {
            log.Info("--- Shape Info ---");
            var vertexes = GeomUtils.ExtractVertexes(shape);
            log.InfoFormat("Extracted {0} vertexes", vertexes.Count);
            foreach (var vertex in vertexes)
            {
                var pnt = BRepTool.Pnt(vertex);
                log.InfoFormat("vertex: {0},{1},{2}", pnt.X, pnt.Y, pnt.Z);
            }
            var edges = GeomUtils.ExtractEdges(shape);
            log.InfoFormat("Extracted {0} edges", edges.Count);
            var wires = GeomUtils.ExtractWires(shape);
            log.InfoFormat("Extracted {0} wires", wires.Count);
            var faces = GeomUtils.ExtractFaces(shape);
            log.InfoFormat("Extracted {0} faces", faces.Count);
            log.Info("-------------------");
        }

        public static void CheckShape(ILog log, TopoDSShape shape)
        {
            log.Info("--- Check shape ---");
            log.Info(GeomUtils.CheckShape(shape) ? "Valid Shape" : "Invalid Shape!");
            log.Info("-------------------");
        }

        /// <summary>
        ///   Dumps shape info. Equivalent of statshape DrawTestHarness command.
        /// </summary>
        public static void DumpShapeAnalysis(ILog log, TopoDSShape shape)
        {
            log.Info("--- Shape Analysis results ---");
            var analyzer = new ShapeAnalysisShapeContents();
            analyzer.Perform(shape);

            var nb = analyzer.NbEdges;
            if (nb > 0)
                log.InfoFormat("{0}  EDGE (Oriented)", nb);
            nb = analyzer.NbSharedEdges;
            if (nb > 0)
                log.InfoFormat("{0}  EDGE (Shared)", nb);
            nb = analyzer.NbFreeEdges;
            if (nb > 0)
                log.InfoFormat("{0}  EDGE (Free)", nb);
            nb = analyzer.NbFaces;
            if (nb > 0)
                log.InfoFormat("{0}  FACE", nb);
            nb = analyzer.NbFreeFaces;
            if (nb > 0)
                log.InfoFormat("{0}  FACE (Free)", nb);
            nb = analyzer.NbFreeWires;
            if (nb > 0)
                log.InfoFormat("{0}  WIRE (Free)", nb);
            nb = analyzer.NbShells;
            if (nb > 0)
                log.InfoFormat("{0}  SHELL", nb);
            nb = analyzer.NbSolids;
            if (nb > 0)
                log.InfoFormat("{0}  SOLID", nb);
            nb = analyzer.NbVertices;
            if (nb > 0)
                log.InfoFormat("{0}  VERTEX (Oriented)", nb);
            nb = analyzer.NbSharedVertices;
            if (nb > 0)
                log.InfoFormat("{0}  VERTEX (Shared)", nb);
            nb = analyzer.NbWires;
            if (nb > 0)
                log.InfoFormat("{0}  WIRE", nb);
            nb = analyzer.NbFaceWithSevWires;
            if (nb > 0)
                log.InfoFormat("{0}  Face with more than one wire", nb);
            nb = analyzer.NbNoPCurve;
            if (nb > 0)
                log.InfoFormat("{0}  No pcurve", nb);
            nb = analyzer.NbSolidsWithVoids;
            if (nb > 0)
                log.InfoFormat("{0}  SOLID with voids", nb);
            nb = analyzer.NbWireWitnSeam;
            if (nb > 0)
                log.InfoFormat("{0}  Wire(s) with one seam edge", nb);
            nb = analyzer.NbWireWithSevSeams;
            if (nb > 0)
                log.InfoFormat("{0}  Wire(s) with several seam edges", nb);
            nb = analyzer.NbBigSplines;
            if (nb > 0)
                log.InfoFormat("{0}  bigspl : BSpline > 8192 poles", nb);
            nb = analyzer.NbBezierSurf;
            if (nb > 0)
                log.InfoFormat("{0}  bezsur : BezierSurface", nb);
            nb = analyzer.NbBSplibeSurf;
            if (nb > 0)
                log.InfoFormat("{0}  bspsur : BSplineSurface", nb);
            nb = analyzer.NbC0Curves;
            if (nb > 0)
                log.InfoFormat("{0}  c0curv : Curve Only C0", nb);
            nb = analyzer.NbC0Surfaces;
            if (nb > 0)
                log.InfoFormat("{0}  c0surf : Surface Only C0", nb);
            nb = analyzer.NbIndirectSurf;
            if (nb > 0)
                log.InfoFormat("{0}  indsur : Indirect Surface", nb);
            nb = analyzer.NbOffsetCurves;
            if (nb > 0)
                log.InfoFormat("{0}  ofcur  : Offset Curve(s)", nb);
            nb = analyzer.NbOffsetSurf;
            if (nb > 0)
                log.InfoFormat("{0}  ofsur  : Offset Surface", nb);
            nb = analyzer.NbTrimmedCurve2d;
            if (nb > 0)
                log.InfoFormat("{0}  trc2d  : Trimmed Curve2d", nb);
            nb = analyzer.NbTrimmedCurve3d;
            if (nb > 0)
                log.InfoFormat("{0}  trc3d  : Trimmed Curve3d", nb);
            nb = analyzer.NbTrimSurf;
            if (nb > 0)
                log.InfoFormat("{0}  trimsu : RectangularTrimmedSurface", nb);

            log.Info("-------------------");
        }

        /// <summary>
        ///   Equivalent of numshapes DrawTestHarness command.
        /// </summary>
        public static void NumShapesAnalysis(ILog log, TopoDSShape shape)
        {
            log.Info("--- NumShape Info ---");

            var shapeSet = new BRepToolsShapeSet(true);
            shapeSet.Add(shape);

            var nbVertex = 0;
            var nbEdge = 0;
            var nbWire = 0;
            var nbFace = 0;
            var nbShell = 0;
            var nbSolid = 0;
            var nbCompsolid = 0;
            var nbCompound = 0;

            for (var i = 1; i <= shapeSet.NbShapes; i++)
            {
                switch (shapeSet.Shape(i).ShapeType)
                {
                    case TopAbsShapeEnum.TopAbs_VERTEX:
                        nbVertex++;
                        break;
                    case TopAbsShapeEnum.TopAbs_EDGE:
                        nbEdge++;
                        break;
                    case TopAbsShapeEnum.TopAbs_WIRE:
                        nbWire++;
                        break;
                    case TopAbsShapeEnum.TopAbs_FACE:
                        nbFace++;
                        break;
                    case TopAbsShapeEnum.TopAbs_SHELL:
                        nbShell++;
                        break;
                    case TopAbsShapeEnum.TopAbs_SOLID:
                        nbSolid++;
                        break;
                    case TopAbsShapeEnum.TopAbs_COMPSOLID:
                        nbCompsolid++;
                        break;
                    case TopAbsShapeEnum.TopAbs_COMPOUND:
                        nbCompound++;
                        break;
                    case TopAbsShapeEnum.TopAbs_SHAPE:
                        break;
                }
            }

            log.InfoFormat("{0} VERTEX", nbVertex);
            log.InfoFormat("{0} EDGE", nbEdge);
            log.InfoFormat("{0} WIRE", nbWire);
            log.InfoFormat("{0} FACE", nbFace);
            log.InfoFormat("{0} SHELL", nbShell);
            log.InfoFormat("{0} SOLID", nbSolid);
            log.InfoFormat("{0} COMPSOLID", nbCompsolid);
            log.InfoFormat("{0} COMPOUND", nbCompound);

            log.Info("-------------------");
        }
    }
}