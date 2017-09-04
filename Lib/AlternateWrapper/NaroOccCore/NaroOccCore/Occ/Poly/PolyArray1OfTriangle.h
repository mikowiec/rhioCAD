#ifndef Poly_Array1OfTriangle_H
#define Poly_Array1OfTriangle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Poly_Array1OfTriangle_Ctor5107F6FE(
	int Low,
	int Up);
extern "C" DECL_EXPORT void* Poly_Array1OfTriangle_Ctor522DB52C(
	void* Item,
	int Low,
	int Up);
extern "C" DECL_EXPORT void Poly_Array1OfTriangle_Init170E771E(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* Poly_Array1OfTriangle_Assign8767CC10(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Poly_Array1OfTriangle_SetValue9D4F3515(
	void* instance,
	int Index,
	void* Value);
extern "C" DECL_EXPORT void* Poly_Array1OfTriangle_ValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void* Poly_Array1OfTriangle_ChangeValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT bool Poly_Array1OfTriangle_IsAllocated(void* instance);
extern "C" DECL_EXPORT int Poly_Array1OfTriangle_Length(void* instance);
extern "C" DECL_EXPORT int Poly_Array1OfTriangle_Lower(void* instance);
extern "C" DECL_EXPORT int Poly_Array1OfTriangle_Upper(void* instance);
extern "C" DECL_EXPORT void PolyArray1OfTriangle_Dtor(void* instance);

#endif
