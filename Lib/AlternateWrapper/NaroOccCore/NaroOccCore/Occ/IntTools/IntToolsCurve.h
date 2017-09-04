#ifndef IntTools_Curve_H
#define IntTools_Curve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_Curve_Ctor();
extern "C" DECL_EXPORT void IntTools_Curve_BoundsB51F241F(
	void* instance,
	double* aT1,
	double* aT2,
	void* aP1,
	void* aP2);
extern "C" DECL_EXPORT bool IntTools_Curve_D053A5A2C1(
	void* instance,
	double* aT1,
	void* aP1);
extern "C" DECL_EXPORT void IntTools_Curve_SetCurve(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_Curve_Curve(void* instance);
extern "C" DECL_EXPORT bool IntTools_Curve_HasBounds(void* instance);
extern "C" DECL_EXPORT int IntTools_Curve_Type(void* instance);
extern "C" DECL_EXPORT void IntToolsCurve_Dtor(void* instance);

#endif
