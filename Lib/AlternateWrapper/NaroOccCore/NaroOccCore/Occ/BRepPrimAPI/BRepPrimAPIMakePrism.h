#ifndef BRepPrimAPI_MakePrism_H
#define BRepPrimAPI_MakePrism_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_CtorDCCCD2D4(
	void* S,
	void* V,
	bool Copy,
	bool Canonize);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_Ctor6CDB262A(
	void* S,
	void* D,
	bool Inf,
	bool Copy,
	bool Canonize);
extern "C" DECL_EXPORT void BRepPrimAPI_MakePrism_Build(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_FirstShape(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_LastShape(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_FirstShape9EBAC0C0(
	void* instance,
	void* theShape);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakePrism_LastShape9EBAC0C0(
	void* instance,
	void* theShape);
extern "C" DECL_EXPORT void BRepPrimAPIMakePrism_Dtor(void* instance);

#endif
