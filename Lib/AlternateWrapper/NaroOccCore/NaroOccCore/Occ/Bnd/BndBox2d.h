#ifndef Bnd_Box2d_H
#define Bnd_Box2d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Bnd_Box2d_Ctor();
extern "C" DECL_EXPORT void Bnd_Box2d_SetWhole(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_SetVoid(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_Set6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Bnd_Box2d_Set2E9C6BD1(
	void* instance,
	void* P,
	void* D);
extern "C" DECL_EXPORT void Bnd_Box2d_UpdateC2777E0C(
	void* instance,
	double aXmin,
	double aYmin,
	double aXmax,
	double aYmax);
extern "C" DECL_EXPORT void Bnd_Box2d_Update9F0E714F(
	void* instance,
	double X,
	double Y);
extern "C" DECL_EXPORT void Bnd_Box2d_EnlargeD82819F3(
	void* instance,
	double Tol);
extern "C" DECL_EXPORT void Bnd_Box2d_GetC2777E0C(
	void* instance,
	double* aXmin,
	double* aYmin,
	double* aXmax,
	double* aYmax);
extern "C" DECL_EXPORT void Bnd_Box2d_OpenXmin(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_OpenXmax(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_OpenYmin(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_OpenYmax(void* instance);
extern "C" DECL_EXPORT void* Bnd_Box2d_Transformed27621DCB(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Bnd_Box2d_Add5D98465D(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Bnd_Box2d_Add6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT void Bnd_Box2d_Add2E9C6BD1(
	void* instance,
	void* P,
	void* D);
extern "C" DECL_EXPORT void Bnd_Box2d_Add92BBA68E(
	void* instance,
	void* D);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOut6203658C(
	void* instance,
	void* P);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOut5D98465D(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOutD639843B(
	void* instance,
	void* Other,
	void* T);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOutF92CC906(
	void* instance,
	void* T1,
	void* Other,
	void* T2);
extern "C" DECL_EXPORT void Bnd_Box2d_Dump(void* instance);
extern "C" DECL_EXPORT double Bnd_Box2d_GetGap(void* instance);
extern "C" DECL_EXPORT void Bnd_Box2d_SetGap(void* instance, double value);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOpenXmin(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOpenXmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOpenYmin(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsOpenYmax(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsWhole(void* instance);
extern "C" DECL_EXPORT bool Bnd_Box2d_IsVoid(void* instance);
extern "C" DECL_EXPORT void BndBox2d_Dtor(void* instance);

#endif
