#ifndef BRepOffset_Interval_H
#define BRepOffset_Interval_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepOffset_Interval_Ctor();
extern "C" DECL_EXPORT void* BRepOffset_Interval_CtorF3B48FAD(
	double U1,
	double U2,
	int Type);
extern "C" DECL_EXPORT void BRepOffset_Interval_FirstD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void BRepOffset_Interval_LastD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void BRepOffset_Interval_TypeFFDE8065(
	void* instance,
	int T);
extern "C" DECL_EXPORT double BRepOffset_Interval_First(void* instance);
extern "C" DECL_EXPORT double BRepOffset_Interval_Last(void* instance);
extern "C" DECL_EXPORT int BRepOffset_Interval_Type(void* instance);
extern "C" DECL_EXPORT void BRepOffsetInterval_Dtor(void* instance);

#endif
