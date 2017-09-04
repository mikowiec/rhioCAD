#ifndef BRepFilletAPI_MakeChamfer_H
#define BRepFilletAPI_MakeChamfer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepFilletAPI_MakeChamfer_Ctor9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add36F68A5F(
	void* instance,
	double Dis,
	void* E,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDist264F3866(
	void* instance,
	double Dis,
	int IC,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_GetDist69F5FCCD(
	void* instance,
	int IC,
	double* Dis);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Add17BBF1FC(
	void* instance,
	double Dis1,
	double Dis2,
	void* E,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDists5071FCAE(
	void* instance,
	double Dis1,
	double Dis2,
	int IC,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Dists306E0DFB(
	void* instance,
	int IC,
	double* Dis1,
	double* Dis2);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_AddDA17BBF1FC(
	void* instance,
	double Dis,
	double Angle,
	void* E,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_SetDistAngle5071FCAE(
	void* instance,
	double Dis,
	double Angle,
	int IC,
	void* F);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsSymetricE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsTwoDistancesE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsDistanceAngleE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_ResetContourE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeChamfer_Contour24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbEdgesE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeChamfer_Edge5107F6FE(
	void* instance,
	int I,
	int J);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Remove24263856(
	void* instance,
	void* E);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeChamfer_LengthE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeChamfer_FirstVertexE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void* BRepFilletAPI_MakeChamfer_LastVertexE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeChamfer_Abscissa680D393(
	void* instance,
	int IC,
	void* V);
extern "C" DECL_EXPORT double BRepFilletAPI_MakeChamfer_RelativeAbscissa680D393(
	void* instance,
	int IC,
	void* V);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_ClosedAndTangentE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_ClosedE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Build(void* instance);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_Reset(void* instance);
extern "C" DECL_EXPORT bool BRepFilletAPI_MakeChamfer_IsDeleted9EBAC0C0(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRepFilletAPI_MakeChamfer_SimulateE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbSurfE8219145(
	void* instance,
	int IC);
extern "C" DECL_EXPORT int BRepFilletAPI_MakeChamfer_NbContours(void* instance);
extern "C" DECL_EXPORT void BRepFilletAPIMakeChamfer_Dtor(void* instance);

#endif
