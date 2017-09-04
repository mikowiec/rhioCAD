#ifndef IntSurf_PntOn2S_H
#define IntSurf_PntOn2S_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntSurf_PntOn2S_Ctor();
extern "C" DECL_EXPORT void IntSurf_PntOn2S_SetValue9EAECD5B(
	void* instance,
	void* Pt);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_SetValue705FE798(
	void* instance,
	void* Pt,
	bool OnFirst,
	double U,
	double V);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_SetValueD969C62A(
	void* instance,
	void* Pt,
	double U1,
	double V1,
	double U2,
	double V2);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_SetValueDA23FEE7(
	void* instance,
	bool OnFirst,
	double U,
	double V);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_SetValueC2777E0C(
	void* instance,
	double U1,
	double V1,
	double U2,
	double V2);
extern "C" DECL_EXPORT void* IntSurf_PntOn2S_Value(void* instance);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_ParametersOnS19F0E714F(
	void* instance,
	double* U1,
	double* V1);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_ParametersOnS29F0E714F(
	void* instance,
	double* U2,
	double* V2);
extern "C" DECL_EXPORT void IntSurf_PntOn2S_ParametersC2777E0C(
	void* instance,
	double* U1,
	double* V1,
	double* U2,
	double* V2);
extern "C" DECL_EXPORT void IntSurfPntOn2S_Dtor(void* instance);

#endif
