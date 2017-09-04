#ifndef Geom_Axis1Placement_H
#define Geom_Axis1Placement_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Axis1Placement_Ctor608B963B(
	void* A1);
extern "C" DECL_EXPORT void* Geom_Axis1Placement_CtorE13B639C(
	void* P,
	void* V);
extern "C" DECL_EXPORT void Geom_Axis1Placement_Reverse(void* instance);
extern "C" DECL_EXPORT void Geom_Axis1Placement_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* Geom_Axis1Placement_Ax1(void* instance);
extern "C" DECL_EXPORT void* Geom_Axis1Placement_Reversed(void* instance);
extern "C" DECL_EXPORT void Geom_Axis1Placement_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Axis1Placement_Copy(void* instance);
extern "C" DECL_EXPORT void GeomAxis1Placement_Dtor(void* instance);

#endif
