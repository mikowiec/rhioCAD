#ifndef BRepTools_H
#define BRepTools_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepTools_UVBounds443C7451(
	void* F,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax);
extern "C" DECL_EXPORT void BRepTools_UVBoundsEF82485C(
	void* F,
	void* W,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax);
extern "C" DECL_EXPORT void BRepTools_UVBounds5F413ED6(
	void* F,
	void* E,
	double* UMin,
	double* UMax,
	double* VMin,
	double* VMax);
extern "C" DECL_EXPORT void BRepTools_AddUVBounds38403D27(
	void* F,
	void* B);
extern "C" DECL_EXPORT void BRepTools_AddUVBounds3ADDD719(
	void* F,
	void* W,
	void* B);
extern "C" DECL_EXPORT void BRepTools_AddUVBounds5756543C(
	void* F,
	void* E,
	void* B);
extern "C" DECL_EXPORT void BRepTools_Update3EF07F6A(
	void* V);
extern "C" DECL_EXPORT void BRepTools_Update24263856(
	void* E);
extern "C" DECL_EXPORT void BRepTools_Update368EDFE5(
	void* W);
extern "C" DECL_EXPORT void BRepTools_UpdateAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void BRepTools_Update41B0EE4D(
	void* S);
extern "C" DECL_EXPORT void BRepTools_Update56111E92(
	void* S);
extern "C" DECL_EXPORT void BRepTools_Update2CBA9E0B(
	void* C);
extern "C" DECL_EXPORT void BRepTools_UpdateF7963FEC(
	void* C);
extern "C" DECL_EXPORT void BRepTools_Update9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void BRepTools_UpdateFaceUVPointsAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void BRepTools_Clean9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT void BRepTools_RemoveUnusedPCurves9EBAC0C0(
	void* S);
extern "C" DECL_EXPORT bool BRepTools_Triangulation92EB56FA(
	void* S,
	double deflec);
extern "C" DECL_EXPORT bool BRepTools_Compare17F57B4B(
	void* V1,
	void* V2);
extern "C" DECL_EXPORT bool BRepTools_Compare4DFF7017(
	void* E1,
	void* E2);
extern "C" DECL_EXPORT void* BRepTools_OuterWireAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void* BRepTools_OuterShell56111E92(
	void* S);
extern "C" DECL_EXPORT void BRepTools_Map3DEdgesBBDCAF89(
	void* S,
	void* M);
extern "C" DECL_EXPORT bool BRepTools_IsReallyClosed65EC701C(
	void* E,
	void* F);
extern "C" DECL_EXPORT bool BRepTools_Write4AF8BC88(
	void* Sh,
	char* File,
	void* PR);
extern "C" DECL_EXPORT bool BRepTools_ReadEBEE9A3E(
	void* Sh,
	char* File,
	void* B,
	void* PR);
extern "C" DECL_EXPORT void BRepTools_Dtor(void* instance);

#endif
