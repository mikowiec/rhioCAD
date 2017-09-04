#ifndef BOPTools_PointBetween_H
#define BOPTools_PointBetween_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_PointBetween_Ctor();
extern "C" DECL_EXPORT void BOPTools_PointBetween_SetUV9F0E714F(
	void* instance,
	double U,
	double V);
extern "C" DECL_EXPORT void BOPTools_PointBetween_UV9F0E714F(
	void* instance,
	double* U,
	double* V);
extern "C" DECL_EXPORT void BOPTools_PointBetween_SetParameter(void* instance, double value);
extern "C" DECL_EXPORT double BOPTools_PointBetween_Parameter(void* instance);
extern "C" DECL_EXPORT void BOPTools_PointBetween_SetPnt(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PointBetween_Pnt(void* instance);
extern "C" DECL_EXPORT void BOPToolsPointBetween_Dtor(void* instance);

#endif
