#include "ShapeAnalysisShapeContents.h"
#include <ShapeAnalysis_ShapeContents.hxx>

#include <TopTools_HSequenceOfShape.hxx>

DECL_EXPORT void* ShapeAnalysis_ShapeContents_Ctor()
{
	return new ShapeAnalysis_ShapeContents();
}
DECL_EXPORT void ShapeAnalysis_ShapeContents_Clear(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
 	result->Clear();
}
DECL_EXPORT void ShapeAnalysis_ShapeContents_ClearFlags(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
 	result->ClearFlags();
}
DECL_EXPORT void ShapeAnalysis_ShapeContents_Perform9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
 	result->Perform(			
_shape);
}
DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyBigSplineMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyBigSplineMode();
}

DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyIndirectMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyIndirectMode();
}

DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyOffestSurfaceMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyOffestSurfaceMode();
}

DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyTrimmed3dMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyTrimmed3dMode();
}

DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyOffsetCurveMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyOffsetCurveMode();
}

DECL_EXPORT bool ShapeAnalysis_ShapeContents_ModifyTrimmed2dMode(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->ModifyTrimmed2dMode();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSolids(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSolids();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbShells(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbShells();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFaces(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbFaces();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWires(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbWires();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbEdges(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbEdges();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbVertices(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbVertices();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSolidsWithVoids(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSolidsWithVoids();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBigSplines(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbBigSplines();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbC0Surfaces(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbC0Surfaces();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbC0Curves(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbC0Curves();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbOffsetSurf(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbOffsetSurf();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbIndirectSurf(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbIndirectSurf();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbOffsetCurves(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbOffsetCurves();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimmedCurve2d(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbTrimmedCurve2d();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimmedCurve3d(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbTrimmedCurve3d();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBSplibeSurf(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbBSplibeSurf();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbBezierSurf(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbBezierSurf();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbTrimSurf(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbTrimSurf();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWireWitnSeam(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbWireWitnSeam();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbWireWithSevSeams(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbWireWithSevSeams();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFaceWithSevWires(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbFaceWithSevWires();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbNoPCurve(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbNoPCurve();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeFaces(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbFreeFaces();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeWires(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbFreeWires();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbFreeEdges(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbFreeEdges();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedSolids(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedSolids();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedShells(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedShells();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFaces(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedFaces();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedWires(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedWires();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFreeWires(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedFreeWires();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedFreeEdges(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedFreeEdges();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedEdges(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedEdges();
}

DECL_EXPORT int ShapeAnalysis_ShapeContents_NbSharedVertices(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	result->NbSharedVertices();
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_BigSplineSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->BigSplineSec());
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_IndirectSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->IndirectSec());
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_OffsetSurfaceSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->OffsetSurfaceSec());
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_Trimmed3dSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->Trimmed3dSec());
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_OffsetCurveSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->OffsetCurveSec());
}

DECL_EXPORT void* ShapeAnalysis_ShapeContents_Trimmed2dSec(void* instance)
{
	ShapeAnalysis_ShapeContents* result = (ShapeAnalysis_ShapeContents*)instance;
	return 	new Handle_TopTools_HSequenceOfShape(	result->Trimmed2dSec());
}

DECL_EXPORT void ShapeAnalysisShapeContents_Dtor(void* instance)
{
	delete (ShapeAnalysis_ShapeContents*)instance;
}
