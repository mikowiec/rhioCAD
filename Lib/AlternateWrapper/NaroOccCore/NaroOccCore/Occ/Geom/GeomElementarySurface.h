#ifndef Geom_ElementarySurface_H
#define Geom_ElementarySurface_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Geom_ElementarySurface_UReverse(void* instance);
extern "C" DECL_EXPORT void Geom_ElementarySurface_VReverse(void* instance);
extern "C" DECL_EXPORT bool Geom_ElementarySurface_IsCNuE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT bool Geom_ElementarySurface_IsCNvE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_ElementarySurface_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_ElementarySurface_Axis(void* instance);
extern "C" DECL_EXPORT void Geom_ElementarySurface_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_ElementarySurface_Location(void* instance);
extern "C" DECL_EXPORT void Geom_ElementarySurface_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_ElementarySurface_Position(void* instance);
extern "C" DECL_EXPORT int Geom_ElementarySurface_Continuity(void* instance);
extern "C" DECL_EXPORT void GeomElementarySurface_Dtor(void* instance);

#endif
