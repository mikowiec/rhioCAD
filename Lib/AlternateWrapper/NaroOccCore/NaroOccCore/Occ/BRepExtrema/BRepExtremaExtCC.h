#ifndef BRepExtrema_ExtCC_H
#define BRepExtrema_ExtCC_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepExtrema_ExtCC_Ctor();
extern "C" DECL_EXPORT void* BRepExtrema_ExtCC_Ctor4DFF7017(
	void* E1,
	void* E2);
extern "C" DECL_EXPORT void BRepExtrema_ExtCC_Initialize24263856(
	void* instance,
	void* E2);
extern "C" DECL_EXPORT void BRepExtrema_ExtCC_Perform24263856(
	void* instance,
	void* E1);
extern "C" DECL_EXPORT double BRepExtrema_ExtCC_SquareDistanceE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT double BRepExtrema_ExtCC_ParameterOnE1E8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* BRepExtrema_ExtCC_PointOnE1E8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT double BRepExtrema_ExtCC_ParameterOnE2E8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void* BRepExtrema_ExtCC_PointOnE2E8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void BRepExtrema_ExtCC_TrimmedDistancesACE69995(
	void* instance,
	double* dist11,
	double* distP12,
	double* distP21,
	double* distP22,
	void* P11,
	void* P12,
	void* P21,
	void* P22);
extern "C" DECL_EXPORT bool BRepExtrema_ExtCC_IsDone(void* instance);
extern "C" DECL_EXPORT int BRepExtrema_ExtCC_NbExt(void* instance);
extern "C" DECL_EXPORT bool BRepExtrema_ExtCC_IsParallel(void* instance);
extern "C" DECL_EXPORT void BRepExtremaExtCC_Dtor(void* instance);

#endif
