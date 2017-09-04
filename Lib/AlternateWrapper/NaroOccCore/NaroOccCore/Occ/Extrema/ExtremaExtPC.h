#ifndef Extrema_ExtPC_H
#define Extrema_ExtPC_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Extrema_ExtPC_Ctor();
extern "C" DECL_EXPORT void* Extrema_ExtPC_CtorCF4A20E8(
	void* P,
	void* C,
	double Uinf,
	double Usup,
	double TolF);
extern "C" DECL_EXPORT void* Extrema_ExtPC_CtorB2B0ECF0(
	void* P,
	void* C,
	double TolF);
extern "C" DECL_EXPORT void Extrema_ExtPC_InitializeFE87C4E9(
	void* instance,
	void* C,
	double Uinf,
	double Usup,
	double TolF);
extern "C" DECL_EXPORT double Extrema_ExtPC_SquareDistanceE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Extrema_ExtPC_TrimmedSquareDistancesB51F241F(
	void* instance,
	double* dist1,
	double* dist2,
	void* P1,
	void* P2);
extern "C" DECL_EXPORT bool Extrema_ExtPC_IsDone(void* instance);
extern "C" DECL_EXPORT int Extrema_ExtPC_NbExt(void* instance);
extern "C" DECL_EXPORT void ExtremaExtPC_Dtor(void* instance);

#endif
