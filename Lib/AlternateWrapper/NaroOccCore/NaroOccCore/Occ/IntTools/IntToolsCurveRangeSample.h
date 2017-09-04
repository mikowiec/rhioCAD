#ifndef IntTools_CurveRangeSample_H
#define IntTools_CurveRangeSample_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_CurveRangeSample_Ctor();
extern "C" DECL_EXPORT void* IntTools_CurveRangeSample_CtorE8219145(
	int theIndex);
extern "C" DECL_EXPORT bool IntTools_CurveRangeSample_IsEqual6A019644(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void* IntTools_CurveRangeSample_GetRange89C01C9C(
	void* instance,
	double theFirst,
	double theLast,
	int theNbSample);
extern "C" DECL_EXPORT int IntTools_CurveRangeSample_GetRangeIndexDeeperE8219145(
	void* instance,
	int theNbSample);
extern "C" DECL_EXPORT void IntTools_CurveRangeSample_SetRangeIndex(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_CurveRangeSample_GetRangeIndex(void* instance);
extern "C" DECL_EXPORT void IntToolsCurveRangeSample_Dtor(void* instance);

#endif
