#ifndef Bnd_Box_H
#define Bnd_Box_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Bnd_Box_Ctor();
extern "C" DECL_EXPORT void Bnd_Box_SetWhole(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_SetVoid(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_Set9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Bnd_Box_SetE13B639C(
	void* instance,
	void* P,
	void* D);
extern "C" DECL_EXPORT void Bnd_Box_UpdateBC7A5786(
	void* instance,
	double aXmin,
	double aYmin,
	double aZmin,
	double aXmax,
	double aYmax,
	double aZmax);
extern "C" DECL_EXPORT void Bnd_Box_Update9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void Bnd_Box_EnlargeD82819F3(
	void* instance,
	double Tol);
extern "C" DECL_EXPORT void Bnd_Box_GetBC7A5786(
	void* instance,
	double* aXmin,
	double* aYmin,
	double* aZmin,
	double* aXmax,
	double* aYmax,
	double* aZmax);
extern "C" DECL_EXPORT void Bnd_Box_OpenXmin(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_OpenXmax(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_OpenYmin(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_OpenYmax(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_OpenZmin(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_OpenZmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsXThinD82819F3(
	void* instance,
	double tol);
extern "C" DECL_EXPORT bool Bnd_Box_IsYThinD82819F3(
	void* instance,
	double tol);
extern "C" DECL_EXPORT bool Bnd_Box_IsZThinD82819F3(
	void* instance,
	double tol);
extern "C" DECL_EXPORT bool Bnd_Box_IsThinD82819F3(
	void* instance,
	double tol);
extern "C" DECL_EXPORT void* Bnd_Box_Transformed72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Bnd_Box_Add1ADB021(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Bnd_Box_Add9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Bnd_Box_AddE13B639C(
	void* instance,
	void* P,
	void* D);
extern "C" DECL_EXPORT void Bnd_Box_AddCEC711A5(
	void* instance,
	void* D);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut9EAECD5B(
	void* instance,
	void* P);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut9917D291(
	void* instance,
	void* L);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut9914D2AD(
	void* instance,
	void* P);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut1ADB021(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut3A879F89(
	void* instance,
	void* Other,
	void* T);
extern "C" DECL_EXPORT bool Bnd_Box_IsOutBCD9C93D(
	void* instance,
	void* T1,
	void* Other,
	void* T2);
extern "C" DECL_EXPORT bool Bnd_Box_IsOut637767F(
	void* instance,
	void* P1,
	void* P2,
	void* D);
extern "C" DECL_EXPORT double Bnd_Box_Distance1ADB021(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Bnd_Box_Dump(void* instance);
extern "C" DECL_EXPORT double Bnd_Box_GetGap(void* instance);
extern "C" DECL_EXPORT void Bnd_Box_SetGap(void* instance, double value);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenXmin(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenXmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenYmin(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenYmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenZmin(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsOpenZmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsWhole(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box_IsVoid(void* instance);
extern "C" DECL_EXPORT double Bnd_Box_SquareExtent(void* instance);
extern "C" DECL_EXPORT void BndBox_Dtor(void* instance);

#endif
