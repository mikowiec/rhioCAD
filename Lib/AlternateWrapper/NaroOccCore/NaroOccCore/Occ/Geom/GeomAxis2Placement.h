#ifndef Geom_Axis2Placement_H
#define Geom_Axis2Placement_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Geom_Axis2Placement_Ctor7895386A(
	void* A2);
extern "C" DECL_EXPORT void* Geom_Axis2Placement_CtorF36E9D55(
	void* P,
	void* N,
	void* Vx);
extern "C" DECL_EXPORT void Geom_Axis2Placement_Transform72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Geom_Axis2Placement_SetDirection(void* instance, void* value);
extern "C" DECL_EXPORT void Geom_Axis2Placement_SetAx2(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Axis2Placement_Ax2(void* instance);
extern "C" DECL_EXPORT void Geom_Axis2Placement_SetXDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Axis2Placement_XDirection(void* instance);
extern "C" DECL_EXPORT void Geom_Axis2Placement_SetYDirection(void* instance, void* value);
extern "C" DECL_EXPORT void* Geom_Axis2Placement_YDirection(void* instance);
extern "C" DECL_EXPORT void* Geom_Axis2Placement_Copy(void* instance);
extern "C" DECL_EXPORT void GeomAxis2Placement_Dtor(void* instance);

#endif
