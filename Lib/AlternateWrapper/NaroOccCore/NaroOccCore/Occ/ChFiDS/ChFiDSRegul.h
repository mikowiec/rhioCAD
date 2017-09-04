#ifndef ChFiDS_Regul_H
#define ChFiDS_Regul_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* ChFiDS_Regul_Ctor();
extern "C" DECL_EXPORT void ChFiDS_Regul_SetS1898DAFFC(
	void* instance,
	int IS1,
	bool IsFace);
extern "C" DECL_EXPORT void ChFiDS_Regul_SetS2898DAFFC(
	void* instance,
	int IS2,
	bool IsFace);
extern "C" DECL_EXPORT int ChFiDS_Regul_S1(void* instance);
extern "C" DECL_EXPORT int ChFiDS_Regul_S2(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_Regul_IsSurface1(void* instance);
extern "C" DECL_EXPORT bool ChFiDS_Regul_IsSurface2(void* instance);
extern "C" DECL_EXPORT void ChFiDS_Regul_SetCurve(void* instance, int value);
extern "C" DECL_EXPORT int ChFiDS_Regul_Curve(void* instance);
extern "C" DECL_EXPORT void ChFiDSRegul_Dtor(void* instance);

#endif
