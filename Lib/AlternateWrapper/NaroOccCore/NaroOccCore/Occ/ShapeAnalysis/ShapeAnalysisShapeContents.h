#ifndef ShapeAnalysis_ShapeContents_H
#define ShapeAnalysis_ShapeContents_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_Ctor();
extern "C" DECL_EXPORT void ShapeAnalysis_ShapeContents_Clear(void* instance);
extern "C" DECL_EXPORT void ShapeAnalysis_ShapeContents_ClearFlags(void* instance);
extern "C" DECL_EXPORT void ShapeAnalysis_ShapeContents_Perform9EBAC0C0(
	void* instance,
	void* shape);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyBigSplineMode(void* instance);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyIndirectMode(void* instance);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyOffestSurfaceMode(void* instance);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyTrimmed3dMode(void* instance);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyOffsetCurveMode(void* instance);
extern "C" DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyTrimmed2dMode(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSolids(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbShells(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFaces(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWires(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbEdges(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbVertices(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSolidsWithVoids(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBigSplines(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbC0Surfaces(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbC0Curves(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbOffsetSurf(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbIndirectSurf(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbOffsetCurves(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimmedCurve2d(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimmedCurve3d(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBSplibeSurf(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBezierSurf(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimSurf(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWireWitnSeam(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWireWithSevSeams(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFaceWithSevWires(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbNoPCurve(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeFaces(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeWires(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeEdges(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedSolids(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedShells(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFaces(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedWires(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFreeWires(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFreeEdges(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedEdges(void* instance);
extern "C" DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedVertices(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_BigSplineSec(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_IndirectSec(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_OffsetSurfaceSec(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_Trimmed3dSec(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_OffsetCurveSec(void* instance);
extern "C" DECL_EXPORT void* ShapeAnalysis_ShapeContents_Trimmed2dSec(void* instance);
extern "C" DECL_EXPORT void ShapeAnalysisShapeContents_Dtor(void* instance);

#endif
