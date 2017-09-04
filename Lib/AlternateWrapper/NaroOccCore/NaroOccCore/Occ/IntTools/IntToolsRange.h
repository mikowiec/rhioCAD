#ifndef IntTools_Range_H
#define IntTools_Range_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_Range_Ctor();
extern "C" DECL_EXPORT void* IntTools_Range_Ctor9F0E714F(
	double aFirst,
	double aLast);
extern "C" DECL_EXPORT void IntTools_Range_Range9F0E714F(
	void* instance,
	double* aFirst,
	double* aLast);
extern "C" DECL_EXPORT void IntTools_Range_SetFirst(void* instance, double value);
extern "C" DECL_EXPORT double IntTools_Range_First(void* instance);
extern "C" DECL_EXPORT void IntTools_Range_SetLast(void* instance, double value);
extern "C" DECL_EXPORT double IntTools_Range_Last(void* instance);
extern "C" DECL_EXPORT void IntToolsRange_Dtor(void* instance);

#endif
