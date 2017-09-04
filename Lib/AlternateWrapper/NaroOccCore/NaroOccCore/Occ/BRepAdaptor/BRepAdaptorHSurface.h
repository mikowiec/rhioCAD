#ifndef BRepAdaptor_HSurface_H
#define BRepAdaptor_HSurface_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepAdaptor_HSurface_Ctor();
extern "C" DECL_EXPORT void* BRepAdaptor_HSurface_CtorE0C6985A(
	void* S);
extern "C" DECL_EXPORT void BRepAdaptor_HSurface_SetE0C6985A(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void* BRepAdaptor_HSurface_Surface(void* instance);
extern "C" DECL_EXPORT void* BRepAdaptor_HSurface_ChangeSurface(void* instance);
extern "C" DECL_EXPORT void BRepAdaptorHSurface_Dtor(void* instance);

#endif
