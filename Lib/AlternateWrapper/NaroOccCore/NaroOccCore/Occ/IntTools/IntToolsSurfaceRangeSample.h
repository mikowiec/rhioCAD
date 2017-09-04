#ifndef IntTools_SurfaceRangeSample_H
#define IntTools_SurfaceRangeSample_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor();
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor8C6D7843(
	int theIndexU,
	int theDepthU,
	int theIndexV,
	int theDepthV);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor72DC087B(
	void* theRangeU,
	void* theRangeV);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_Ctor7CD3FA85(
	void* Other);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_Assign7CD3FA85(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetRanges72DC087B(
	void* instance,
	void* theRangeU,
	void* theRangeV);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_GetRanges72DC087B(
	void* instance,
	void* theRangeU,
	void* theRangeV);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexes5107F6FE(
	void* instance,
	int theIndexU,
	int theIndexV);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_GetIndexes5107F6FE(
	void* instance,
	int* theIndexU,
	int* theIndexV);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_GetDepths5107F6FE(
	void* instance,
	int* theDepthU,
	int* theDepthV);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_GetRangeU89C01C9C(
	void* instance,
	double theFirstU,
	double theLastU,
	int theNbSampleU);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_GetRangeV89C01C9C(
	void* instance,
	double theFirstV,
	double theLastV,
	int theNbSampleV);
extern "C" DECL_EXPORT bool IntTools_SurfaceRangeSample_IsEqual7CD3FA85(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetRangeIndexUDeeperE8219145(
	void* instance,
	int theNbSampleU);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetRangeIndexVDeeperE8219145(
	void* instance,
	int theNbSampleV);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetSampleRangeU(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_GetSampleRangeU(void* instance);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetSampleRangeV(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_SurfaceRangeSample_GetSampleRangeV(void* instance);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexU(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetIndexU(void* instance);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetIndexV(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetIndexV(void* instance);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetDepthU(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetDepthU(void* instance);
extern "C" DECL_EXPORT void IntTools_SurfaceRangeSample_SetDepthV(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_SurfaceRangeSample_GetDepthV(void* instance);
extern "C" DECL_EXPORT void IntToolsSurfaceRangeSample_Dtor(void* instance);

#endif
