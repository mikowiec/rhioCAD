#ifndef BRepPrimAPI_MakeRevol_H
#define BRepPrimAPI_MakeRevol_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_CtorFAF6E492(
	void* S,
	void* A,
	double D,
	bool Copy);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_CtorE3E37232(
	void* S,
	void* A,
	bool Copy);
extern "C" DECL_EXPORT void BRepPrimAPI_MakeRevol_Build(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_FirstShape(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_LastShape(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_FirstShape9EBAC0C0(
	void* instance,
	void* theShape);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeRevol_LastShape9EBAC0C0(
	void* instance,
	void* theShape);
extern "C" DECL_EXPORT bool BRepPrimAPI_MakeRevol_HasDegenerated(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeRevol_Dtor(void* instance);

#endif
