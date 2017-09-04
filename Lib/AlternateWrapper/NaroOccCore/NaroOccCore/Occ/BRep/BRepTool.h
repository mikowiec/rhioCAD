#ifndef BRep_Tool_H
#define BRep_Tool_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool BRep_Tool_IsClosed9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void* BRep_Tool_SurfaceCE8D63EE(
	void* F,
	void* L);
extern "C" DECL_EXPORT void* BRep_Tool_SurfaceAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void* BRep_Tool_TriangulationCE8D63EE(
	void* F,
	void* L);
extern "C" DECL_EXPORT double BRep_Tool_ToleranceAEC70AC1(
	void* F);
extern "C" DECL_EXPORT bool BRep_Tool_NaturalRestrictionAEC70AC1(
	void* F);
extern "C" DECL_EXPORT bool BRep_Tool_IsGeometric24263856(
	void* E);
extern "C" DECL_EXPORT void* BRep_Tool_CurveC0F32C66(
	void* E,
	void* L,
	double* First,
	double* Last);
extern "C" DECL_EXPORT void* BRep_Tool_Curve218243EB(
	void* E,
	double* First,
	double* Last);
extern "C" DECL_EXPORT bool BRep_Tool_IsClosed65EC701C(
	void* E,
	void* F);
extern "C" DECL_EXPORT bool BRep_Tool_IsClosed492F2C78(
	void* E,
	void* S,
	void* L);
extern "C" DECL_EXPORT bool BRep_Tool_IsClosed3E433981(
	void* E,
	void* T);
extern "C" DECL_EXPORT double BRep_Tool_Tolerance24263856(
	void* E);
extern "C" DECL_EXPORT bool BRep_Tool_SameParameter24263856(
	void* E);
extern "C" DECL_EXPORT bool BRep_Tool_SameRange24263856(
	void* E);
extern "C" DECL_EXPORT bool BRep_Tool_Degenerated24263856(
	void* E);
extern "C" DECL_EXPORT void BRep_Tool_Range218243EB(
	void* E,
	double* First,
	double* Last);
extern "C" DECL_EXPORT void BRep_Tool_Range367873C2(
	void* E,
	void* S,
	void* L,
	double* First,
	double* Last);
extern "C" DECL_EXPORT void BRep_Tool_RangeF1087A9D(
	void* E,
	void* F,
	double* First,
	double* Last);
extern "C" DECL_EXPORT void BRep_Tool_UVPointsCD33147E(
	void* E,
	void* S,
	void* L,
	void* PFirst,
	void* PLast);
extern "C" DECL_EXPORT void BRep_Tool_UVPoints6AA8D466(
	void* E,
	void* F,
	void* PFirst,
	void* PLast);
extern "C" DECL_EXPORT void BRep_Tool_SetUVPointsCD33147E(
	void* E,
	void* S,
	void* L,
	void* PFirst,
	void* PLast);
extern "C" DECL_EXPORT void BRep_Tool_SetUVPoints6AA8D466(
	void* E,
	void* F,
	void* PFirst,
	void* PLast);
extern "C" DECL_EXPORT bool BRep_Tool_HasContinuityA211568F(
	void* E,
	void* F1,
	void* F2);
extern "C" DECL_EXPORT int BRep_Tool_ContinuityA211568F(
	void* E,
	void* F1,
	void* F2);
extern "C" DECL_EXPORT bool BRep_Tool_HasContinuityF876CD3E(
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2);
extern "C" DECL_EXPORT int BRep_Tool_ContinuityF876CD3E(
	void* E,
	void* S1,
	void* S2,
	void* L1,
	void* L2);
extern "C" DECL_EXPORT void* BRep_Tool_Pnt3EF07F6A(
	void* V);
extern "C" DECL_EXPORT double BRep_Tool_Tolerance3EF07F6A(
	void* V);
extern "C" DECL_EXPORT double BRep_Tool_ParameterF133D096(
	void* V,
	void* E);
extern "C" DECL_EXPORT double BRep_Tool_Parameter28AFE250(
	void* V,
	void* E,
	void* F);
extern "C" DECL_EXPORT double BRep_Tool_Parameter9ECB6476(
	void* V,
	void* E,
	void* S,
	void* L);
extern "C" DECL_EXPORT void* BRep_Tool_Parameters6DF2E67(
	void* V,
	void* F);
extern "C" DECL_EXPORT void BRepTool_Dtor(void* instance);

#endif
