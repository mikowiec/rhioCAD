#ifndef Geom_Conic_H
#define Geom_Conic_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Geom_Conic_Reverse(void* instance);
extern "C" DECL_EXPORT bool Geom_Conic_IsCNE8219145(
	void* instance,
	int N);
extern "C" DECL_EXPORT void Geom_Conic_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Conic_Axis(void* instance);
extern "C" DECL_EXPORT void Geom_Conic_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Conic_Location(void* instance);
extern "C" DECL_EXPORT void Geom_Conic_SetPosition(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Conic_Position(void* instance);
extern "C" DECL_EXPORT void* Geom_Conic_XAxis(void* instance);
extern "C" DECL_EXPORT void* Geom_Conic_YAxis(void* instance);
extern "C" DECL_EXPORT int Geom_Conic_Continuity(void* instance);
extern "C" DECL_EXPORT void GeomConic_Dtor(void* instance);

#endif
