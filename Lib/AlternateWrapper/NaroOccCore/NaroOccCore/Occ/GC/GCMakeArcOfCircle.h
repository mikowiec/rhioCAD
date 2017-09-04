#ifndef GC_MakeArcOfCircle_H
#define GC_MakeArcOfCircle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_CtorB4ED9646(
	void* Circ,
	double Alpha1,
	double Alpha2,
	bool Sense);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_CtorF0177DDE(
	void* Circ,
	void* P,
	double Alpha,
	bool Sense);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_CtorFA26BC9F(
	void* Circ,
	void* P1,
	void* P2,
	bool Sense);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_Ctor4B855FC1(
	void* P1,
	void* P2,
	void* P3);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_Ctor5450E69C(
	void* P1,
	void* V,
	void* P2);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_Value(void* instance);
extern "C" DECL_EXPORT void* GC_MakeArcOfCircle_Operator(void* instance);
extern "C" DECL_EXPORT void GCMakeArcOfCircle_Dtor(void* instance);

#endif
