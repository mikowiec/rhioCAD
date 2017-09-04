#ifndef BRepFilletAPI_MakeFillet_H
#define BRepFilletAPI_MakeFillet_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_Ctor64E28302(
	void* S,
	int FShape);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetParamsBC7A5786(
	void* instance,
	double Tang,
	double Tesp,
	double T2d,
	double TApp3d,
	double TolApp2d,
	double Fleche);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetContinuity25CDA01E(
	void* instance,
	int InternalContinuity,
	double AngularTolerance);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Add24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Add4236945C(
	void* instance,
	double Radius,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_AddA7A851FF(
	void* instance,
	double R1,
	double R2,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Add1E23979B(
	void* instance,
	void* L,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius6B6E73CA(
	void* instance,
	double Radius,
	int IC,
	int IinC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius852507E(
	void* instance,
	double R1,
	double R2,
	int IC,
	int IinC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadiusE982E75B(
	void* instance,
	void* L,
	int IC,
	int IinC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_ResetContourE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsConstantE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeFillet_RadiusE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsConstant9ED07AFD(
	void* instance,
	int IC,
	void* E);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeFillet_Radius9ED07AFD(
	void* instance,
	int IC,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadius3B769637(
	void* instance,
	double Radius,
	int IC,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetRadiusD24B0016(
	void* instance,
	double Radius,
	int IC,
	void* V);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_GetBoundsD04B1C17(
	void* instance,
	int IC,
	void* E,
	double* F,
	double* L);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_GetLaw9ED07AFD(
	void* instance,
	int IC,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetLawB084795E(
	void* instance,
	int IC,
	void* E,
	void* L);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_Contour24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbEdgesE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_Edge5107F6FE(
	void* instance,
	int I,
	int J);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Remove24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeFillet_LengthE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_FirstVertexE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_LastVertexE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeFillet_Abscissa680D393(
	void* instance,
	int IC,
	void* V);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeFillet_RelativeAbscissa680D393(
	void* instance,
	int IC,
	void* V);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_ClosedAndTangentE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_ClosedE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Build(void* instance);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_Reset(void* instance);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_IsDeleted9EBAC0C0(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SimulateE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbSurfE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_FaultyContourE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbComputedSurfacesE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_ComputedSurface5107F6FE(
	void* instance,
	int IC,
	int IS);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_FaultyVertexE8219145(
	void* instance,
	int IV);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_StripeStatusE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeFillet_SetFilletShape(void* instance, int value);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_GetFilletShape(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbContours(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbSurfaces(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbFaultyContours(void* instance);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeFillet_NbFaultyVertices(void* instance);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeFillet_HasResult(void* instance);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeFillet_BadShape(void* instance);
extern "C" DECL_EXPORT void BRepFilletAPIMakeFillet_Dtor(void* instance);

#endif
