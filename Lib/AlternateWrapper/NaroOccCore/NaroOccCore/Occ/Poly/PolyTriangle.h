#ifndef Poly_Triangle_H
#define Poly_Triangle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Poly_Triangle_Ctor();
extern "C" DECL_EXPORT void* Poly_Triangle_CtorE278791(
	int N1,
	int N2,
	int N3);
extern "C" DECL_EXPORT void Poly_Triangle_SetE278791(
	void* instance,
	int N1,
	int N2,
	int N3);
extern "C" DECL_EXPORT void Poly_Triangle_Set5107F6FE(
	void* instance,
	int Index,
	int Node);
extern "C" DECL_EXPORT void Poly_Triangle_GetE278791(
	void* instance,
	int* N1,
	int* N2,
	int* N3);
extern "C" DECL_EXPORT int Poly_Triangle_ValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT int Poly_Triangle_ChangeValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void PolyTriangle_Dtor(void* instance);

#endif
