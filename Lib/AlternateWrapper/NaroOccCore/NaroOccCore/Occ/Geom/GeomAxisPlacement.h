#ifndef Geom_AxisPlacement_H
#define Geom_AxisPlacement_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT double Geom_AxisPlacement_AngleB4DE3BBC(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Geom_AxisPlacement_SetAxis(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_AxisPlacement_Axis(void* instance);
extern "C" DECL_EXPORT void* Geom_AxisPlacement_Direction(void* instance);
extern "C" DECL_EXPORT void Geom_AxisPlacement_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_AxisPlacement_Location(void* instance);
extern "C" DECL_EXPORT void GeomAxisPlacement_Dtor(void* instance);

#endif
